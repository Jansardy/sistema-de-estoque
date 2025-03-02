using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Estoque.Entities
{
    public class Fornecedor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }
    }
}
