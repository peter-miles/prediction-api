using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using Lib;

namespace Api.Handlers
{
    public class DatabaseHandler
    {
        string ConnectionString = "workstation id=nbaprediction.mssql.somee.com;packet size=4096;user id=teamsouth_SQLLogin_2;pwd=jg4pbomnhi;data source=nbaprediction.mssql.somee.com;persist security info=False;initial catalog=nbaprediction";

        public List<Players> GetAllPlayers()
        {
            List<Players> Players = new List<Players>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PLAYERS", sqlConnection);

                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Players TempPlayer = new Players((int)sqlDataReader[0], sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), (double)sqlDataReader[3], (double)sqlDataReader[4]);
                        Players.Add(TempPlayer);
                    }
                }
            }

            return Players;
        }
    }
}
