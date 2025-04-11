namespace Sistema_de_Estoque.UI.Movimentações
{
    partial class frmMovimentacao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.txtBox_Produto = new System.Windows.Forms.TextBox();
            this.CB_Movimentos = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtBox_Usuário = new System.Windows.Forms.TextBox();
            this.txtBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.CB_Motivos = new System.Windows.Forms.ComboBox();
            this.richTxtBox_Motivos = new System.Windows.Forms.RichTextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_BuscarFornecedor = new System.Windows.Forms.Button();
            this.btn_BuscarUsuario = new System.Windows.Forms.Button();
            this.btn_BuscarProduto = new System.Windows.Forms.Button();
            this.numUpDown_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.lbl222 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Image = global::Sistema_de_Estoque.Properties.Resources.ico_MoveCan21;
            this.btn_Cancelar.Location = new System.Drawing.Point(94, 8);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(35, 35);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Enabled = false;
            this.btn_Gravar.Image = global::Sistema_de_Estoque.Properties.Resources.logo_User;
            this.btn_Gravar.Location = new System.Drawing.Point(53, 8);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(35, 35);
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.UseVisualStyleBackColor = true;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Image = global::Sistema_de_Estoque.Properties.Resources.ico_MoveNovo;
            this.btn_Novo.Location = new System.Drawing.Point(12, 8);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(35, 35);
            this.btn_Novo.TabIndex = 1;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Enabled = false;
            this.txtBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_ID.Location = new System.Drawing.Point(12, 82);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(95, 22);
            this.txtBox_ID.TabIndex = 1;
            // 
            // txtBox_Produto
            // 
            this.txtBox_Produto.Enabled = false;
            this.txtBox_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Produto.Location = new System.Drawing.Point(342, 151);
            this.txtBox_Produto.Name = "txtBox_Produto";
            this.txtBox_Produto.Size = new System.Drawing.Size(130, 22);
            this.txtBox_Produto.TabIndex = 2;
            // 
            // CB_Movimentos
            // 
            this.CB_Movimentos.Enabled = false;
            this.CB_Movimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.CB_Movimentos.FormattingEnabled = true;
            this.CB_Movimentos.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.CB_Movimentos.Location = new System.Drawing.Point(145, 82);
            this.CB_Movimentos.Name = "CB_Movimentos";
            this.CB_Movimentos.Size = new System.Drawing.Size(121, 24);
            this.CB_Movimentos.TabIndex = 5;
            this.CB_Movimentos.SelectedIndexChanged += new System.EventHandler(this.CB_Movimentos_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(278, 209);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // txtBox_Usuário
            // 
            this.txtBox_Usuário.Enabled = false;
            this.txtBox_Usuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Usuário.Location = new System.Drawing.Point(342, 82);
            this.txtBox_Usuário.Name = "txtBox_Usuário";
            this.txtBox_Usuário.Size = new System.Drawing.Size(130, 22);
            this.txtBox_Usuário.TabIndex = 7;
            // 
            // txtBox_Fornecedor
            // 
            this.txtBox_Fornecedor.Enabled = false;
            this.txtBox_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Fornecedor.Location = new System.Drawing.Point(144, 149);
            this.txtBox_Fornecedor.Name = "txtBox_Fornecedor";
            this.txtBox_Fornecedor.Size = new System.Drawing.Size(129, 22);
            this.txtBox_Fornecedor.TabIndex = 9;
            // 
            // CB_Motivos
            // 
            this.CB_Motivos.Enabled = false;
            this.CB_Motivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.CB_Motivos.FormattingEnabled = true;
            this.CB_Motivos.Location = new System.Drawing.Point(13, 239);
            this.CB_Motivos.Name = "CB_Motivos";
            this.CB_Motivos.Size = new System.Drawing.Size(156, 24);
            this.CB_Motivos.TabIndex = 11;
            // 
            // richTxtBox_Motivos
            // 
            this.richTxtBox_Motivos.Enabled = false;
            this.richTxtBox_Motivos.Location = new System.Drawing.Point(13, 266);
            this.richTxtBox_Motivos.Name = "richTxtBox_Motivos";
            this.richTxtBox_Motivos.Size = new System.Drawing.Size(253, 96);
            this.richTxtBox_Motivos.TabIndex = 12;
            this.richTxtBox_Motivos.Text = "";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ID.Location = new System.Drawing.Point(9, 65);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 16);
            this.ID.TabIndex = 13;
            this.ID.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(141, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Entrada / Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(141, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fornecedor (Código)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(339, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Produto (Código)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(339, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Usuário (Código)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(10, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Motivo";
            // 
            // btn_BuscarFornecedor
            // 
            this.btn_BuscarFornecedor.Enabled = false;
            this.btn_BuscarFornecedor.Image = global::Sistema_de_Estoque.Properties.Resources.ico_lupa;
            this.btn_BuscarFornecedor.Location = new System.Drawing.Point(280, 148);
            this.btn_BuscarFornecedor.Name = "btn_BuscarFornecedor";
            this.btn_BuscarFornecedor.Size = new System.Drawing.Size(25, 25);
            this.btn_BuscarFornecedor.TabIndex = 10;
            this.btn_BuscarFornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarUsuario
            // 
            this.btn_BuscarUsuario.Enabled = false;
            this.btn_BuscarUsuario.Image = global::Sistema_de_Estoque.Properties.Resources.ico_lupa;
            this.btn_BuscarUsuario.Location = new System.Drawing.Point(478, 81);
            this.btn_BuscarUsuario.Name = "btn_BuscarUsuario";
            this.btn_BuscarUsuario.Size = new System.Drawing.Size(25, 25);
            this.btn_BuscarUsuario.TabIndex = 8;
            this.btn_BuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarProduto
            // 
            this.btn_BuscarProduto.Enabled = false;
            this.btn_BuscarProduto.Image = global::Sistema_de_Estoque.Properties.Resources.ico_lupa;
            this.btn_BuscarProduto.Location = new System.Drawing.Point(478, 150);
            this.btn_BuscarProduto.Name = "btn_BuscarProduto";
            this.btn_BuscarProduto.Size = new System.Drawing.Size(25, 25);
            this.btn_BuscarProduto.TabIndex = 4;
            this.btn_BuscarProduto.UseVisualStyleBackColor = true;
            // 
            // numUpDown_Quantidade
            // 
            this.numUpDown_Quantidade.Enabled = false;
            this.numUpDown_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.numUpDown_Quantidade.Location = new System.Drawing.Point(13, 148);
            this.numUpDown_Quantidade.Name = "numUpDown_Quantidade";
            this.numUpDown_Quantidade.Size = new System.Drawing.Size(120, 22);
            this.numUpDown_Quantidade.TabIndex = 20;
            // 
            // lbl222
            // 
            this.lbl222.AutoSize = true;
            this.lbl222.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lbl222.Location = new System.Drawing.Point(10, 129);
            this.lbl222.Name = "lbl222";
            this.lbl222.Size = new System.Drawing.Size(77, 16);
            this.lbl222.TabIndex = 21;
            this.lbl222.Text = "Quantidade";
            // 
            // frmMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(514, 376);
            this.Controls.Add(this.lbl222);
            this.Controls.Add(this.numUpDown_Quantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.richTxtBox_Motivos);
            this.Controls.Add(this.CB_Motivos);
            this.Controls.Add(this.btn_BuscarFornecedor);
            this.Controls.Add(this.txtBox_Fornecedor);
            this.Controls.Add(this.btn_BuscarUsuario);
            this.Controls.Add(this.txtBox_Usuário);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CB_Movimentos);
            this.Controls.Add(this.btn_BuscarProduto);
            this.Controls.Add(this.txtBox_Produto);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMovimentacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação do Estoque";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_Quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.TextBox txtBox_Produto;
        private System.Windows.Forms.Button btn_BuscarProduto;
        private System.Windows.Forms.ComboBox CB_Movimentos;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btn_BuscarUsuario;
        private System.Windows.Forms.TextBox txtBox_Usuário;
        private System.Windows.Forms.Button btn_BuscarFornecedor;
        private System.Windows.Forms.TextBox txtBox_Fornecedor;
        private System.Windows.Forms.ComboBox CB_Motivos;
        private System.Windows.Forms.RichTextBox richTxtBox_Motivos;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numUpDown_Quantidade;
        private System.Windows.Forms.Label lbl222;
    }
}