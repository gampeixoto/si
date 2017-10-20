using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MV5.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string email { get; set; }

        public Cliente() { }
    }
}