using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proiect.Models
{
    public class Vacantion
    {
        public int ID { get; set; }
        public int IDClient { get; set; }
        public int Days { get; set; }
        public string Location { get; set; }
        public DateTime Schedule { get; set; }
        public int Disponibility { get; set; }
    }
}