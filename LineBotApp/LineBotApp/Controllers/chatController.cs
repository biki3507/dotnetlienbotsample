using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Http;
using System.Net.Http.Formatting;
using LineBotApp.Models;

namespace LineBotApp.Controllers
{
    public class chatController : ApiController
    {
        public async Task<HttpResponseMessage> Post()
        {
            var contentString = await Request.Content.ReadAsStringAsync();

            ReceivingMessagesResult.Rootobject contentObj = JsonConvert.DeserializeObject<ReceivingMessagesResult.Rootobject>(contentString);
            var result = contentObj.result[0];

            var client = new HttpClient();
            try
            {
                client.DefaultRequestHeaders
                  .Add("X-Line-ChannelID", WebConfigurationManager.AppSettings["ChannelID"]);
                client.DefaultRequestHeaders
                  .Add("X-Line-ChannelSecret", WebConfigurationManager.AppSettings["ChannelSecret"]);
                client.DefaultRequestHeaders
                  .Add("X-Line-Trusted-User-With-ACL", WebConfigurationManager.AppSettings["MID"]);

                var res = client.PostAsJsonAsync("https://trialbot-api.line.me/v1/events",
                    new {
                      to = new[] { result.content.from },
                      toChannel = "1383378250",
                      eventType = "138311608800106203",
                      content = new SendingMessagesText.Content
                      {
                          contentType=1,
                           toType=1,
                            text=result.content.text
                         
                      }
                    });

                //System.Diagnostics.Debug.WriteLine(await res.Content.ReadAsStringAsync());
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }


}
