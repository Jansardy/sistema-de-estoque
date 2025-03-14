using MySql.Data.MySqlClient;
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
using System.Runtime.InteropServices;

namespace Sistema_de_Estoque.UI.Cadastros.UI.Funções
{
    public partial class frmBuscarProduto : Form
    {
        private ProdutoDAL produtoDAL = new ProdutoDAL();

        public frmBuscarProduto()
        {
            InitializeComponent();
            Carregar_Categorias();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            string nome = txtBox_Nome.Text;
            string categoria = cbBox_Categoria.SelectedIndex.ToString() ?? string.Empty;

            var produtos = produtoDAL.BuscarProduto(nome, categoria);

            dgv_Resultado.Rows.Clear();
            dgv_Resultado.Columns.Clear();

            if (produtos.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgv_Resultado.Columns.Add("ID", "ID");
            dgv_Resultado.Columns.Add("Nome", "Nome");
            dgv_Resultado.Columns.Add("Categoria", "Categoria");
            dgv_Resultado.Columns.Add("Quantidade", "Quantidade");
            dgv_Resultado.Columns.Add("Preco", "Preço");
            dgv_Resultado.Columns.Add("FornecedorID", "FornecedorID");

            foreach (var produto in produtos)
            {
                dgv_Resultado.Rows.Add(
                    produto.ID, 
                    produto.Nome, 
                    produto.Categoria, 
                    produto.Quantidade, 
                    produto.Preco, 
                    produto.FornecedorID);
            }

            Tab_Produtos.SelectedTab = Page_Resultado;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_Resultado.SelectedRows.Count > 0)
            {
                Produto produtoSelecionado = new Produto 
                {
                    ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value),
                    Nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString(),
                    Categoria = dgv_Resultado.SelectedRows[0].Cells["Categoria"].Value.ToString(),
                    Quantidade = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["Quantidade"].Value),
                    Preco = Convert.ToDecimal(dgv_Resultado.SelectedRows[0].Cells["Preco"].Value),
                    FornecedorID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["FornecedorID"].Value),
                };

                frmProdutos frmProdutos = Application.OpenForms.OfType<frmProdutos>().FirstOrDefault();
                if (frmProdutos != null)
                {
                    frmProdutos.SetProdutoSelecionado(produtoSelecionado);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um produto da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        #region Metodos

        #region ComboBox Categoria
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
                MessageBox.Show("Erro ao carregar Categorias: " + ex.Message);
            }
        }

        #endregion

        #endregion
    }
}
