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

namespace Sistema_de_Estoque.UI.Cadastros.UI.Funções
{
    public partial class frmBuscarFornecedor : Form
    {
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        public frmBuscarFornecedor()
        {
            InitializeComponent();
        }

        #region Cancelar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Botão Procurar
        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            string nome = txtBox_Nome.Text;

            var fornecedores = fornecedorDAL.BuscarFornecedor(nome);

            dgv_Resultado.Rows.Clear();
            dgv_Resultado.Columns.Clear();

            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Nenhum fornecedor encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgv_Resultado.Columns.Add("ID", "ID");
            dgv_Resultado.Columns.Add("Nome", "Nome");
            dgv_Resultado.Columns.Add("Contato", "Contato");
            dgv_Resultado.Columns.Add("Endereco", "Endereco");

            foreach (var fornecedor in fornecedores)
            {
                dgv_Resultado.Rows.Add(
                    fornecedor.ID,
                    fornecedor.Nome,
                    fornecedor.Contato,
                    fornecedor.Endereco);
            }

            tabControl_Fornecedor.SelectedTab = Page_Resultado;
        }
        #endregion

        #region Botão Confirmar
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (dgv_Resultado.SelectedRows.Count > 0)
            {
                Fornecedor fornecedorSelecionado = new Fornecedor()
                {
                    ID = Convert.ToInt32(dgv_Resultado.SelectedRows[0].Cells["ID"].Value),
                    Nome = dgv_Resultado.SelectedRows[0].Cells["Nome"].Value.ToString(),
                    Contato = dgv_Resultado.SelectedRows[0].Cells["Contato"].Value.ToString(),
                    Endereco = dgv_Resultado.SelectedRows[0].Cells["Endereco"].Value.ToString(),
                };

                frmFornecedores frmFornecedores = Application.OpenForms.OfType<frmFornecedores>().FirstOrDefault();
                if (frmFornecedores != null)
                {
                    frmFornecedores.SetFornecedorSelecionado(fornecedorSelecionado);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

    }
}
