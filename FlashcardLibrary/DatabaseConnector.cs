using Dapper;
using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace FlashcardLibrary
{
    public class DatabaseConnector : IDataConnector
    {
        private const string DB = "Flashcards";

        public static IDataConnector Connection { get; private set; }

        public static void InitializeDatabaseConnection()
        {
            DatabaseConnector connection = new DatabaseConnector();
            Connection = connection;
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


        public void CreateDeck(DeckModel deck)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@DeckName", deck.DeckName);
                parameters.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spDecks_Insert", parameters, commandType: CommandType.StoredProcedure);

                deck.ID = parameters.Get<int>("@ID");
            }
        }

        public void CreateCard(CardModel card, int DeckID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CardFront", card.CardFront);
                parameters.Add("@CardBack", card.CardBack);
                parameters.Add("@DeckID", DeckID);
                parameters.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCards_Insert", parameters, commandType: CommandType.StoredProcedure);

                card.ID = parameters.Get<int>("@ID");
            }
        }

        public List<CardModel> GetAll_Cards(int DeckID)
        {
            List<CardModel> cardList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@DeckID", DeckID);
                cardList = connection.Query<CardModel>("dbo.spCards_GetAll", parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            cardList.OrderBy(x => x.Difficulty);

            return cardList;
        }

        public List<DeckModel> GetAll_Decks()
        {
            List<DeckModel> deckList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {

                deckList = connection.Query<DeckModel>("dbo.spDecks_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return deckList;
        }

        public void DeleteDeck(int DeckID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", DeckID);

                connection.Execute("dbo.spDecks_DeleteADeck", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteCard(int CardID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", CardID);

                connection.Execute("dbo.spCards_DeleteACard", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditDeck(DeckModel deck, int DeckID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", DeckID);
                parameters.Add("@DeckName", deck.DeckName);

                connection.Execute("dbo.spDecks_Edit", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditCardText(CardModel card, int CardID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", CardID);
                parameters.Add("@CardFront", card.CardFront);
                parameters.Add("@CardBack", card.CardBack);

                connection.Execute("dbo.spCards_EditCardText", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void EditCardDifficulty(CardModel card, string userResponseType, int CardID)
        {
            double newDifficulty = 1;
                
            if (card.Difficulty != 0) newDifficulty = card.Difficulty;

            if (userResponseType == "again") newDifficulty *= 2;
            if (userResponseType == "hard") newDifficulty *= 1.5;
            if (userResponseType == "good") newDifficulty /= 1.75;
            if (userResponseType == "easy") newDifficulty /= 1.5;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", CardID);
                parameters.Add("@Difficulty", newDifficulty);

                connection.Execute("dbo.spCards_EditCardDifficulty", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
