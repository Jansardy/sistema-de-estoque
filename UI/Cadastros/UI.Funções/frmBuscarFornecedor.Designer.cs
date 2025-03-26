namespace Sistema_de_Estoque.UI.Cadastros.UI.Funções
{
    partial class frmBuscarFornecedor
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
            this.tabControl_Fornecedor = new System.Windows.Forms.TabControl();
            this.Page_Procurar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Page_Resultado = new System.Windows.Forms.TabPage();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Can2 = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Resultado = new System.Windows.Forms.DataGridView();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Fornecedor.SuspendLayout();
            this.Page_Procurar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Page_Resultado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Fornecedor
            // 
            this.tabControl_Fornecedor.Controls.Add(this.Page_Procurar);
            this.tabControl_Fornecedor.Controls.Add(this.Page_Resultado);
            this.tabControl_Fornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Fornecedor.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Fornecedor.Name = "tabControl_Fornecedor";
            this.tabControl_Fornecedor.SelectedIndex = 0;
            this.tabControl_Fornecedor.Size = new System.Drawing.Size(334, 261);
            this.tabControl_Fornecedor.TabIndex = 0;
            // 
            // Page_Procurar
            // 
            this.Page_Procurar.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Procurar.Controls.Add(this.label1);
            this.Page_Procurar.Controls.Add(this.txtBox_Nome);
            this.Page_Procurar.Controls.Add(this.panel1);
            this.Page_Procurar.Location = new System.Drawing.Point(4, 22);
            this.Page_Procurar.Name = "Page_Procurar";
            this.Page_Procurar.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Procurar.Size = new System.Drawing.Size(326, 235);
            this.Page_Procurar.TabIndex = 0;
            this.Page_Procurar.Text = "Procurar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Procurar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 38);
            this.panel1.TabIndex = 0;
            // 
            // Page_Resultado
            // 
            this.Page_Resultado.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Resultado.Controls.Add(this.dgv_Resultado);
            this.Page_Resultado.Controls.Add(this.panel2);
            this.Page_Resultado.Location = new System.Drawing.Point(4, 22);
            this.Page_Resultado.Name = "Page_Resultado";
            this.Page_Resultado.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Resultado.Size = new System.Drawing.Size(326, 235);
            this.Page_Resultado.TabIndex = 1;
            this.Page_Resultado.Text = "Resultado";
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Location = new System.Drawing.Point(240, 10);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(75, 23);
            this.btn_Procurar.TabIndex = 0;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = true;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(151, 10);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Can2
            // 
            this.btn_Can2.Location = new System.Drawing.Point(151, 10);
            this.btn_Can2.Name = "btn_Can2";
            this.btn_Can2.Size = new System.Drawing.Size(75, 23);
            this.btn_Can2.TabIndex = 1;
            this.btn_Can2.Text = "Cancelar";
            this.btn_Can2.UseVisualStyleBackColor = true;
            this.btn_Can2.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(240, 10);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.btn_Can2);
            this.panel2.Controls.Add(this.btn_Confirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 38);
            this.panel2.TabIndex = 1;
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
            this.dgv_Resultado.Size = new System.Drawing.Size(320, 191);
            this.dgv_Resultado.TabIndex = 2;
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBox_Nome.Location = new System.Drawing.Point(66, 88);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(198, 21);
            this.txtBox_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // frmBuscarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.tabControl_Fornecedor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarFornecedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Fornecedores";
            this.tabControl_Fornecedor.ResumeLayout(false);
            this.Page_Procurar.ResumeLayout(false);
            this.Page_Procurar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Page_Resultado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Fornecedor;
        private System.Windows.Forms.TabPage Page_Procurar;
        private System.Windows.Forms.TabPage Page_Resultado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Can2;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.DataGridView dgv_Resultado;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.Label label1;
    }
}