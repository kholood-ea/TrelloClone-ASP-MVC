using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrelloClone.Models;

namespace TrelloClone.Controllers
{
    public class ToDoesAPIController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET api/values
        public IHttpActionResult Get()
        { 
            IEnumerable<ToDo> myToDoes = db.ToDos.ToList();
            int completedcount = 0;
            foreach (ToDo toDo in myToDoes)
            {
                if (toDo.IsDone)
                {
                    completedcount++;
                }
            }
            //var result = new { results = myToDoes } /*.Select(x => new { x.Id, x.IsDone, x.Description }).ToList()*/;
            return Ok(JsonConvert.SerializeObject(new { results = myToDoes }));
        }


        // GET api/values
        public IHttpActionResult GetByUser(string currentUserId)
        {
            ApplicationUser currentUser = db.Users.FirstOrDefault(
                x => x.Id == currentUserId);
            IEnumerable<ToDo> myToDoes = db.ToDos.ToList().Where(x => x.User == currentUser);
            int completedcount = 0;
            foreach (ToDo toDo in myToDoes)
            {
                if (toDo.IsDone)
                {
                    completedcount++;
                }
            }
            //var result = new { results = myToDoes } /*.Select(x => new { x.Id, x.IsDone, x.Description }).ToList()*/;
            return Ok(JsonConvert.SerializeObject(new { results = myToDoes }));
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Hello World";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
