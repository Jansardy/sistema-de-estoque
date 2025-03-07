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
using Sistema_de_Estoque.Entities;
using Sistema_de_Estoque.UI.Cadastros.UI.Funções;

namespace Sistema_de_Estoque.UI.Cadastros
{
    public partial class frmUsuarios : Form
    {
        UsuariosDAL userDal = new UsuariosDAL();
        public frmUsuarios()
        {
            InitializeComponent();
        }


        #region Incluir Form
        private void Inserir_Incluir(object sender, EventArgs e)
        {
            btn_Add.Enabled = true;
            btn_Can.Enabled = true;
            txtBox_Nome.Enabled = true;
            txtBox_Login.Enabled = true;
            txtBox_Senha.Enabled = true;
            cBox_Nivel.Enabled = true;

            txtBox_Nome.Clear();
            txtBox_Login.Clear();
            txtBox_Senha.Clear();
            cBox_Nivel.SelectedIndex = -1;

            btn_Inserir.Enabled = false;
        }

        private void Adicionar_Incluir(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_Login.Text) || string.IsNullOrEmpty(txtBox_Nome.Text) || string.IsNullOrEmpty(txtBox_Senha.Text) || string.IsNullOrEmpty(cBox_Nivel.Text))
            {
                MessageBox.Show("Um campo ou mais campos não foram preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Usuario user = new Usuario
                {
                    Nome = txtBox_Nome.Text,
                    Login = txtBox_Login.Text,
                    Senha = txtBox_Senha.Text,
                    NivelAcesso = cBox_Nivel.Text
                };

                userDal.InserirUsuario(user);
                MessageBox.Show("Usuário inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBox_Login.Clear();
                txtBox_Nome.Clear();
                txtBox_Senha.Clear();
                cBox_Nivel.SelectedIndex = -1;

                btn_Add.Enabled = false;
                btn_Can.Enabled = false;
                txtBox_Nome.Enabled = false;
                txtBox_Login.Enabled = false;
                txtBox_Senha.Enabled = false;
                cBox_Nivel.Enabled = false;

                btn_Inserir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário. Por favor, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Erro ao inserir usuário: " + ex.Message);
            }
        }

        private void Cancelar_Incluir(object sender, EventArgs e)
        {
            txtBox_Login.Clear();
            txtBox_Nome.Clear();
            txtBox_Senha.Clear();
            cBox_Nivel.SelectedIndex = -1;

            txtBox_Nome.Enabled = false;
            txtBox_Login.Enabled = false;
            txtBox_Senha.Enabled = false;
            cBox_Nivel.Enabled = false;

            btn_Add.Enabled = false;
            btn_Can.Enabled = false;

            btn_Inserir.Enabled = true;
        }
        #endregion

        #region Procurar From
        private void Procurar(object sender, EventArgs e)
        {
            frmBuscarUsuario buscar = new frmBuscarUsuario();
            buscar.ShowDialog();
        }
        #endregion
    }
}
