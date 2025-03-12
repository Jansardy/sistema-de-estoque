using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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


        #region Metodos

        #region Preço TxtBox
        private void txtBox_Preco_Leave(object sender, EventArgs e)
        {
            string precoText = txtBox_Preco.Text;

            precoText = precoText.Replace("R$", "").Trim();
            precoText = precoText.Replace(",", ".");

            if (Decimal.TryParse(precoText, out decimal preco))
            {
                txtBox_Preco.Text = preco.ToString("C2");
            }
            else
            {
                MessageBox.Show("Valor Inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #region ComboBox Categori
        private void CarregarCategoria()
        {
            cbBox_Categoria.Items.Clear();
            try
            {
                cbBox_Categoria.Items.Add("Alimentos");
                cbBox_Categoria.Items.Add("Bebidas");
                cbBox_Categoria.Items.Add("Eletrônicos");
                cbBox_Categoria.Items.Add("Vestuário");
                cbBox_Categoria.Items.Add("Limpeza");
                cbBox_Categoria.Items.Add("Móveis");
                cbBox_Categoria.Items.Add("Papelaria");

                cbBox_Categoria.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Categorias: " + ex.Message);
            }
        }
        #endregion

        #region inserirAdd
        private void InserirAdd(object sender, EventArgs e)
        {

            if (cbBox_Fornecedor.SelectedItem != null && cbBox_Categoria.SelectedIndex != null)
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

                    Produto produto = new Produto
                    {
                        Nome = txtBox_Nome.Text,
                        Categoria = cbBox_Categoria.Text,
                        FornecedorID = fornecedorID,
                        Quantidade = Convert.ToInt32(txtBox_Quantidade.Text),
                        Preco = Convert.ToDecimal(txtBox_Preco.Text)
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


        #endregion
    }
}
