<<<<<<< HEAD
﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

using Lib;

namespace Api.Handlers
{
    public class DatabaseHandler
    {
        string ConnectionString = "workstation id=nbaprediction.mssql.somee.com;packet size=4096;user id=teamsouth_SQLLogin_2;pwd=jg4pbomnhi;data source=nbaprediction.mssql.somee.com;persist security info=False;initial catalog=nbaprediction";

        public List<Player> GetAllPlayers()
        {
            List<Player> Players = new List<Player>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PLAYERS", sqlConnection);          

                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Player TempPlayer = new Player((int)sqlDataReader[0], sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), (double)sqlDataReader[3], (double)sqlDataReader[4]);
                        Players.Add(TempPlayer);
                    }
                }
            }

            return Players;
        }

        public Player GetPlayerByID(int playerId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PLAYERS WHERE PLAYER_ID = @PLAYER_ID", sqlConnection);
                sqlCommand.Parameters.Add("@PLAYER_ID", SqlDbType.Int);
                sqlCommand.Parameters["@PLAYER_ID"].Value = playerId;

                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        return new Player((int)sqlDataReader[0], sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), (double)sqlDataReader[3], (double)sqlDataReader[4]);
                    }
                }
            }

            return new Player(-1, "error", "error", -1, -1);
        }

        public void CreateTeam(string teamName, int playerId1, int playerId2, int playerId3, int playerId4, int playerId5)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TEAMS VALUES (@TEAM_NAME, @PLAYER_1, @PLAYER_2, @PLAYER_3, @PLAYER_4, @PLAYER_5", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TEAM_NAME", SqlDbType.NVarChar);
                sqlCommand.Parameters["@TEAM_NAME"].Value = teamName;

                sqlCommand.Parameters.AddWithValue("@PLAYER_1", SqlDbType.Int);
                sqlCommand.Parameters["@PLAYER_1"].Value = playerId1;

                sqlCommand.Parameters.AddWithValue("@PLAYER_2", SqlDbType.Int);
                sqlCommand.Parameters["@PLAYER_2"].Value = playerId2;

                sqlCommand.Parameters.AddWithValue("@PLAYER_3", SqlDbType.Int);
                sqlCommand.Parameters["@PLAYER_3"].Value = playerId3;

                sqlCommand.Parameters.AddWithValue("@PLAYER_4", SqlDbType.Int);
                sqlCommand.Parameters["@PLAYER_4"].Value = playerId4;

                sqlCommand.Parameters.AddWithValue("@PLAYER_5", SqlDbType.Int);
                sqlCommand.Parameters["@PLAYER_5"].Value = playerId5;

                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<Team> GetAllTeams()
        {
            List<Team> Teams = new List<Team>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TEAMS", sqlConnection);

                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Team TempTeam = new Team((int)sqlDataReader[0], sqlDataReader[1].ToString(), (int)sqlDataReader[2], (int)sqlDataReader[3], (int)sqlDataReader[4], (int)sqlDataReader[5], (int)sqlDataReader[6]);
                        Teams.Add(TempTeam);
                    }
                }
            }

            return Teams;
        }

        public User VeryifyUser(string UserName, string UserPassword)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USERS WHERE USER_NAME = @USER_NAME AND USER_PASSWORD = @USER_PASSWORD", sqlConnection);


                sqlCommand.Parameters.Add("@USER_NAME", SqlDbType.NVarChar);
                sqlCommand.Parameters["@USER_NAME"].Value = UserName;

                sqlCommand.Parameters.Add("@USER_PASSWORD", SqlDbType.NVarChar);
                sqlCommand.Parameters["@USER_PASSWORD"].Value = UserPassword;

                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        return new User((int)sqlDataReader[0], sqlDataReader[1].ToString());
                    }
                }
            }

            return new User(-1, "error");
        }
    }
}
=======
﻿using System;
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
>>>>>>> a73b2d35b0b7a5aa69eb1014a83c905405e05071
