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

namespace Sistema_de_Estoque.UI.Cadastros.UI.Funções
{
    public partial class frmBuscarUsuario : Form
    {
        UsuariosDAL userDal = new UsuariosDAL();
        public frmBuscarUsuario()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            string nome = txtBox_Nome.Text;
            string login = txtBox_Login.Text;

            var usuarios = userDal.BuscarUsuarios(nome, login);

            dgv_Resultados.Columns.Clear();

            dgv_Resultados.Columns.Add("ID", "ID");
            dgv_Resultados.Columns.Add("Nome", "Nome");
            dgv_Resultados.Columns.Add("Login", "Login");
            dgv_Resultados.Columns.Add("NivelAcesso", "Nível de Acesso");

            dgv_Resultados.Columns["ID"].Width = 15;
            dgv_Resultados.Columns["Nome"].Width = 70;
            dgv_Resultados.Columns["Login"].Width = 50;
            dgv_Resultados.Columns["NivelAcesso"].Width = 100;

            foreach (var usuario in usuarios)
            {
                dgv_Resultados.Rows.Add(usuario.ID, usuario.Nome, usuario.Login,usuario.NivelAcesso);
            }

            tabControl.SelectedTab = Page_Resultado;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgv_Resultados.SelectedRows.Count > 0)
            {
                Usuario usuarioSelecionado = new Usuario
                {
                    ID = Convert.ToInt32(dgv_Resultados.SelectedRows[0].Cells["ID"].Value),
                    Nome = dgv_Resultados.SelectedRows[0].Cells["Nome"].Value.ToString(),
                    Login = dgv_Resultados.SelectedRows[0].Cells["Login"].Value.ToString(),
                    NivelAcesso = dgv_Resultados.SelectedRows[0].Cells["NivelAcesso"].Value.ToString()
                };

                frmUsuarios frmUsuarios = Application.OpenForms.OfType<frmUsuarios>().FirstOrDefault();
                if (frmUsuarios != null)
                {
                    frmUsuarios.SetUsuarioSelecionado(usuarioSelecionado);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um usuário da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
