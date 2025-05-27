namespace Sistema_de_Estoque.UI.Cadastros
{
    partial class frmProdutos
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Can = new System.Windows.Forms.Button();
            this.pnl_Funcao = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBox_Preco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Fornecedor = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumUp_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBox_Nome = new System.Windows.Forms.TextBox();
            this.pnl_Button.SuspendLayout();
            this.pnl_Funcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_Quantidade)).BeginInit();
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
            this.pnl_Button.TabIndex = 2;
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
            this.btn_Ok.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Ok.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
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
            this.btn_Can.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btn_Can.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pnl_Funcao
            // 
            this.pnl_Funcao.BackColor = System.Drawing.SystemColors.Menu;
            this.pnl_Funcao.Controls.Add(this.label6);
            this.pnl_Funcao.Controls.Add(this.TxtBox_ID);
            this.pnl_Funcao.Controls.Add(this.label5);
            this.pnl_Funcao.Controls.Add(this.TxtBox_Preco);
            this.pnl_Funcao.Controls.Add(this.label3);
            this.pnl_Funcao.Controls.Add(this.CB_Fornecedor);
            this.pnl_Funcao.Controls.Add(this.panel1);
            this.pnl_Funcao.Controls.Add(this.label2);
            this.pnl_Funcao.Controls.Add(this.label1);
            this.pnl_Funcao.Controls.Add(this.NumUp_Quantidade);
            this.pnl_Funcao.Controls.Add(this.CB_Categoria);
            this.pnl_Funcao.Controls.Add(this.btn_Can);
            this.pnl_Funcao.Controls.Add(this.btn_Ok);
            this.pnl_Funcao.Controls.Add(this.label4);
            this.pnl_Funcao.Controls.Add(this.TxtBox_Nome);
            this.pnl_Funcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Funcao.Location = new System.Drawing.Point(66, 0);
            this.pnl_Funcao.Name = "pnl_Funcao";
            this.pnl_Funcao.Size = new System.Drawing.Size(418, 236);
            this.pnl_Funcao.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // TxtBox_ID
            // 
            this.TxtBox_ID.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_ID.Enabled = false;
            this.TxtBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.TxtBox_ID.Location = new System.Drawing.Point(6, 23);
            this.TxtBox_ID.Name = "TxtBox_ID";
            this.TxtBox_ID.Size = new System.Drawing.Size(64, 19);
            this.TxtBox_ID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Preço";
            // 
            // TxtBox_Preco
            // 
            this.TxtBox_Preco.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_Preco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_Preco.Enabled = false;
            this.TxtBox_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.TxtBox_Preco.Location = new System.Drawing.Point(6, 119);
            this.TxtBox_Preco.Name = "TxtBox_Preco";
            this.TxtBox_Preco.Size = new System.Drawing.Size(140, 19);
            this.TxtBox_Preco.TabIndex = 18;
            this.TxtBox_Preco.Leave += new System.EventHandler(this.txtBox_Preco_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Forncedor(COD)";
            // 
            // CB_Fornecedor
            // 
            this.CB_Fornecedor.Enabled = false;
            this.CB_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.CB_Fornecedor.FormattingEnabled = true;
            this.CB_Fornecedor.Location = new System.Drawing.Point(275, 108);
            this.CB_Fornecedor.Name = "CB_Fornecedor";
            this.CB_Fornecedor.Size = new System.Drawing.Size(136, 21);
            this.CB_Fornecedor.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(272, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 174);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Quantidade";
            // 
            // NumUp_Quantidade
            // 
            this.NumUp_Quantidade.Enabled = false;
            this.NumUp_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.NumUp_Quantidade.Location = new System.Drawing.Point(180, 119);
            this.NumUp_Quantidade.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NumUp_Quantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumUp_Quantidade.Name = "NumUp_Quantidade";
            this.NumUp_Quantidade.Size = new System.Drawing.Size(70, 19);
            this.NumUp_Quantidade.TabIndex = 12;
            this.NumUp_Quantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.Enabled = false;
            this.CB_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Location = new System.Drawing.Point(275, 31);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(136, 21);
            this.CB_Categoria.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome(Produto)";
            // 
            // TxtBox_Nome
            // 
            this.TxtBox_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBox_Nome.Enabled = false;
            this.TxtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
            this.TxtBox_Nome.Location = new System.Drawing.Point(6, 68);
            this.TxtBox_Nome.Name = "TxtBox_Nome";
            this.TxtBox_Nome.Size = new System.Drawing.Size(260, 19);
            this.TxtBox_Nome.TabIndex = 0;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.pnl_Funcao);
            this.Controls.Add(this.pnl_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Funcao.ResumeLayout(false);
            this.pnl_Funcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUp_Quantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Can;
        private System.Windows.Forms.Panel pnl_Funcao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBox_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumUp_Quantidade;
        private System.Windows.Forms.ComboBox CB_Categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Fornecedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBox_Preco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBox_ID;
    }
}