namespace Sistema_de_Estoque.UI.Cadastros
{
    partial class frmUsuarios
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
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.pnl_Funcao = new System.Windows.Forms.Panel();
            this.btn_Can = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.CB_NivelAcesso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBox_Login = new System.Windows.Forms.TextBox();
            this.TxtBox_Senha = new System.Windows.Forms.TextBox();
            this.TxtBox_Nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBox_ID = new System.Windows.Forms.TextBox();
            this.pnl_Button.SuspendLayout();
            this.pnl_Funcao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Button.Controls.Add(this.btn_Deletar);
            this.pnl_Button.Controls.Add(this.btn_Editar);
            this.pnl_Button.Controls.Add(this.btn_Buscar);
            this.pnl_Button.Controls.Add(this.btn_Inserir);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Button.Location = new System.Drawing.Point(0, 0);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(66, 236);
            this.pnl_Button.TabIndex = 0;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Deletar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_DelUser;
            this.btn_Deletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Deletar.Location = new System.Drawing.Point(8, 177);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(52, 52);
            this.btn_Deletar.TabIndex = 3;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            this.btn_Deletar.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Deletar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_editUser;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Editar.Location = new System.Drawing.Point(8, 119);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(52, 52);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            this.btn_Editar.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Editar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_procUser;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Buscar.Location = new System.Drawing.Point(8, 61);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(52, 52);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            this.btn_Buscar.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Buscar.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inserir.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Inserir.Location = new System.Drawing.Point(8, 3);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(52, 52);
            this.btn_Inserir.TabIndex = 0;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            this.btn_Inserir.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Inserir.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pnl_Funcao
            // 
            this.pnl_Funcao.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_Funcao.Controls.Add(this.label5);
            this.pnl_Funcao.Controls.Add(this.TxtBox_ID);
            this.pnl_Funcao.Controls.Add(this.btn_Can);
            this.pnl_Funcao.Controls.Add(this.btn_Ok);
            this.pnl_Funcao.Controls.Add(this.CB_NivelAcesso);
            this.pnl_Funcao.Controls.Add(this.label4);
            this.pnl_Funcao.Controls.Add(this.label3);
            this.pnl_Funcao.Controls.Add(this.label2);
            this.pnl_Funcao.Controls.Add(this.label1);
            this.pnl_Funcao.Controls.Add(this.TxtBox_Login);
            this.pnl_Funcao.Controls.Add(this.TxtBox_Senha);
            this.pnl_Funcao.Controls.Add(this.TxtBox_Nome);
            this.pnl_Funcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Funcao.Location = new System.Drawing.Point(66, 0);
            this.pnl_Funcao.Name = "pnl_Funcao";
            this.pnl_Funcao.Size = new System.Drawing.Size(418, 236);
            this.pnl_Funcao.TabIndex = 1;
            // 
            // btn_Can
            // 
            this.btn_Can.Enabled = false;
            this.btn_Can.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Can.Image = global::Sistema_de_Estoque.Properties.Resources.icon_Cancelar;
            this.btn_Can.Location = new System.Drawing.Point(355, 194);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(35, 35);
            this.btn_Can.TabIndex = 10;
            this.btn_Can.UseVisualStyleBackColor = true;
            this.btn_Can.Click += new System.EventHandler(this.btn_Can_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Enabled = false;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Image = global::Sistema_de_Estoque.Properties.Resources.icon_add;
            this.btn_Ok.Location = new System.Drawing.Point(301, 194);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(35, 35);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // CB_NivelAcesso
            // 
            this.CB_NivelAcesso.BackColor = System.Drawing.SystemColors.Window;
            this.CB_NivelAcesso.Enabled = false;
            this.CB_NivelAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.CB_NivelAcesso.FormattingEnabled = true;
            this.CB_NivelAcesso.Items.AddRange(new object[] {
            "Admin",
            "Vendedor"});
            this.CB_NivelAcesso.Location = new System.Drawing.Point(17, 197);
            this.CB_NivelAcesso.Name = "CB_NivelAcesso";
            this.CB_NivelAcesso.Size = new System.Drawing.Size(146, 25);
            this.CB_NivelAcesso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(218, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(218, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(14, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nível Acesso";
            // 
            // TxtBox_Login
            // 
            this.TxtBox_Login.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_Login.Enabled = false;
            this.TxtBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TxtBox_Login.Location = new System.Drawing.Point(17, 121);
            this.TxtBox_Login.Name = "TxtBox_Login";
            this.TxtBox_Login.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Login.TabIndex = 1;
            // 
            // TxtBox_Senha
            // 
            this.TxtBox_Senha.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_Senha.Enabled = false;
            this.TxtBox_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TxtBox_Senha.Location = new System.Drawing.Point(221, 121);
            this.TxtBox_Senha.Name = "TxtBox_Senha";
            this.TxtBox_Senha.PasswordChar = '*';
            this.TxtBox_Senha.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Senha.TabIndex = 2;
            // 
            // TxtBox_Nome
            // 
            this.TxtBox_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_Nome.Enabled = false;
            this.TxtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TxtBox_Nome.Location = new System.Drawing.Point(221, 33);
            this.TxtBox_Nome.Name = "TxtBox_Nome";
            this.TxtBox_Nome.Size = new System.Drawing.Size(146, 23);
            this.TxtBox_Nome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // TxtBox_ID
            // 
            this.TxtBox_ID.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_ID.Enabled = false;
            this.TxtBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.TxtBox_ID.Location = new System.Drawing.Point(17, 33);
            this.TxtBox_ID.Name = "TxtBox_ID";
            this.TxtBox_ID.Size = new System.Drawing.Size(84, 23);
            this.TxtBox_ID.TabIndex = 11;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.pnl_Funcao);
            this.Controls.Add(this.pnl_Button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Funcao.ResumeLayout(false);
            this.pnl_Funcao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Panel pnl_Funcao;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.TextBox TxtBox_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBox_Login;
        private System.Windows.Forms.TextBox TxtBox_Senha;
        private System.Windows.Forms.ComboBox CB_NivelAcesso;
        private System.Windows.Forms.Button btn_Can;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBox_ID;
    }
}