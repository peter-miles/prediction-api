using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Api.Handlers;
using Newtonsoft.Json.Linq;

using Lib;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        DatabaseHandler Handler = new DatabaseHandler();

        [HttpPost]
        public void CreateTeam([FromBody] JObject JsonBody)
        {
            Handler.CreateTeam(JsonBody["teamName"].Value<string>(), JsonBody["playerId1"].Value<int>(), JsonBody["playerId2"].Value<int>(), JsonBody["playerId3"].Value<int>(), JsonBody["playerId4"].Value<int>(), JsonBody["playerId5"].Value<int>());
        }

        [HttpGet]
        public List<Team> GetAllTeams()
        {
            return Handler.GetAllTeams();
        }
    }
}
