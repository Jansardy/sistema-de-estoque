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

            foreach (var usuario in usuarios)
            {
                dgv_Resultados.Rows.Add(usuario.ID, usuario.Nome, usuario.Login, usuario.NivelAcesso);
            }

            tabControl.SelectedTab = Page_Resultado;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou algum item no DataGridView
            if (dgv_Resultados.SelectedRows.Count > 0)
            {
                var usuarioSelecionado = dgv_Resultados.SelectedRows[0].DataBoundItem as Usuario;

                // Passa os dados do usuário selecionado para os campos no frmUsuarios
                frmUsuarios frmUsuario = Application.OpenForms.OfType<frmUsuarios>().FirstOrDefault();
                if (frmUsuario != null)
                {
                    //frmUsuario.SetUsuarioSelecionado(usuarioSelecionado);
                }

                this.Close(); // Fecha o formulário de busca
            }
            else
            {
                MessageBox.Show("Selecione um usuário da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
