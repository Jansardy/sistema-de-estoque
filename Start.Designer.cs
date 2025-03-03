namespace Sistema_de_Estoque
{
    partial class Start
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgBar_Car = new System.Windows.Forms.ProgressBar();
            this.lbl_CarText = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picBox_90 = new System.Windows.Forms.PictureBox();
            this.picBox_75 = new System.Windows.Forms.PictureBox();
            this.picBox_50 = new System.Windows.Forms.PictureBox();
            this.picBox_25 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_25)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgBar_Car
            // 
            this.pgBar_Car.Location = new System.Drawing.Point(12, 235);
            this.pgBar_Car.Name = "pgBar_Car";
            this.pgBar_Car.Size = new System.Drawing.Size(449, 23);
            this.pgBar_Car.TabIndex = 0;
            // 
            // lbl_CarText
            // 
            this.lbl_CarText.AutoSize = true;
            this.lbl_CarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CarText.Location = new System.Drawing.Point(100, 168);
            this.lbl_CarText.Name = "lbl_CarText";
            this.lbl_CarText.Size = new System.Drawing.Size(50, 16);
            this.lbl_CarText.TabIndex = 6;
            this.lbl_CarText.Text = "label1";
            this.lbl_CarText.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sistema_de_Estoque.Properties.Resources._2161;
            this.pictureBox4.Location = new System.Drawing.Point(172, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // picBox_90
            // 
            this.picBox_90.Image = global::Sistema_de_Estoque.Properties.Resources.carregando_estoque;
            this.picBox_90.Location = new System.Drawing.Point(337, 197);
            this.picBox_90.Name = "picBox_90";
            this.picBox_90.Size = new System.Drawing.Size(32, 32);
            this.picBox_90.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_90.TabIndex = 4;
            this.picBox_90.TabStop = false;
            this.picBox_90.Visible = false;
            // 
            // picBox_75
            // 
            this.picBox_75.Image = global::Sistema_de_Estoque.Properties.Resources.Configurando_Sistema;
            this.picBox_75.Location = new System.Drawing.Point(259, 197);
            this.picBox_75.Name = "picBox_75";
            this.picBox_75.Size = new System.Drawing.Size(32, 32);
            this.picBox_75.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_75.TabIndex = 3;
            this.picBox_75.TabStop = false;
            this.picBox_75.Visible = false;
            // 
            // picBox_50
            // 
            this.picBox_50.Image = global::Sistema_de_Estoque.Properties.Resources.carregando_DB;
            this.picBox_50.Location = new System.Drawing.Point(181, 197);
            this.picBox_50.Name = "picBox_50";
            this.picBox_50.Size = new System.Drawing.Size(32, 32);
            this.picBox_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_50.TabIndex = 2;
            this.picBox_50.TabStop = false;
            this.picBox_50.Visible = false;
            // 
            // picBox_25
            // 
            this.picBox_25.Image = global::Sistema_de_Estoque.Properties.Resources.bem_vindo;
            this.picBox_25.Location = new System.Drawing.Point(103, 197);
            this.picBox_25.Name = "picBox_25";
            this.picBox_25.Size = new System.Drawing.Size(32, 32);
            this.picBox_25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_25.TabIndex = 1;
            this.picBox_25.TabStop = false;
            this.picBox_25.Visible = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(473, 270);
            this.Controls.Add(this.lbl_CarText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picBox_90);
            this.Controls.Add(this.picBox_75);
            this.Controls.Add(this.picBox_50);
            this.Controls.Add(this.picBox_25);
            this.Controls.Add(this.pgBar_Car);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_25)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgBar_Car;
        private System.Windows.Forms.PictureBox picBox_25;
        private System.Windows.Forms.PictureBox picBox_50;
        private System.Windows.Forms.PictureBox picBox_90;
        private System.Windows.Forms.PictureBox picBox_75;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_CarText;
    }
}

