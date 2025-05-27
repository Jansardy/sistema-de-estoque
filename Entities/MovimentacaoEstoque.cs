using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Estoque.Entities
{
    public class MovimentacaoEstoque
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public int UsuarioId { get; set; }
        public int FornecedorId { get; set; }
    }
}
