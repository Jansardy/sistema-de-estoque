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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_Login = new System.Windows.Forms.TextBox();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.txtBox_Senha = new System.Windows.Forms.TextBox();
            this.cBox_Nivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.btn_Can = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pnl_Top.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Top.Controls.Add(this.btn_Inserir);
            this.pnl_Top.Controls.Add(this.btn_Deletar);
            this.pnl_Top.Controls.Add(this.btn_Editar);
            this.pnl_Top.Controls.Add(this.btn_Procurar);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(483, 61);
            this.pnl_Top.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnl_Bottom);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cBox_Nivel);
            this.panel1.Controls.Add(this.txtBox_Senha);
            this.panel1.Controls.Add(this.txtBox_Nome);
            this.panel1.Controls.Add(this.txtBox_Login);
            this.panel1.Controls.Add(this.txtBox_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 207);
            this.panel1.TabIndex = 5;
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.CausesValidation = false;
            this.txtBox_ID.Location = new System.Drawing.Point(12, 38);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(69, 20);
            this.txtBox_ID.TabIndex = 0;
            // 
            // txtBox_Login
            // 
            this.txtBox_Login.Location = new System.Drawing.Point(12, 93);
            this.txtBox_Login.Name = "txtBox_Login";
            this.txtBox_Login.Size = new System.Drawing.Size(116, 20);
            this.txtBox_Login.TabIndex = 1;
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Location = new System.Drawing.Point(160, 38);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(178, 20);
            this.txtBox_Nome.TabIndex = 2;
            // 
            // txtBox_Senha
            // 
            this.txtBox_Senha.Location = new System.Drawing.Point(160, 93);
            this.txtBox_Senha.Name = "txtBox_Senha";
            this.txtBox_Senha.Size = new System.Drawing.Size(178, 20);
            this.txtBox_Senha.TabIndex = 3;
            // 
            // cBox_Nivel
            // 
            this.cBox_Nivel.FormattingEnabled = true;
            this.cBox_Nivel.Items.AddRange(new object[] {
            "Admin",
            "Vendedor"});
            this.cBox_Nivel.Location = new System.Drawing.Point(363, 38);
            this.cBox_Nivel.Name = "cBox_Nivel";
            this.cBox_Nivel.Size = new System.Drawing.Size(111, 21);
            this.cBox_Nivel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login/User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nivel de Acesso";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_Bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Bottom.Controls.Add(this.btn_Add);
            this.pnl_Bottom.Controls.Add(this.btn_Can);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 163);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(479, 40);
            this.pnl_Bottom.TabIndex = 10;
            // 
            // btn_Can
            // 
            this.btn_Can.Image = global::Sistema_de_Estoque.Properties.Resources.icon_Cancelar;
            this.btn_Can.Location = new System.Drawing.Point(427, 0);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(40, 40);
            this.btn_Can.TabIndex = 0;
            this.btn_Can.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Can.UseVisualStyleBackColor = true;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Inserir.Location = new System.Drawing.Point(12, 4);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(55, 55);
            this.btn_Inserir.TabIndex = 0;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Inserir.UseVisualStyleBackColor = true;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_DelUser;
            this.btn_Deletar.Location = new System.Drawing.Point(195, 4);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(55, 55);
            this.btn_Deletar.TabIndex = 3;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.FlatAppearance.BorderSize = 4;
            this.btn_Editar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_editUser;
            this.btn_Editar.Location = new System.Drawing.Point(134, 4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(55, 55);
            this.btn_Editar.TabIndex = 1;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_procUser;
            this.btn_Procurar.Location = new System.Drawing.Point(73, 4);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(55, 55);
            this.btn_Procurar.TabIndex = 2;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Procurar.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::Sistema_de_Estoque.Properties.Resources.icon_add;
            this.btn_Add.Location = new System.Drawing.Point(363, 0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(483, 268);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.pnl_Top.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.TextBox txtBox_Login;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_Nivel;
        private System.Windows.Forms.TextBox txtBox_Senha;
        private System.Windows.Forms.Button btn_Can;
        private System.Windows.Forms.Button btn_Add;
    }
}