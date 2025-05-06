using Sistema_de_Estoque.Entities;
using Sistema_de_Estoque.UI.Cadastros;
using Sistema_de_Estoque.UI.Estoque;
using Sistema_de_Estoque.UI.Movimentações;
using Sistema_de_Estoque.UI.Movimentações.Histórico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Estoque.UI
{
    public partial class frmMain : Form
    {
        private string usuario;

        public frmMain(string usuarioLogado, string nivelAcesso)
        {
            InitializeComponent();
            usuario = usuarioLogado;

            if (nivelAcesso == "Vendedor")
            {
                usuárioToolStripMenuItem.Enabled = false;
                fornecedorToolStripMenuItem.Enabled = false;
                atualizarBancoDeDadosToolStripMenuItem.Enabled = false;
                TesteToolStripMenuItem.Enabled = true;
                MovimentacaoProdutosToolStripMenuItem.Enabled = true;
            }
        }
     
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbl_User.Text = $"Usuário: {usuario}";
            lbl_data.Text = $"Data: {DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos frmProdutos = new frmProdutos();
            frmProdutos.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedores frmFornecedores = new frmFornecedores();
            frmFornecedores.ShowDialog();
        }

        private void MovimentacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmMovimentacao = new frmMovimentacao();
            frmMovimentacao.ShowDialog();
        }

        private void estoqueAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque();
            estoque.ShowDialog();
        }

        private void históricoDeMovimentaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistoricoMovimentacao his = new frmHistoricoMovimentacao();
            his.ShowDialog();
        }
    }
}
