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

        public void CreateUser(UserModel user)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@Username", user.Username);
                parameters.Add("@Email", user.Email);
                parameters.Add("@Password", user.Password);
                parameters.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", parameters, commandType: CommandType.StoredProcedure);

                user.ID = parameters.Get<int>("@ID");
            }
        }

        public void CreateDeck(DeckModel deck, int UserID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@DeckName", deck.DeckName);
                parameters.Add("@UserID", UserID);
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

            return cardList;
        }

        public List<DeckModel> GetAll_Decks(int UserID)
        {
            List<DeckModel> deckList;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString(DB)))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@UserID", UserID);
                deckList = connection.Query<DeckModel>("dbo.spDecks_GetAll", parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return deckList;
        }
    }
}
