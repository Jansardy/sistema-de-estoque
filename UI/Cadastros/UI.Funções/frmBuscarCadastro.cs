using Sistema_de_Estoque.DAL;
using Sistema_de_Estoque.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_Estoque.UI.Cadastros.UI.Funções
{
    public partial class frmBuscarCadastro : Form
    {
        string tipo;
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        ProdutoDAL produtoDAL = new ProdutoDAL();
        UsuariosDAL usuariosDAL = new UsuariosDAL();

        public frmBuscarCadastro(string tipobusca)
        {
            InitializeComponent();
            tipo = tipobusca;
            if (tipo == "Produtos")
            {
                CarregarCombo();
            }
        }

        private void frmBuscarCadastro_Load(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "Usuário":
                    txtBox_Tipo.Text = "Usuário";
                    lb_Name.Text = "Nome(Usuário)";
                    break;

                case "Produtos":
                    lb_Name.Text = "Nome(Produto)";
                    txtBox_Tipo.Text = "Produto";
                    lb_Produto.Enabled = true;
                    CB_Produtos.Enabled = true;
                    lb_Produto.Visible = true;
                    CB_Produtos.Visible = true;
                    break;

                case "Fornecedor":
                    txtBox_Tipo.Text = "Fornecedor";
                    lb_Name.Text = "Nome(Fornecedor)";
                    break;
            }

        }

        #region Métodos

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            if (tipo == "Usuário")
            {
                string nome = txtBox_Name.Text;
                string login = "";

                var usuarios = usuariosDAL.BuscarUsuarios(nome, login);

                dgv_Resultado.Columns.Clear();
                dgv_Resultado.Columns.Clear();

                dgv_Resultado.Columns.Add("ID", "ID");
                dgv_Resultado.Columns.Add("Nome", "Nome");
                dgv_Resultado.Columns.Add("Login", "Login");
                dgv_Resultado.Columns.Add("NivelAcesso", "Nível de Acesso");

                dgv_Resultado.Columns["ID"].Width = 15;
                dgv_Resultado.Columns["Nome"].Width = 70;
                dgv_Resultado.Columns["Login"].Width = 50;
                dgv_Resultado.Columns["NivelAcesso"].Width = 100;

                foreach (var usuario in usuarios)
                {
                    dgv_Resultado.Rows.Add(
                        usuario.ID,
                        usuario.Nome,
                        usuario.Login,
                        usuario.NivelAcesso);
                }

                tabControl.SelectedTab = Page_Resultado;
            }

            else if (tipo == "Produtos")
            {
                string nomeProduto = txtBox_Name.Text;
                string categoria = CB_Produtos.SelectedIndex.ToString() ?? string.Empty;

                var produtos = produtoDAL.BuscarProduto(nomeProduto, categoria);

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

                tabControl.SelectedTab = Page_Resultado;

            }

            else if (tipo == "Fornecedor")
            {
                string nomeFornecedor = txtBox_Name.Text;

                var fornecedores = fornecedorDAL.BuscarFornecedor(nomeFornecedor);

                dgv_Resultado.Rows.Clear();
                dgv_Resultado.Columns.Clear();

                if (fornecedores.Count == 0)
                {
                    MessageBox.Show("Nenhum fornecedor encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgv_Resultado.Columns.Add("ID", "ID");
                dgv_Resultado.Columns.Add("Nome", "Nome");
                dgv_Resultado.Columns.Add("Contato", "Contato");
                dgv_Resultado.Columns.Add("Endereco", "Endereco");

                foreach (var fornecedor in fornecedores)
                {
                    dgv_Resultado.Rows.Add(
                        fornecedor.ID,
                        fornecedor.Nome,
                        fornecedor.Contato,
                        fornecedor.Endereco);
                }

                tabControl.SelectedTab = Page_Resultado;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "Usuário":
                    if (dgv_Resultado.SelectedRows.Count > 0)
                    {
                        Usuario usuarioSelecionado = new Usuario
                        {
                            ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value),
                            Nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString(),
                            Login = dgv_Resultado.SelectedRows[0].Cells["Login"].Value.ToString(),
                            NivelAcesso = dgv_Resultado.SelectedRows[0].Cells["NivelAcesso"].Value.ToString()
                        };

                        frmUsuarios frmUsuarios = Application.OpenForms.OfType<frmUsuarios>().FirstOrDefault();
                        if (frmUsuarios != null)
                        {
                            frmUsuarios.ResultadoUsuario(usuarioSelecionado);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um usuário da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case "Produtos":
                    if (dgv_Resultado.SelectedRows.Count > 0)
                    {
                        Produto produtoSelecionado = new Produto
                        {
                            ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value),
                            Nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString(),
                            Categoria = dgv_Resultado.SelectedRows[0].Cells["Categoria"].Value.ToString(),
                            Quantidade = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["Quantidade"].Value),
                            Preco = Convert.ToDecimal(dgv_Resultado.SelectedRows[0].Cells["Preco"].Value),
                            FornecedorID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["FornecedorID"].Value)
                        };

                        frmProdutos frmProdutos = Application.OpenForms.OfType<frmProdutos>().FirstOrDefault();
                        if (frmProdutos != null)
                        {
                            frmProdutos.ResultadoProdutos(produtoSelecionado);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um produto da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;

                case "Fornecedor":
                    if (dgv_Resultado.SelectedRows.Count > 0)
                    {
                        Fornecedor fornecedorSelecionado = new Fornecedor
                        {
                            ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value),
                            Nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString(),
                            Contato = dgv_Resultado.SelectedRows[0].Cells["Contato"].Value.ToString(),
                            Endereco = dgv_Resultado.SelectedRows[0].Cells["Endereco"].Value.ToString()
                        };

                        frmFornecedores frmFornecedores = Application.OpenForms.OfType<frmFornecedores>().FirstOrDefault();
                        if (frmFornecedores != null)
                        {
                            frmFornecedores.ResultadoFornecedor(fornecedorSelecionado);
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Selecione um fornecedor da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }

        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarCombo()
        {
            CB_Produtos.Items.Clear();
            try
            {
                CB_Produtos.Items.AddRange(new string[] { "Alimentos", "Bebidas", "Eletrônicos", "Vestuário", "Limpeza", "Móveis", "Papelaria" });
                CB_Produtos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Categorias.\n\nDetalhes técnicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
