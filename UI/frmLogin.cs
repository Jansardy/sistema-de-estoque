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

namespace Sistema_de_Estoque.UI
{
    public partial class frmLogin : Form
    {
        UsuariosDAL userdal = new UsuariosDAL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_User.Text) || string.IsNullOrEmpty(txtBox_Pass.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btn_Logar.Enabled = false;

            try
            {
                var (sucesso, nome, nivelAcesso) = userdal.ValidarLogin(txtBox_User.Text, txtBox_Pass.Text);

                if (sucesso)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmMain main = new frmMain(nome, nivelAcesso);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_Logar.Enabled = true;
            }
        }

    }
}
