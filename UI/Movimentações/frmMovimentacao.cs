using Sistema_de_Estoque.Entities;
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


        private void Entrada_Saida(object sender, EventArgs e)
        {
            try
            {
                int movimento = CB_Movimentos.SelectedIndex;
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

                if (movimento == 0) //Entrada
                {
                    movimentacaoDAL.EntradaEstoque(estoque);
                    MessageBox.Show("Você registrou uma entrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (movimento == 1) //Saída
                {
                    movimentacaoDAL.SaidaEstoque(estoque, CB_Motivos.Text);
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
