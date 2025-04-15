using Sistema_de_Estoque.Entities;
using System;
using System.Windows.Forms;
using Sistema_de_Estoque.DAL;
using Sistema_de_Estoque.UI.Movimentações.UI.Funções;

namespace Sistema_de_Estoque.UI.Movimentações
{
    public partial class frmMovimentacao : Form
    {

        MovimentacaoDAL movimentacaoDAL = new MovimentacaoDAL();
        public frmMovimentacao()
        {
            InitializeComponent();

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você iniciou uma sessão de movimentação, primeiro selecione o tipo de movimentação(Entrada/Sáida)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            CB_Movimentos.Enabled = true;
            numUpDown_Quantidade.Enabled = true;
            monthCalendar1.Enabled = true;
            btn_BuscarFornecedor.Enabled = true;
            btn_BuscarProduto.Enabled = true;
            btn_BuscarUsuario.Enabled = true;
            CB_Movimentos.SelectedIndex = -1;
        }

        #region Metodos

        private void CB_Movimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Movimentos.SelectedIndex == 1)
            {
                CB_Motivos.Enabled = true;
            }
            else
            {
                CB_Motivos.Enabled = false;
            }
        }

        private void btn_BuscarFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscarFull frmBuscar = new frmBuscarFull("Fornecedor");
            frmBuscar.ShowDialog();
        }

        private void btn_BuscarProduto_Click(object sender, EventArgs e)
        {
            frmBuscarFull frmBuscar = new frmBuscarFull("Produto");
            frmBuscar.ShowDialog();
        }

        private void btn_BuscarUsuario_Click(object sender, EventArgs e)
        {
            frmBuscarFull frmBuscar = new frmBuscarFull("Usuário");
            frmBuscar.ShowDialog();
        }

        public void SetFornecedorSelecionado(int fornecedorSelecionado)
        {
            txtBox_Fornecedor.Text = Convert.ToString(fornecedorSelecionado);
        }

        public void SetUsuarioSelecionado(int usuarioSelecionado)
        {
            txtBox_Usuário.Text = Convert.ToString(usuarioSelecionado);
        }

        public void SetProdutoSelecionado(int produtoSeleciona)
        {
            txtBox_Produto.Text = Convert.ToString(produtoSeleciona);
        }

        private void Entrada_Saida(object sender, EventArgs e)
        {
            try
            {
                string motivoSelecionado = CB_Motivos.Text;
                string motivolimpo = motivoSelecionado.Substring(6);
                DateTime dataSelecionada = monthCalendar1.SelectionStart;

                if (string.IsNullOrWhiteSpace(txtBox_Produto.Text) ||
                    string.IsNullOrWhiteSpace(txtBox_Fornecedor.Text) ||
                    string.IsNullOrWhiteSpace(txtBox_Usuário.Text) ||
                    numUpDown_Quantidade.Value <= 0)
                {
                    MessageBox.Show("Preencha todos os campos antes de continuar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MovimentacaoEstoque estoque = new MovimentacaoEstoque
                {
                    ProdutoId = Convert.ToInt32(txtBox_Produto.Text),
                    Quantidade = Convert.ToInt32(numUpDown_Quantidade.Value),
                    Tipo = CB_Movimentos.Text,
                    DataMovimentacao = dataSelecionada,
                    UsuarioId = Convert.ToInt32(txtBox_Usuário.Text),
                    FornecedorId = Convert.ToInt32(txtBox_Fornecedor.Text)
                };

                if (CB_Movimentos.SelectedIndex == 0)
                {
                    movimentacaoDAL.EntradaEstoque(estoque);
                    MessageBox.Show("Você registrou uma entrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CB_Movimentos.SelectedIndex == 1)
                {
                    movimentacaoDAL.SaidaEstoque(estoque, motivolimpo);
                    MessageBox.Show("Você registrou uma saida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


    }
}
