namespace Sistema_de_Estoque.UI.Movimentações.UI.Funções
{
    partial class frmBuscarFull
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Page_Procurar = new System.Windows.Forms.TabPage();
            this.CB_Produtos = new System.Windows.Forms.ComboBox();
            this.lb_Produto = new System.Windows.Forms.Label();
            this.lb_Tipo = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txtBox_Tipo = new System.Windows.Forms.TextBox();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_can = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.Page_Resultado = new System.Windows.Forms.TabPage();
            this.dgv_Resultado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.Page_Procurar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Page_Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Page_Procurar);
            this.tabControl.Controls.Add(this.Page_Resultado);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(334, 261);
            this.tabControl.TabIndex = 0;
            // 
            // Page_Procurar
            // 
            this.Page_Procurar.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Procurar.Controls.Add(this.CB_Produtos);
            this.Page_Procurar.Controls.Add(this.lb_Produto);
            this.Page_Procurar.Controls.Add(this.lb_Tipo);
            this.Page_Procurar.Controls.Add(this.lb_Name);
            this.Page_Procurar.Controls.Add(this.txtBox_Tipo);
            this.Page_Procurar.Controls.Add(this.txtBox_Name);
            this.Page_Procurar.Controls.Add(this.panel2);
            this.Page_Procurar.Location = new System.Drawing.Point(4, 22);
            this.Page_Procurar.Name = "Page_Procurar";
            this.Page_Procurar.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Procurar.Size = new System.Drawing.Size(326, 235);
            this.Page_Procurar.TabIndex = 0;
            this.Page_Procurar.Text = "Procurar";
            // 
            // CB_Produtos
            // 
            this.CB_Produtos.Enabled = false;
            this.CB_Produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.CB_Produtos.FormattingEnabled = true;
            this.CB_Produtos.Location = new System.Drawing.Point(69, 155);
            this.CB_Produtos.Name = "CB_Produtos";
            this.CB_Produtos.Size = new System.Drawing.Size(191, 24);
            this.CB_Produtos.TabIndex = 8;
            this.CB_Produtos.Visible = false;
            // 
            // lb_Produto
            // 
            this.lb_Produto.AutoSize = true;
            this.lb_Produto.Enabled = false;
            this.lb_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lb_Produto.Location = new System.Drawing.Point(66, 131);
            this.lb_Produto.Name = "lb_Produto";
            this.lb_Produto.Size = new System.Drawing.Size(104, 16);
            this.lb_Produto.TabIndex = 7;
            this.lb_Produto.Text = "Tipo de Produto";
            this.lb_Produto.Visible = false;
            // 
            // lb_Tipo
            // 
            this.lb_Tipo.AutoSize = true;
            this.lb_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lb_Tipo.Location = new System.Drawing.Point(66, 77);
            this.lb_Tipo.Name = "lb_Tipo";
            this.lb_Tipo.Size = new System.Drawing.Size(95, 16);
            this.lb_Tipo.TabIndex = 6;
            this.lb_Tipo.Text = "Tipo de Busca";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lb_Name.Location = new System.Drawing.Point(66, 23);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(44, 16);
            this.lb_Name.TabIndex = 5;
            this.lb_Name.Text = "label1";
            // 
            // txtBox_Tipo
            // 
            this.txtBox_Tipo.Enabled = false;
            this.txtBox_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Tipo.Location = new System.Drawing.Point(69, 101);
            this.txtBox_Tipo.Name = "txtBox_Tipo";
            this.txtBox_Tipo.Size = new System.Drawing.Size(191, 22);
            this.txtBox_Tipo.TabIndex = 4;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Name.Location = new System.Drawing.Point(69, 47);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(191, 22);
            this.txtBox_Name.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_can);
            this.panel2.Controls.Add(this.btn_Procurar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 33);
            this.panel2.TabIndex = 1;
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(136, 5);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(75, 23);
            this.btn_can.TabIndex = 2;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            this.btn_can.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Location = new System.Drawing.Point(232, 5);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(75, 23);
            this.btn_Procurar.TabIndex = 1;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = true;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // Page_Resultado
            // 
            this.Page_Resultado.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Resultado.Controls.Add(this.dgv_Resultado);
            this.Page_Resultado.Controls.Add(this.panel1);
            this.Page_Resultado.Location = new System.Drawing.Point(4, 22);
            this.Page_Resultado.Name = "Page_Resultado";
            this.Page_Resultado.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Resultado.Size = new System.Drawing.Size(326, 235);
            this.Page_Resultado.TabIndex = 1;
            this.Page_Resultado.Text = "Resultado";
            // 
            // dgv_Resultado
            // 
            this.dgv_Resultado.AllowUserToDeleteRows = false;
            this.dgv_Resultado.AllowUserToOrderColumns = true;
            this.dgv_Resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Resultado.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Resultado.Location = new System.Drawing.Point(3, 3);
            this.dgv_Resultado.Name = "dgv_Resultado";
            this.dgv_Resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Resultado.Size = new System.Drawing.Size(320, 196);
            this.dgv_Resultado.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 33);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_can_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(232, 5);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // frmBuscarFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarFull";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.frmBuscarFull_Load);
            this.tabControl.ResumeLayout(false);
            this.Page_Procurar.ResumeLayout(false);
            this.Page_Procurar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Page_Resultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Page_Procurar;
        private System.Windows.Forms.TabPage Page_Resultado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Resultado;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label lb_Produto;
        private System.Windows.Forms.Label lb_Tipo;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txtBox_Tipo;
        private System.Windows.Forms.ComboBox CB_Produtos;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Confirmar;
    }
}