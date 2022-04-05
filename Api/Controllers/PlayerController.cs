using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Api.Handlers;

using Lib;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        DatabaseHandler Handler = new DatabaseHandler();

        [HttpGet]
        public List<Player> GetAllPlayers()
        {
            return Handler.GetAllPlayers();
        }
    }
}
