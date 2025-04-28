using Sistema_de_Estoque.Entities;
using System;
using System.Windows.Forms;
using Sistema_de_Estoque.DAL;
using Sistema_de_Estoque.UI.Movimentações.UI.Funções;

namespace Sistema_de_Estoque.UI.Movimentações
{
    public partial class frmMovimentacao : Form
    {
        int IDProd;
        int IDUser;
        int IDForn;


        MovimentacaoDAL movimentacaoDAL = new MovimentacaoDAL();
        public frmMovimentacao()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você iniciou uma sessão de movimentação, primeiro selecione o tipo de movimentação(Entrada/Sáida)", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            btn_Cancelar.Enabled = true;
            btn_Cancelar.Visible = true;
            btn_Confirmar.Enabled = true;
            btn_Confirmar.Visible = true;
            CB_Movimentos.Enabled = true;
            numUpDown_Quantidade.Enabled = true;
            monthCalendar1.Enabled = true;
            btn_BuscarFornecedor.Enabled = true;
            btn_BuscarProduto.Enabled = true;
            btn_BuscarUsuario.Enabled = true;
            btn_Novo.Enabled = false;
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

        private void LimparCampo(params Control[] campos)
        {
            foreach (Control campo in campos)
            {
                if (campo is TextBox txt) txt.Clear();
                if (campo is MaskedTextBox mask) mask.Clear();
                if (campo is ComboBox cb) cb.SelectedIndex = -1;
                if (campo is NumericUpDown numeric) numeric.Value = 0;
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

        public void SetFornecedorSelecionado(int IDFornecedor, string NomeFornecedor)
        {
            txtBox_Fornecedor.Text = NomeFornecedor;
            IDForn = IDFornecedor;
        }

        public void SetUsuarioSelecionado(int IDUsuario, string NomeUser)
        {
            txtBox_Usuário.Text = NomeUser;
            IDUser = IDUsuario;
        }

        public void SetProdutoSelecionado(int IDProduto, string NomeProduto)
        {
            txtBox_Produto.Text = NomeProduto;
            IDProd = IDProduto;
        }

        private void Entrada_Saida(object sender, EventArgs e)
        {
            try
            {

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
                    ProdutoId = Convert.ToInt32(IDProd),
                    Quantidade = Convert.ToInt32(numUpDown_Quantidade.Value),
                    Tipo = CB_Movimentos.Text,
                    UsuarioId = Convert.ToInt32(IDUser),
                    FornecedorId = Convert.ToInt32(IDForn)
                };

                if (CB_Movimentos.SelectedIndex == 0)
                {
                    movimentacaoDAL.EntradaEstoque(estoque);
                    MessageBox.Show("Você registrou uma entrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparCampo(txtBox_Produto, txtBox_Fornecedor, txtBox_Usuário, CB_Motivos, CB_Movimentos, numUpDown_Quantidade);
                    btn_Cancelar.Enabled = false;
                    btn_Cancelar.Visible = false;
                    btn_Confirmar.Enabled = false;
                    btn_Confirmar.Visible = false;
                    CB_Movimentos.Enabled = false;
                    numUpDown_Quantidade.Enabled = false;
                    monthCalendar1.Enabled = false;
                    btn_BuscarFornecedor.Enabled = false;
                    btn_BuscarProduto.Enabled = false;
                    btn_BuscarUsuario.Enabled = false;
                    btn_Novo.Enabled = true;
                    return;
                }
                else if (CB_Movimentos.SelectedIndex == 1)
                {
                    string motivolimpo = string.Empty;
                    string motivoSelecionado = CB_Motivos.Text;

                    if (!string.IsNullOrWhiteSpace(motivoSelecionado) && motivoSelecionado.Contains("-"))
                    {
                        string[] partes = motivoSelecionado.Split('-');

                        if (partes.Length >= 2)
                        {
                            motivolimpo = partes[1].Trim();
                        }
                        else
                        {
                            MessageBox.Show("Motivo inválido. Selecione um motivo válido da lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um motivo válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    movimentacaoDAL.SaidaEstoque(estoque, motivolimpo);
                    MessageBox.Show("Você registrou uma saída!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparCampo(txtBox_Produto, txtBox_Fornecedor, txtBox_Usuário, CB_Motivos, CB_Movimentos, numUpDown_Quantidade);
                    btn_Cancelar.Enabled = false;
                    btn_Cancelar.Visible = false;
                    btn_Confirmar.Enabled = false;
                    btn_Confirmar.Visible = false;
                    CB_Movimentos.Enabled = false;
                    numUpDown_Quantidade.Enabled = false;
                    monthCalendar1.Enabled = false;
                    btn_BuscarFornecedor.Enabled = false;
                    btn_BuscarProduto.Enabled = false;
                    btn_BuscarUsuario.Enabled = false;
                    btn_Novo.Enabled = true;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampo(txtBox_Produto, txtBox_Fornecedor, txtBox_Usuário, CB_Motivos, CB_Movimentos, numUpDown_Quantidade);
            btn_Cancelar.Enabled = false;
            btn_Cancelar.Visible = false;
            btn_Confirmar.Enabled = false;
            btn_Confirmar.Visible = false;
            CB_Movimentos.Enabled = false;
            numUpDown_Quantidade.Enabled = false;
            monthCalendar1.Enabled = false;
            btn_BuscarFornecedor.Enabled = false;
            btn_BuscarProduto.Enabled = false;
            btn_BuscarUsuario.Enabled = false;
            btn_Novo.Enabled = true;
        }
    }
}
