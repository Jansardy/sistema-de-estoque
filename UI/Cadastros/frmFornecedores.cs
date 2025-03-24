using Sistema_de_Estoque.DAL;
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

        #endregion

        #region Cancelar
        private void CanInserir(object sender, EventArgs e)
        {
            LimparCampo(txtBox_Nome, txtBox_Endereco, maskTxtBox_Telefone);
            Page_Inserir.Text = "";

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


    }
}
