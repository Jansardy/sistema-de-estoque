using System.Drawing;

namespace Sistema_de_Estoque.UI
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox_User = new System.Windows.Forms.TextBox();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.txtBox_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBox_User = new System.Windows.Forms.PictureBox();
            this.picBox_Senha = new System.Windows.Forms.PictureBox();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Senha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_User
            // 
            this.txtBox_User.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_User.Font = new System.Drawing.Font("Arial", 11.25F);
            this.txtBox_User.Location = new System.Drawing.Point(109, 230);
            this.txtBox_User.Name = "txtBox_User";
            this.txtBox_User.Size = new System.Drawing.Size(190, 25);
            this.txtBox_User.TabIndex = 1;
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.Image = global::Sistema_de_Estoque.Properties.Resources.logo_Login;
            this.picBox_Logo.Location = new System.Drawing.Point(138, 12);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(128, 128);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Logo.TabIndex = 0;
            this.picBox_Logo.TabStop = false;
            // 
            // txtBox_Pass
            // 
            this.txtBox_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Pass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Pass.Location = new System.Drawing.Point(109, 293);
            this.txtBox_Pass.Name = "txtBox_Pass";
            this.txtBox_Pass.PasswordChar = '*';
            this.txtBox_Pass.Size = new System.Drawing.Size(190, 25);
            this.txtBox_Pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // picBox_User
            // 
            this.picBox_User.Image = global::Sistema_de_Estoque.Properties.Resources.logo_User;
            this.picBox_User.Location = new System.Drawing.Point(68, 223);
            this.picBox_User.Name = "picBox_User";
            this.picBox_User.Size = new System.Drawing.Size(32, 32);
            this.picBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_User.TabIndex = 5;
            this.picBox_User.TabStop = false;
            // 
            // picBox_Senha
            // 
            this.picBox_Senha.Image = global::Sistema_de_Estoque.Properties.Resources.logo_pass;
            this.picBox_Senha.Location = new System.Drawing.Point(68, 286);
            this.picBox_Senha.Name = "picBox_Senha";
            this.picBox_Senha.Size = new System.Drawing.Size(32, 32);
            this.picBox_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Senha.TabIndex = 6;
            this.picBox_Senha.TabStop = false;
            // 
            // btn_Logar
            // 
            this.btn_Logar.Font = new System.Drawing.Font("Arial", 9F);
            this.btn_Logar.Location = new System.Drawing.Point(224, 338);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(75, 33);
            this.btn_Logar.TabIndex = 7;
            this.btn_Logar.Text = "Logar";
            this.btn_Logar.UseVisualStyleBackColor = true;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(109, 338);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(404, 383);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.picBox_Senha);
            this.Controls.Add(this.picBox_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Pass);
            this.Controls.Add(this.txtBox_User);
            this.Controls.Add(this.picBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Senha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.TextBox txtBox_User;
        private System.Windows.Forms.TextBox txtBox_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBox_User;
        private System.Windows.Forms.PictureBox picBox_Senha;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}