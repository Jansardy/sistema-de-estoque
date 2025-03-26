using Sistema_de_Estoque.DAL;
using Sistema_de_Estoque.Entities;
using Sistema_de_Estoque.UI.Cadastros.UI.Funções;
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

namespace Sistema_de_Estoque.UI.Cadastros
{
    public partial class frmFornecedores : Form
    {
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        public frmFornecedores()
        {
            InitializeComponent();
        }


        #region Inserir
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            btn_AddProc.Enabled = false;
            TabControl_Fornecedores.Enabled = true;
            TabControl_Fornecedores.SelectedTab = Page_Inserir;
            Page_Inserir.Text = "Inserir";
            TabControl_Fornecedores.TabPages[1].Enabled = false;
            TabControl_Fornecedores.TabPages[0].Enabled = true;
            btn_AddInserir.Enabled = true;
        }

        private void btn_AddInserir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Nome.Text) ||
                string.IsNullOrEmpty(txtBox_Endereco.Text) ||
                string.IsNullOrEmpty(maskTxtBox_Telefone.Text))
            {
                MessageBox.Show("Um campo ou mais campos não foram preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (maskTxtBox_Telefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim().Length < 10)
            {
                MessageBox.Show("Número de telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Deseja realmente inserir este fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                Fornecedor fornecedor = new Fornecedor
                {
                    Nome = txtBox_Nome.Text,
                    Endereco = txtBox_Endereco.Text,
                    Contato = maskTxtBox_Telefone.Text
                };

                fornecedorDAL.InserirFornecedor(fornecedor);
                MessageBox.Show("O Fornecedor foi inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampo(txtBox_Nome, txtBox_Endereco, maskTxtBox_Telefone);
                Page_Inserir.Text = "";

                TabControl_Fornecedores.Enabled = false;
                btn_AddInserir.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir o fornecedor.\n\nDetalhes técnicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Procurar
        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            TabControl_Fornecedores.Enabled = true;
            TabControl_Fornecedores.SelectedTab = Page_Proc;
            Page_Proc.Text = "Procurar";
            TabControl_Fornecedores.TabPages[1].Enabled = true;
            TabControl_Fornecedores.TabPages[0].Enabled = false;
            frmBuscarFornecedor frmBuscarFornecedor = new frmBuscarFornecedor();
            frmBuscarFornecedor.ShowDialog();
        }

        public void SetFornecedorSelecionado(Fornecedor fornecedorSelecionado)
        {
            TabControl_Fornecedores.TabPages[1].Enabled = true;

            txtBox_pID.Text = fornecedorSelecionado.ID.ToString();
            txtBox_pNome.Text = fornecedorSelecionado.Nome;
            maskTxtBox_pTelefone.Text = fornecedorSelecionado.Contato.ToString();
            txtBox_pEndereco.Text = fornecedorSelecionado.Endereco;

            btn_Inserir.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Deletar.Enabled = true;
        }

        #endregion

        #region Cancelar
        private void CanInserir(object sender, EventArgs e)
        {
            LimparCampo(txtBox_Nome, txtBox_Endereco, maskTxtBox_Telefone);
            Page_Inserir.Text = "";

            TabControl_Fornecedores.Enabled = false;
        }
        private void btn_CanProc_Click(object sender, EventArgs e)
        {
            LimparCampo(txtBox_pID, txtBox_pNome, txtBox_pEndereco, maskTxtBox_pTelefone);

            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
            btn_Inserir.Enabled = true;
            Page_Proc.Text = "";
            TabControl_Fornecedores.Enabled = false;
        }
        #endregion

        #region Limpar Campo
        private void LimparCampo(params Control[] campos)
        {
            foreach (Control campo in campos)
            {
                if (campo is TextBox txt) txt.Clear();
                if (campo is MaskedTextBox mask) mask.Clear();
            }
        }


        #endregion

        #region Editar
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            txtBox_pID.Enabled = false;
            txtBox_pNome.Enabled = true;
            maskTxtBox_pTelefone.Enabled = true;
            txtBox_pEndereco.Enabled = true;
            Page_Proc.Text = "Editar";
        }

        private void btn_AddProc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_pID.Text)
                || string.IsNullOrEmpty(txtBox_pEndereco.Text)
                || string.IsNullOrEmpty(maskTxtBox_pTelefone.Text)
                || string.IsNullOrEmpty(txtBox_pNome.Text))
            {
                MessageBox.Show("Nenhuma caixa deve está vázia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Fornecedor fornecedor = new Fornecedor
                {
                    ID = Convert.ToInt32(txtBox_pID.Text),
                    Nome = txtBox_Nome.Text,
                    Endereco = txtBox_Endereco.Text,
                    Contato = maskTxtBox_Telefone.Text
                };
                fornecedorDAL.EditarFornecedor(fornecedor);
                MessageBox.Show("Fornecedor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampo(txtBox_pID, txtBox_pNome, txtBox_pEndereco, maskTxtBox_pTelefone);

                btn_Editar.Enabled = false;
                btn_Deletar.Enabled = false;
                btn_Inserir.Enabled = true;
                Page_Proc.Text = "";
                TabControl_Fornecedores.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar o fornecedor.\n\nDetalhes técnicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Deletar
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_pID.Text))
            {
                MessageBox.Show("Nenhum fornecedor selecionado para exclusão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?",
                                                       "Confirmação",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    int fornecedorID = Convert.ToInt32(txtBox_pID.Text);
                    fornecedorDAL.DeletarFornecedor(fornecedorID);

                    MessageBox.Show("Fornecedor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(txtBox_pID,txtBox_pNome, txtBox_pEndereco, maskTxtBox_pTelefone);

                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Inserir.Enabled = true;

                    TabControl_Fornecedores.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o fornecedor. \n\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

    }
}
