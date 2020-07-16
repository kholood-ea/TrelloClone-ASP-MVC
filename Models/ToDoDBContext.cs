using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrelloClone.Models
{
    public class ToDoDBContext:DbContext
    {
       public DbSet<ToDo> todo { get; set; }
    }
}