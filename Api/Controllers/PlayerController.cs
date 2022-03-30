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
    public class PlayerController : Controller
    {
        [HttpGet]
        public List<Player> GetAllPlayers()
        {
            List<Player> Players = new List<Player>();

            using (SqlConnection sqlConnection = new SqlConnection("workstation id=nbaprediction.mssql.somee.com;packet size=4096;user id=teamsouth_SQLLogin_1;pwd=daouqkr2hp;data source=nbaprediction.mssql.somee.com;persist security info=False;initial catalog=nbaprediction"))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM PLAYERS", sqlConnection);

                sqlConnection.Open();
                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                {
                    while (sqlDataReader.Read())
                    {
                        Player TempPlayer = new Player((int)sqlDataReader[0], sqlDataReader[1].ToString(), sqlDataReader[2].ToString(), (float)sqlDataReader[3], (float)sqlDataReader[4]);
                        Players.Add(TempPlayer);
                    }
                }
            }

            return Players;
        }
    }
}
