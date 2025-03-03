using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Estoque
{
    public partial class Start : Form
    {
        private int progress = 0;

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            initializeProgressBar();
            timer1.Interval = 25;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress < pgBar_Car.Maximum)
            {
                progress++;
                pgBar_Car.Value = progress;
                carregarImg();
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Application.Exit();
            }
        }

        private void initializeProgressBar()
        {
            pgBar_Car.Minimum = 0;
            pgBar_Car.Maximum = 100;
            pgBar_Car.Step = 1;
            pgBar_Car.Value = 0;
        }

        private void carregarImg()
        {
            switch (progress)
            {
                case 25:
                    lbl_CarText.Visible = true;
                    lbl_CarText.Text = "Seja Bem-vindo...";
                    picBox_25.Visible = true;
                    break;

                case 50:
                    lbl_CarText.Visible = true;
                    lbl_CarText.Text = "Carregando o Banco de Dados...";
                    picBox_50.Visible = true;

                    if (!TesteDB())
                    {
                        MessageBox.Show("Erro ao conectar com o banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    break;

                case 75:
                    lbl_CarText.Visible = true;
                    lbl_CarText.Text = "Configurando...";
                    picBox_75.Visible = true;
                    break;

                case 85:
                    lbl_CarText.Visible = true;
                    lbl_CarText.Text = "Carregando os estoques...";
                    picBox_90.Visible = true;
                    break;

                default:
                    break;
            }
        }

        private bool TesteDB()
        {
            const string strConnection = "server=127.0.0.1;port=3306;User Id=root;database=curso_db;password=J#nsen1804";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(strConnection))
                {
                    conexao.Open();
                    return conexao.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar com o banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}


