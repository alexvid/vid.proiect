using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proiect.Models
{
    public class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int type { get; set; }
    }
}