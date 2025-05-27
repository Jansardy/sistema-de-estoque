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
        int acao;
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        public frmFornecedores()
        {
            InitializeComponent();
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
            TxtBox_Endereco.Enabled = true;
            maskTxtBox_Contato.Enabled = true;

        }
        #endregion

        #region Buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            frmBuscarCadastro cadastro = new frmBuscarCadastro("Fornecedor");
            cadastro.ShowDialog();
        }
        public void ResultadoFornecedor(Fornecedor fornecedor)
        {
            TxtBox_ID.Text = fornecedor.ID.ToString();
            TxtBox_Nome.Text = fornecedor.Nome;
            TxtBox_Endereco.Text = fornecedor.Endereco;
            maskTxtBox_Contato.Text = fornecedor.Contato;

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
            TxtBox_Endereco.Enabled = true;
            maskTxtBox_Contato.Enabled = true;
        }
        #endregion

        #region Deletar
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBox_ID.Text))
            {
                MessageBox.Show("Selecione um fornecedor para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int idUsuario = Convert.ToInt32(TxtBox_ID.Text);
                    fornecedorDAL.DeletarFornecedor(idUsuario);
                    MessageBox.Show("Fornecedor deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Endereco, maskTxtBox_Contato);

                    acao = 0;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar fornecedor. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region btn_Ok
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBox_Nome.Text)||
                string.IsNullOrEmpty(TxtBox_Endereco.Text)||
                string.IsNullOrEmpty(maskTxtBox_Contato.Text)
                )
            {
                MessageBox.Show("O campo está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(acao == 1)
            {
                try
                {
                    Fornecedor fornecedor = new Fornecedor
                    {
                        Nome = TxtBox_Nome.Text,
                        Endereco = TxtBox_Endereco.Text,
                        Contato = maskTxtBox_Contato.Text
                    };

                    fornecedorDAL.InserirFornecedor(fornecedor);
                    MessageBox.Show($"Você inseriu o fornecedor {fornecedor.Nome}!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Endereco, maskTxtBox_Contato);

                    acao = 0;

                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;

                    TxtBox_Nome.Enabled = false;
                    TxtBox_Endereco.Enabled = false;
                    maskTxtBox_Contato.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao Inserir o {TxtBox_Nome.Text}" + ex, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(acao == 2)
            {
                try
                {
                    Fornecedor fornecedor = new Fornecedor
                    {
                        ID = Convert.ToInt32(TxtBox_ID.Text),
                        Nome = TxtBox_Nome.Text,
                        Endereco = TxtBox_Endereco.Text,
                        Contato = maskTxtBox_Contato.Text
                    };

                    fornecedorDAL.EditarFornecedor(fornecedor);
                    MessageBox.Show($"Você alterou o fornecedor {fornecedor.Nome}!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Endereco, maskTxtBox_Contato);

                    acao = 0;

                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;

                    TxtBox_Nome.Enabled = false;
                    TxtBox_Endereco.Enabled = false;
                    maskTxtBox_Contato.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao Editar o {TxtBox_Nome.Text}" + ex, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region btn_Cancelar
        private void btn_Can_Click(object sender, EventArgs e)
        {
            LimparCampo(TxtBox_ID, TxtBox_Nome, TxtBox_Endereco, maskTxtBox_Contato);

            acao = 0;

            btn_Inserir.Enabled = true;
            btn_Buscar.Enabled = true;
            btn_Editar.Enabled = false;
            btn_Deletar.Enabled = false;
            btn_Ok.Enabled = false;
            btn_Can.Enabled = false;

            TxtBox_Nome.Enabled = false;
            TxtBox_Endereco.Enabled = false;
            maskTxtBox_Contato.Enabled = false;
        }
        #endregion


        #endregion

        #region Metodos

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
                if (campo is MaskedTextBox mask) mask.Clear();
            }
        }

        #endregion

    }
}
