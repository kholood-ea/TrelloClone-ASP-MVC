using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TrelloClone.Models;
using System.Web.Script.Serialization;

// so what do i do here ? close it for good ;) :( ok ......what?? it frrls like am giving up on my project 
//What....no you already did it and we are going to complete our target which is react?? ok:)
//ok...good...thumps up

namespace TrelloClone.Controllers
{
    public class ToDoAPIConsumerController : Controller
    {
        // GET: ToDoAPIConsumer
        public ActionResult Index()
        {
            IEnumerable<ToDo> todo = null;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri("https://localhost:44354");
                HttpResponseMessage response = client.GetAsync("api/ToDoesAPI").Result;
                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    var ss = JsonConvert.DeserializeObject<List<ToDoViewModel>>(res);//This line should work and I dont like to surrender ok :D
                    //so let's save your time and continue with the react course :))))) yalla OK
                    //ViewBag.result = ;
                // so....if we skip this point....do you get its idea? I think so 
                //it is getting the data from the API instead of databse!!? yea
                }
                else
                {
                    ViewBag.result = "Error";
                }

                //client.BaseAddress = new Uri("https://localhost:44354/api/");
                //var responseTask = client.GetAsync("ToDoesAPI");
                //  responseTask.Wait();
                // var result = responseTask.Result;
                //if (result.IsSuccessStatusCode)
                //{
                //    List<ToDo> tos = new List<ToDo>();
                //    JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

                //    var realjob = result.Content.ReadAsAsync<IList<ToDo>>();
                //   // string tododese = javaScriptSerializer.Deserialize();

                //    todo = realjob.Result;
                //   // List < ToDo > = JsonConvert.DeserializeObject<List<ToDo>>(result.Content.ReadAsync<string>());
                //    // ToDo tdo = JsonConvert.DeserializeObject<ToDo>(json);
                //    //   List < ToDo > = JsonConvert.DeserializeObject<List<ToDo>>(json);
                //    // var realjob = JsonConvert.DeserializeObject<List<ToDo>>(json)();
                //    //   List<ToDo> = JsonConvert.DeserializeObject<List<ToDo>>(result.Content);
                //    // result.Content.ReadAsync<string>();
                //}
                //else
                //{
                //    todo = Enumerable.Empty<ToDo>();
                //    ModelState.AddModelError(string.Empty, "Server Error occured.Please contact admin for Help");
                //}
            }
            return View();

            //return View(todo);
        }
    }
}