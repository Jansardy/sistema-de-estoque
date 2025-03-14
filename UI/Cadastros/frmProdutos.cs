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
using Sistema_de_Estoque.UI.Cadastros.UI.Funções;

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
            CarregarFornecedores(cbBox_Fornecedor);
            CarregarCategoria(cbBox_Categoria);
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            TabControl_Produto.Enabled = true;
            TabControl_Produto.SelectedTab = Page_Inserir;
            Page_Inserir.Text = "Inserir";
            TabControl_Produto.TabPages[1].Enabled = false;
            TabControl_Produto.TabPages[0].Enabled = true;
            btn_Procurar.Enabled = false;
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            TabControl_Produto.Enabled = true;
            TabControl_Produto.SelectedTab = Page_Procurar;
            TabControl_Produto.TabPages[0].Enabled = false;
            TabControl_Produto.TabPages[1].Enabled = true;
            frmBuscarProduto frmBuscarProduto = new frmBuscarProduto();
            frmBuscarProduto.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            txtBox_pNome.Enabled = true;
            cbBox_pCategoria.Enabled = true;
            cbBox_pFornecedor.Enabled = true;
            txtBox_pPreco.Enabled = true;
            txtBox_pQuantidade.Enabled = true;
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
        private void CarregarFornecedores(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
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

                            comboBox.DataSource = new BindingSource(fornecedores, null);
                            comboBox.DisplayMember = "Value";
                            comboBox.ValueMember = "Key";
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
        private void CarregarCategoria(ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
            try
            {
                comboBox.Items.AddRange(new string[] { "Alimentos", "Bebidas", "Eletrônicos", "Vestuário", "Limpeza", "Móveis", "Papelaria" });
                comboBox.SelectedIndex = -1;
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
                    MessageBox.Show("Erro ao inserir o produto. Por favor, tente novamente mais tarde." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor e uma categoria!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Procurar Produto
        public void SetProdutoSelecionado(Produto produtoSelecionado)
        {
            TabControl_Produto.TabPages[1].Enabled = true;

            CarregarFornecedores(cbBox_pFornecedor);
            CarregarCategoria(cbBox_pCategoria);

            txtBox_pID.Text = produtoSelecionado.ID.ToString();
            txtBox_pNome.Text = produtoSelecionado.Nome;
            txtBox_pQuantidade.Text = produtoSelecionado.Quantidade.ToString();
            txtBox_pPreco.Text = produtoSelecionado.Preco.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"));

            if (cbBox_pCategoria.Items.Contains(produtoSelecionado.Categoria))
            {
                cbBox_pCategoria.SelectedItem = produtoSelecionado.Categoria;
            }
            else
            {
                MessageBox.Show($"Categoria '{produtoSelecionado.Categoria}' não encontrada na lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cbBox_pFornecedor.Items.Cast<KeyValuePair<int, string>>().Any(f => f.Key == produtoSelecionado.FornecedorID))
            {
                cbBox_pFornecedor.SelectedValue = produtoSelecionado.FornecedorID;
            }
            else
            {
                MessageBox.Show($"Fornecedor ID '{produtoSelecionado.FornecedorID}' não encontrado na lista!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btn_Inserir.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Deletar.Enabled = true;


        }
        #endregion

        #region Editar Produto
        private void btn_EditaAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Cancelar
        private void btn_Can_Click(object sender, EventArgs e)
        {
            txtBox_ID.Clear();
            txtBox_Nome.Clear();
            cbBox_Categoria.SelectedIndex = -1;
            cbBox_Fornecedor.SelectedIndex = -1;
            txtBox_Preco.Clear();
            txtBox_Quantidade.Clear();

            TabControl_Produto.TabPages[0].Enabled = false;
            btn_Procurar.Enabled = true;
        }

        private void btn_can2_Click(object sender, EventArgs e)
        {
            txtBox_pNome.Clear();
            cbBox_pCategoria.SelectedIndex = -1;
            cbBox_pFornecedor.SelectedIndex = -1;
            txtBox_pPreco.Clear();
            txtBox_pQuantidade.Clear();

            TabControl_Produto.TabPages[1].Enabled = false;
            btn_Inserir.Enabled = true;
            btn_Procurar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
        }

        #endregion

        #endregion
    }
}
