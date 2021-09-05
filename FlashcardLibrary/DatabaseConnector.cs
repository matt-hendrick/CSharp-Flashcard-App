using Dapper;
using FlashcardLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace FlashcardLibrary
{
    public class DatabaseConnector : IDataConnector
    {
        private const string DB = "Flashcards";

        public static IDataConnector Connection { get; private set; }

        public static void InitializeConnections()
        {
            DatabaseConnector sql = new DatabaseConnector();
            Connection = sql;
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

        public void CreateCard(CardModel card)
        {
            throw new NotImplementedException();
        }

        public void CreateDeck(DeckModel deck)
        {
            throw new NotImplementedException();
        }

    }
}
