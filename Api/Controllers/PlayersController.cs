using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Lib;
using Api.Handlers;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        DatabaseHandler Handler = new DatabaseHandler();

        [HttpGet]
        public List<Players> GetAllPlayers()
        {
            return Handler.GetAllPlayers();
        }
    }
}
