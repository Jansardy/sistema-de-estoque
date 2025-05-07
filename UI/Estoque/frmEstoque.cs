using Sistema_de_Estoque.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_Estoque.UI.Estoque
{
    public partial class frmEstoque : Form
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            Carregar_estoque();
            Carregar_Categorias();
        }

        #region Metodos
        private void Carregar_Categorias()
        {
            cbBox_Categoria.Items.Clear();
            try
            {
                cbBox_Categoria.Items.AddRange(new string[] { "Alimentos", "Bebidas", "Eletrônicos", "Vestuário", "Limpeza", "Móveis", "Papelaria" });
                cbBox_Categoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Categorias.\n\nDetalhes técnicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Carregar_estoque()
        {
            string nome = txtBox_Nome.Text;
            string categoria = cbBox_Categoria.Text;

            DataTable dt = produtoDAL.BuscarRelatorioProdutos(nome, categoria);
            dgv_EstoquePro.DataSource = dt;
        }

        private void cbBox_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carregar_estoque();
        }

        #endregion

        private void txtBox_Nome_TextChanged(object sender, EventArgs e)
        {
            Carregar_estoque();
        }
    }
}
