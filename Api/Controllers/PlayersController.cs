using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using Lib;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : Controller
    {
        [HttpGet]
        public List<Players> GetAllPlayers()
        {
            List<Players> Players = new List<Players>();

            using (SqlConnection sqlConnection = new SqlConnection(" workstation id=nbaprediction.mssql.somee.com;packet size=4096;user id=teamsouth_SQLLogin_2;pwd=jg4pbomnhi;data source=nbaprediction.mssql.somee.com;persist security info=False;initial catalog=nbaprediction"))
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
