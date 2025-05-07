using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Estoque.DAL;

namespace Sistema_de_Estoque.UI.Movimentações.Histórico
{
    public partial class frmHistoricoMovimentacao : Form
    {
        public frmHistoricoMovimentacao()
        {
            InitializeComponent();
        }



        #region Metodos
        private void Carregar_estoque()
        {
            //var produtos = produtoDAL.Vw_BuscarProduto();
            //dgv_EstoquePro.DataSource = produtos;

        }
        #endregion
    }
}
