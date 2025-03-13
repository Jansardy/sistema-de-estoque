using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Estoque.DAL;
using Sistema_de_Estoque.Entities;

namespace Sistema_de_Estoque.UI.Cadastros
{
    public partial class frmProdutos : Form
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
            CarregarCategoria();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            TabControl_Produto.Enabled = true;
            TabControl_Produto.SelectedTab = Page_Inserir;
            TabControl_Produto.TabPages[1].Enabled = false;
            TabControl_Produto.TabPages[0].Enabled = true;
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            TabControl_Produto.Enabled = true;
            TabControl_Produto.SelectedTab = Page_Procurar;
            TabControl_Produto.TabPages[0].Enabled = false;
            TabControl_Produto.TabPages[1].Enabled = true;
        }

        #region Métodos

        #region Preço TxtBox
        private void txtBox_Preco_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtBox_Preco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal preco))
            {
                txtBox_Preco.Text = preco.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                MessageBox.Show("Valor Inválido. Insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox_Preco.Focus();
            }
        }
        #endregion

        #region ComboBox FornecedorID
        private void CarregarFornecedores()
        {
            cbBox_Fornecedor.Items.Clear();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ProdutoDAL.strConnection))
                {
                    connection.Open();
                    string query = "SELECT ID, Nome FROM fornecedores";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Dictionary<int, string> fornecedores = new Dictionary<int, string>();

                            while (reader.Read())
                            {
                                fornecedores.Add(reader.GetInt32("ID"), reader.GetString("Nome"));
                            }

                            cbBox_Fornecedor.DataSource = new BindingSource(fornecedores, null);
                            cbBox_Fornecedor.DisplayMember = "Value";
                            cbBox_Fornecedor.ValueMember = "Key";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }
        #endregion

        #region ComboBox Categoria
        private void CarregarCategoria()
        {
            cbBox_Categoria.Items.Clear();
            try
            {
                cbBox_Categoria.Items.AddRange(new string[] { "Alimentos", "Bebidas", "Eletrônicos", "Vestuário", "Limpeza", "Móveis", "Papelaria" });
                cbBox_Categoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Categorias: " + ex.Message);
            }
        }
        #endregion

        #region Inserir Produto
        private void InserirAdd(object sender, EventArgs e)
        {
            txtBox_ID.Enabled = false;

            if (cbBox_Fornecedor.SelectedItem != null && cbBox_Categoria.SelectedIndex >= 0)
            {
                if (string.IsNullOrEmpty(txtBox_Nome.Text) ||
                    string.IsNullOrEmpty(txtBox_Quantidade.Text) ||
                    string.IsNullOrEmpty(txtBox_Preco.Text))
                {
                    MessageBox.Show("Um campo ou mais campos não foram preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    int fornecedorID = (int)cbBox_Fornecedor.SelectedValue;
                    decimal preco = decimal.Parse(txtBox_Preco.Text, CultureInfo.GetCultureInfo("pt-BR"));

                    Produto produto = new Produto
                    {
                        Nome = txtBox_Nome.Text,
                        Categoria = cbBox_Categoria.Text,
                        FornecedorID = fornecedorID,
                        Quantidade = Convert.ToInt32(txtBox_Quantidade.Text),
                        Preco = preco
                    };

                    produtoDAL.InserirProduto(produto);
                    MessageBox.Show("Produto inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBox_Nome.Clear();
                    txtBox_Quantidade.Clear();
                    txtBox_Preco.Clear();
                    cbBox_Categoria.SelectedIndex = -1;
                    cbBox_Fornecedor.SelectedIndex = -1;

                    TabControl_Produto.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir o produto. Por favor, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor e uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Procurar Produto
        private void Procurar()
        {

        }
        #endregion

        #endregion
    }
}
