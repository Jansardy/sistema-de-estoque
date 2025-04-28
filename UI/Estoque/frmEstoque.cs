using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Estoque.UI.Estoque
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
            Carregar_Categorias();
        }



        #region Metodos
        private void Carregar_Categorias()
        {
            cbBox_Categoria.Items.Clear();
            try
            {
                cbBox_Categoria.Items.AddRange(new string[] { "Alimentos", "Bebidas", "Eletrônicos", "Vestuário", "Limpeza", "Móveis", "Papelaria" });
                cbBox_Categoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Categorias.\n\nDetalhes técnicos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

    }
}
