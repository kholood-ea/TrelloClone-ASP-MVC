using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrelloClone.Models
{
    public class ToDoViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; }
    }
}