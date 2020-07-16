using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TrelloClone.Models
{
    [DataContract]
    public class ToDo
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsDone { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}