using Microsoft.AspNetCore.Mvc;
using Api.Handlers;
using Newtonsoft.Json.Linq;

using Lib;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        DatabaseHandler Handler = new DatabaseHandler();

        [HttpPost]
        public User VerifyUser([FromBody] JObject JsonBody)
        {
            return Handler.VeryifyUser(JsonBody["userName"].Value<string>(), JsonBody["userPassword"].Value<string>());
        }
    }
}