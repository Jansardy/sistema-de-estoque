using Sistema_de_Estoque.DAL;
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
using Sistema_de_Estoque.Entities;

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
            var produtos = produtoDAL.Vw_BuscarProduto();
            dgv_EstoquePro.DataSource = produtos;
            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string name = txtBox_Nome.Text ?? string.Empty;
            string categoria = cbBox_Categoria.Text ?? string.Empty;

            var produtosfiltro = produtoDAL.BuscarProduto(name, categoria);


            if (produtosfiltro.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgv_EstoquePro.DataSource = produtosfiltro;
        }

        #endregion


    }
}
