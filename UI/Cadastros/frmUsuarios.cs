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
            btn_Add.Visible = true;
            btn_Can.Visible = true;
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
                btn_Add.Visible = false;
                btn_Can.Visible = false;
                txtBox_Nome.Enabled = false;
                txtBox_Login.Enabled = false;
                txtBox_Senha.Enabled = false;
                cBox_Nivel.Enabled = false;

                btn_Inserir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário. Por favor, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void SetUsuarioSelecionado(Usuario usuario)
        {
            txtBox_ID.Text = Convert.ToString(usuario.ID);
            txtBox_Nome.Text = usuario.Nome;
            txtBox_Login.Text = usuario.Login;
            cBox_Nivel.Text = usuario.NivelAcesso;

            txtBox_Nome.Enabled = true;
            txtBox_Login.Enabled = true;
            cBox_Nivel.Enabled = true;
            txtBox_Senha.Enabled = true;

            btn_Inserir.Enabled = false;
            btn_Editar.Enabled = true;
            btn_Procurar.Enabled = true;
            btn_Deletar.Enabled = true;
        }
        #endregion

        #region Função Editar
        private void Editar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_ID.Text))
            {
                MessageBox.Show("Selecione um usuário para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Usuario usuario = new Usuario
                {
                    ID = Convert.ToInt32(txtBox_ID.Text),
                    Nome = txtBox_Nome.Text,
                    Login = txtBox_Login.Text,
                    NivelAcesso = cBox_Nivel.Text,
                    Senha = txtBox_Senha.Text
                };

                userDal.EditarUsuario(usuario);
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtBox_Login.Clear();
                txtBox_Nome.Clear();
                txtBox_Senha.Clear();
                cBox_Nivel.SelectedIndex = -1;

                txtBox_Nome.Enabled = false;
                txtBox_Login.Enabled = false;
                txtBox_Senha.Enabled = false;
                cBox_Nivel.Enabled = false;

                btn_Deletar.Enabled = false;
                btn_Editar.Enabled = false;
                btn_Inserir.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar usuário. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Função Deletar
        private void Deletar(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_ID.Text))
            {
                MessageBox.Show("Selecione um usuário para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int idUsuario = Convert.ToInt32(txtBox_ID.Text);
                    userDal.Deletar(idUsuario);
                    MessageBox.Show("Usuário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBox_ID.Clear();
                    txtBox_Nome.Clear();
                    txtBox_Login.Clear();
                    txtBox_Senha.Clear();
                    cBox_Nivel.SelectedIndex = -1;

                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Inserir.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar usuário. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

    }
}
