using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MV5.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Descricao { get; set; }

        public Produtos() {  }
    }
}