using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using DiscordBot.Models;
using Newtonsoft.Json;

namespace DiscordBot.Controllers.api
{
    public class OSRSTrackerController : ApiController
    {
        [HttpPost]
        public async Task<string> Request([FromUri]string cmd, [FromUri]string[] param, [FromUri]Int64 discordID)
        {
            var result = "";
            
            HttpClient client = new HttpClient();

            switch (cmd.ToLower()) {
                case "setrsn":



                    break;
                case "account":
                    result = new Account(discordID).Get(discordID).ToResponse();
                    break;
                case "stats":
                    var user = new User(param[0]);
                    
                    result = await client.GetStringAsync(@"https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=" + param[0]);

                    user.MapData(result);
                    
                    result = user.ToResponse();
                    break;
                default:
                    result = "Sorry, the command " + cmd + "was not recognised.";
                    break;
            }



            return result;
        }
    }
}
