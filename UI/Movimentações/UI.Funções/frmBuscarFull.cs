using Sistema_de_Estoque.DAL;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Sistema_de_Estoque.UI.Movimentações.UI.Funções
{
    public partial class frmBuscarFull : Form
    {
        string tipo;
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        ProdutoDAL produtoDAL = new ProdutoDAL();
        UsuariosDAL usuariosDAL = new UsuariosDAL();

        public frmBuscarFull(string tipobusca)
        {
            InitializeComponent();
            tipo = tipobusca;
            if (tipo == "Produto")
            {
                CarregarCombo();
            }
        }

        private void frmBuscarFull_Load(object sender, EventArgs e)
        {
            if (tipo == "Fornecedor")
            {
                txtBox_Tipo.Text = "Fornecedor";
                lb_Name.Text = "Nome(Fornecedor)";
            }
            else if (tipo == "Produto")
            {
                lb_Name.Text = "Nome(Produto)";
                txtBox_Tipo.Text = "Produto";
                lb_Produto.Enabled = true;
                CB_Produtos.Enabled = true;
                lb_Produto.Visible = true;
                CB_Produtos.Visible = true;
            }
            else if (tipo == "Usuário")
            {
                txtBox_Tipo.Text = "Usuário";
                lb_Name.Text = "Nome(Usuário)";
            }
        }

        #region Métodos
        private void btn_can_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            if (tipo == "Fornecedor")
            {
                string nome = txtBox_Name.Text;

                var fornecedores = fornecedorDAL.BuscarFornecedor(nome);

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
            else if (tipo == "Produto")
            {
                string nome = txtBox_Name.Text;
                string categoria = CB_Produtos.SelectedIndex.ToString() ?? string.Empty;

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

                tabControl.SelectedTab = Page_Resultado;
            }
            else if (tipo == "Usuário")
            {
                string nome = txtBox_Name.Text;
                string login = "";

                var usuarios = usuariosDAL.BuscarUsuarios(nome, login);

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
                    dgv_Resultado.Rows.Add(usuario.ID, usuario.Nome, usuario.Login, usuario.NivelAcesso);
                }

                tabControl.SelectedTab = Page_Resultado;
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (tipo == "Fornecedor")
            {
                if (dgv_Resultado.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value);
                    string nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString();

                    frmMovimentacao frmMovimentacao = Application.OpenForms.OfType<frmMovimentacao>().FirstOrDefault();
                    if (frmMovimentacao != null)
                    {
                        frmMovimentacao.SetFornecedorSelecionado(ID, nome);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione um fornecedor da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (tipo == "Produto")
            {
                if (dgv_Resultado.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value);
                    string nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString();

                    frmMovimentacao frmMovimentacao = Application.OpenForms.OfType<frmMovimentacao>().FirstOrDefault();
                    if (frmMovimentacao != null)
                    {
                        frmMovimentacao.SetProdutoSelecionado(ID, nome);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione um produto da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (tipo == "Usuário")
            {
                if (dgv_Resultado.SelectedRows.Count > 0)
                {
                    int ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value);
                    string nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString();

                    frmMovimentacao frmMovimentacao = Application.OpenForms.OfType<frmMovimentacao>().FirstOrDefault();
                    if (frmMovimentacao != null)
                    {
                        frmMovimentacao.SetUsuarioSelecionado(ID, nome);
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione um usuário da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
