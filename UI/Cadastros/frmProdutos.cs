using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Sistema_de_Estoque.DAL;
using Sistema_de_Estoque.Entities;
using Sistema_de_Estoque.UI.Cadastros.UI.Funções;

namespace Sistema_de_Estoque.UI.Cadastros
{
    public partial class frmProdutos : Form
    {
        ProdutoDAL produtoDAL = new ProdutoDAL();
        int acao;
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregarFornecedores(CB_Fornecedor);
            CarregarCategoria(CB_Categoria);
        }

        #region Funções

        #region Inserir
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            acao = 1;

            btn_Inserir.Enabled = false;
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
            btn_Ok.Enabled = true;
            btn_Can.Enabled = true;

            TxtBox_Nome.Enabled = true;
            TxtBox_Preco.Enabled = true;
            NumUp_Quantidade.Enabled = true;
            CB_Categoria.Enabled = true;
            CB_Fornecedor.Enabled = true;
        }
        #endregion

        #region Buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            frmBuscarCadastro cadastro = new frmBuscarCadastro("Produtos");
            cadastro.ShowDialog();
        }
        public void ResultadoProdutos(Produto produto)
        {
            TxtBox_ID.Text = produto.ID.ToString();
            TxtBox_Nome.Text = produto.Nome;
            TxtBox_Preco.Text = produto.Preco.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"));
            CB_Categoria.Text = produto.Categoria;
            CB_Fornecedor.SelectedValue = produto.FornecedorID;
            NumUp_Quantidade.Value = produto.Quantidade;

            btn_Inserir.Enabled = false;
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Deletar.Enabled = true;
        }
        #endregion

        #region Editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            acao = 2;

            btn_Inserir.Enabled = false;
            btn_Buscar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
            btn_Ok.Enabled = true;
            btn_Can.Enabled = true;

            TxtBox_Nome.Enabled = true;
            TxtBox_Preco.Enabled = true;
            NumUp_Quantidade.Enabled = true;
            CB_Categoria.Enabled = true;
            CB_Fornecedor.Enabled = true;
        }
        #endregion

        #region Deletar
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBox_ID.Text))
            {
                MessageBox.Show("Selecione um produto para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int idProduto = Convert.ToInt32(TxtBox_ID.Text);
                    produtoDAL.DeletarProduto(idProduto);
                    MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Preco, CB_Categoria, CB_Fornecedor, NumUp_Quantidade);

                    acao = 0;

                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;

                    TxtBox_Nome.Enabled = false;
                    TxtBox_Preco.Enabled = false;
                    NumUp_Quantidade.Enabled = false;
                    CB_Categoria.Enabled = false;
                    CB_Fornecedor.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o produto. \n\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region btn_add
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBox_Nome.Text) ||
                string.IsNullOrEmpty(TxtBox_Preco.Text) ||
                int.Equals(0, NumUp_Quantidade.Value) ||
                string.IsNullOrEmpty(CB_Categoria.Text) ||
                string.IsNullOrEmpty(CB_Fornecedor.Text)
                )
            {
                MessageBox.Show("Um campo ou mais campos não foram preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (acao == 1)
            {
                try
                {
                    int fornecedorID = (int)CB_Fornecedor.SelectedValue;
                    if (!decimal.TryParse(TxtBox_Preco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal preco))
                    {
                        MessageBox.Show("Preço inválido. Insira um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Produto produtos = new Produto
                    {
                        Nome = TxtBox_Nome.Text,
                        Categoria = CB_Categoria.Text,
                        Quantidade = Convert.ToInt32(NumUp_Quantidade.Value),
                        Preco = preco,
                        FornecedorID = fornecedorID
                    };

                    produtoDAL.InserirProduto(produtos);
                    MessageBox.Show($"O produto {TxtBox_Nome.Text} foi inserido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Preco, CB_Categoria, CB_Fornecedor, NumUp_Quantidade);

                    acao = 0;

                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;

                    TxtBox_Nome.Enabled = false;
                    TxtBox_Preco.Enabled = false;
                    NumUp_Quantidade.Enabled = false;
                    CB_Categoria.Enabled = false;
                    CB_Fornecedor.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir o Produto!: " + ex, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acao == 2)
            {
                try
                {
                    int fornecedorID = (int)CB_Fornecedor.SelectedValue;
                    if (!decimal.TryParse(TxtBox_Preco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal preco))
                    {
                        MessageBox.Show("Preço inválido. Insira um valor numérico.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Produto produtos = new Produto
                    {
                        ID = Convert.ToInt32(TxtBox_ID.Text),
                        Nome = TxtBox_Nome.Text,
                        Categoria = CB_Categoria.Text,
                        Preco = preco,
                        Quantidade = Convert.ToInt32(NumUp_Quantidade.Value),
                        FornecedorID = fornecedorID
                    };

                    produtoDAL.EditarProduto(produtos);
                    MessageBox.Show($"Você alterou o {TxtBox_Nome.Text}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Preco, CB_Categoria, CB_Fornecedor, NumUp_Quantidade);

                    acao = 0;

                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;

                    TxtBox_Nome.Enabled = false;
                    TxtBox_Preco.Enabled = false;
                    NumUp_Quantidade.Enabled = false;
                    CB_Categoria.Enabled = false;
                    CB_Fornecedor.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar o Produto!: " + ex, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

        #endregion

        #region Métodos


        private void txtBox_Preco_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(TxtBox_Preco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal preco))
            {
                TxtBox_Preco.Text = preco.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                MessageBox.Show("Valor Inválido. Insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtBox_Preco.Focus();
            }
        }

        private void CarregarFornecedores(ComboBox comboBox)
        {
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
            comboBox.SelectedIndex = -1;
        }

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

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null)
            {
                btn.BackColor = SystemColors.MenuBar;
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn != null)
            {
                btn.BackColor = SystemColors.ScrollBar;
            }
        }

        private void LimparCampo(params Control[] campos)
        {
            foreach (Control campo in campos)
            {
                if (campo is TextBox txt) txt.Clear();
                if (campo is ComboBox cb) cb.SelectedIndex = -1;
                if (campo is NumericUpDown upDown) upDown.Value = 1;
            }
        }

        #endregion

        #region Cancelar
        private void btn_Can_Click(object sender, EventArgs e)
        {

            LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Preco, CB_Categoria, CB_Fornecedor, NumUp_Quantidade);

            acao = 0;

            btn_Inserir.Enabled = true;
            btn_Buscar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
            btn_Ok.Enabled = false;
            btn_Can.Enabled = false;

            TxtBox_Nome.Enabled = false;
            TxtBox_Preco.Enabled = false;
            NumUp_Quantidade.Enabled = false;
            CB_Categoria.Enabled = false;
            CB_Fornecedor.Enabled = false;
        }

        #endregion

    }
}
