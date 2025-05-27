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
        int acao = 0;
        public frmUsuarios()
        {
            InitializeComponent();
        }


        #region Funções

        #region Inserir
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            acao = 1;
            btn_Buscar.Enabled = false;
            btn_Inserir.Enabled = false;
            btn_Ok.Enabled = true;
            btn_Can.Enabled = true;
            TxtBox_Login.Enabled = true;
            TxtBox_Nome.Enabled = true;
            TxtBox_Senha.Enabled = true;
            CB_NivelAcesso.Enabled = true;
        }
        #endregion

        #region Buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            frmBuscarCadastro buscar = new frmBuscarCadastro("Usuário");
            buscar.ShowDialog();
        }

        public void ResultadoUsuario(Usuario usuario)
        {
            TxtBox_ID.Text = Convert.ToString(usuario.ID);
            TxtBox_Nome.Text = usuario.Nome.ToString();
            TxtBox_Login.Text = usuario.Login.ToString();
            CB_NivelAcesso.Text = usuario.NivelAcesso.ToString();
            TxtBox_Senha.Text = "Desativado!";

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
            btn_Deletar.Enabled = false;
            btn_Editar.Enabled = false;
            TxtBox_Login.Enabled = true;
            TxtBox_Nome.Enabled = true;
            CB_NivelAcesso.Enabled = true;
            btn_Ok.Enabled = true;
            btn_Can.Enabled = true;
        }
        #endregion

        #region Deletar
        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBox_ID.Text))
            {
                MessageBox.Show("Selecione um usuário para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int idUsuario = Convert.ToInt32(TxtBox_ID.Text);
                    userDal.Deletar(idUsuario);
                    MessageBox.Show("Usuário deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Login, TxtBox_Nome, TxtBox_Senha, CB_NivelAcesso);

                    acao = 0;
                    btn_Editar.Enabled = false;
                    btn_Deletar.Enabled = false;
                    btn_Inserir.Enabled = true;
                    btn_Buscar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar usuário. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region btn_add(Inserir,Editar)
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBox_Login.Text) ||
                string.IsNullOrEmpty(TxtBox_Nome.Text) ||
                string.IsNullOrEmpty(TxtBox_Senha.Text) ||
                string.IsNullOrEmpty(CB_NivelAcesso.Text))
            {
                MessageBox.Show("Um campo ou mais campos não foram preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (acao == 1)
            {
                try
                {
                    Usuario usuario = new Usuario
                    {
                        Nome = TxtBox_Nome.Text,
                        Login = TxtBox_Login.Text,
                        Senha = TxtBox_Senha.Text,
                        NivelAcesso = CB_NivelAcesso.Text
                    };

                    userDal.InserirUsuario(usuario);
                    MessageBox.Show("Usuário inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_Login, TxtBox_Nome, TxtBox_Senha, CB_NivelAcesso);
                    acao = 0;
                    btn_Buscar.Enabled = true;
                    btn_Inserir.Enabled = true;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;
                    TxtBox_Login.Enabled = false;
                    TxtBox_Nome.Enabled = false;
                    TxtBox_Senha.Enabled = false;
                    CB_NivelAcesso.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir usuário. Por favor, tente novamente mais tarde." + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acao == 2)
            {
                try
                {
                    TxtBox_Senha.Clear();

                    Usuario usuario = new Usuario
                    {
                        ID = Convert.ToInt32(TxtBox_ID.Text),
                        Nome = TxtBox_Nome.Text,
                        Login = TxtBox_Login.Text,
                        NivelAcesso = CB_NivelAcesso.Text,
                        Senha = TxtBox_Senha.Text
                    };

                    userDal.EditarUsuario(usuario);
                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampo(TxtBox_ID, TxtBox_Login, TxtBox_Nome, TxtBox_Senha, CB_NivelAcesso);

                    acao = 0;
                    btn_Buscar.Enabled = true;
                    btn_Inserir.Enabled = true;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;
                    TxtBox_Login.Enabled = false;
                    TxtBox_Nome.Enabled = false;
                    TxtBox_Senha.Enabled = false;
                    CB_NivelAcesso.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar usuário. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region btn_can(Inserir,Buscar,Editar,Deletar)
        private void btn_Can_Click(object sender, EventArgs e)
        {
            switch (acao)
            {
                case 1:
                    MessageBox.Show("Você cancelou a função Inserir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LimparCampo(TxtBox_Login, TxtBox_Nome, TxtBox_Senha, CB_NivelAcesso);
                    acao = 0;
                    btn_Buscar.Enabled = true;
                    btn_Inserir.Enabled = true;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;
                    TxtBox_Login.Enabled = false;
                    TxtBox_Nome.Enabled = false;
                    TxtBox_Senha.Enabled = false;
                    CB_NivelAcesso.Enabled = false;
                    break;

                case 2:
                    MessageBox.Show("Você cancelou a função Editar/Deletar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    LimparCampo(TxtBox_Login, TxtBox_Nome, TxtBox_Senha, CB_NivelAcesso);
                    acao = 0;
                    btn_Buscar.Enabled = true;
                    btn_Inserir.Enabled = true;
                    btn_Ok.Enabled = false;
                    btn_Can.Enabled = false;
                    TxtBox_Login.Enabled = false;
                    TxtBox_Nome.Enabled = false;
                    TxtBox_Senha.Enabled = false;
                    CB_NivelAcesso.Enabled = false;
                    break;
            }
        }
        #endregion

        #endregion

        #region Métodos
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
                if (campo is ComboBox cb) cb.SelectedIndex = -1;
            }
        }

        #endregion


    }
}
