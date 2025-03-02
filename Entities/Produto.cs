using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Estoque.Entities
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int FornecedorID { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
