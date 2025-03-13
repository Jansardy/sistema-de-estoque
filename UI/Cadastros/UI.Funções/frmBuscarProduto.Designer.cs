namespace Sistema_de_Estoque.UI.Cadastros.UI.Funções
{
    partial class frmBuscarProduto
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
            this.Produtos = new System.Windows.Forms.TabControl();
            this.Page_Procurar = new System.Windows.Forms.TabPage();
            this.Page_Resultado = new System.Windows.Forms.TabPage();
            this.pnl_Bottom1 = new System.Windows.Forms.Panel();
            this.pnl_Bottom2 = new System.Windows.Forms.Panel();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.cbBox_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.dgv_Resultado = new System.Windows.Forms.DataGridView();
            this.Produtos.SuspendLayout();
            this.Page_Procurar.SuspendLayout();
            this.Page_Resultado.SuspendLayout();
            this.pnl_Bottom1.SuspendLayout();
            this.pnl_Bottom2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // Produtos
            // 
            this.Produtos.Controls.Add(this.Page_Procurar);
            this.Produtos.Controls.Add(this.Page_Resultado);
            this.Produtos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Produtos.Location = new System.Drawing.Point(0, 0);
            this.Produtos.Name = "Produtos";
            this.Produtos.SelectedIndex = 0;
            this.Produtos.Size = new System.Drawing.Size(334, 261);
            this.Produtos.TabIndex = 0;
            // 
            // Page_Procurar
            // 
            this.Page_Procurar.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Procurar.Controls.Add(this.lbl_Categoria);
            this.Page_Procurar.Controls.Add(this.cbBox_Categoria);
            this.Page_Procurar.Controls.Add(this.txtBox_Nome);
            this.Page_Procurar.Controls.Add(this.lbl_User);
            this.Page_Procurar.Controls.Add(this.pnl_Bottom1);
            this.Page_Procurar.Location = new System.Drawing.Point(4, 22);
            this.Page_Procurar.Name = "Page_Procurar";
            this.Page_Procurar.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Procurar.Size = new System.Drawing.Size(326, 235);
            this.Page_Procurar.TabIndex = 0;
            this.Page_Procurar.Text = "Procurar";
            // 
            // Page_Resultado
            // 
            this.Page_Resultado.Controls.Add(this.dgv_Resultado);
            this.Page_Resultado.Controls.Add(this.pnl_Bottom2);
            this.Page_Resultado.Location = new System.Drawing.Point(4, 22);
            this.Page_Resultado.Name = "Page_Resultado";
            this.Page_Resultado.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Resultado.Size = new System.Drawing.Size(326, 235);
            this.Page_Resultado.TabIndex = 1;
            this.Page_Resultado.Text = "Resultado";
            this.Page_Resultado.UseVisualStyleBackColor = true;
            // 
            // pnl_Bottom1
            // 
            this.pnl_Bottom1.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Bottom1.Controls.Add(this.btn_Cancelar);
            this.pnl_Bottom1.Controls.Add(this.btn_Procurar);
            this.pnl_Bottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom1.Location = new System.Drawing.Point(3, 197);
            this.pnl_Bottom1.Name = "pnl_Bottom1";
            this.pnl_Bottom1.Size = new System.Drawing.Size(320, 35);
            this.pnl_Bottom1.TabIndex = 0;
            // 
            // pnl_Bottom2
            // 
            this.pnl_Bottom2.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Bottom2.Controls.Add(this.button1);
            this.pnl_Bottom2.Controls.Add(this.btn_Confirmar);
            this.pnl_Bottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom2.Location = new System.Drawing.Point(3, 197);
            this.pnl_Bottom2.Name = "pnl_Bottom2";
            this.pnl_Bottom2.Size = new System.Drawing.Size(320, 35);
            this.pnl_Bottom2.TabIndex = 1;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(51, 46);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(41, 15);
            this.lbl_User.TabIndex = 1;
            this.lbl_User.Text = "Nome";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Nome.Location = new System.Drawing.Point(54, 62);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(176, 21);
            this.txtBox_Nome.TabIndex = 2;
            // 
            // cbBox_Categoria
            // 
            this.cbBox_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBox_Categoria.FormattingEnabled = true;
            this.cbBox_Categoria.Location = new System.Drawing.Point(54, 112);
            this.cbBox_Categoria.Name = "cbBox_Categoria";
            this.cbBox_Categoria.Size = new System.Drawing.Size(176, 23);
            this.cbBox_Categoria.TabIndex = 3;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.Location = new System.Drawing.Point(51, 94);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(60, 15);
            this.lbl_Categoria.TabIndex = 4;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Location = new System.Drawing.Point(246, 9);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(69, 23);
            this.btn_Procurar.TabIndex = 0;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(158, 9);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(69, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(246, 9);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(69, 23);
            this.btn_Confirmar.TabIndex = 2;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            // 
            // dgv_Resultado
            // 
            this.dgv_Resultado.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Resultado.Location = new System.Drawing.Point(3, 3);
            this.dgv_Resultado.Name = "dgv_Resultado";
            this.dgv_Resultado.Size = new System.Drawing.Size(320, 194);
            this.dgv_Resultado.TabIndex = 2;
            // 
            // frmBuscarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.Produtos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurar Produtos";
            this.Produtos.ResumeLayout(false);
            this.Page_Procurar.ResumeLayout(false);
            this.Page_Procurar.PerformLayout();
            this.Page_Resultado.ResumeLayout(false);
            this.pnl_Bottom1.ResumeLayout(false);
            this.pnl_Bottom2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Produtos;
        private System.Windows.Forms.TabPage Page_Procurar;
        private System.Windows.Forms.TabPage Page_Resultado;
        private System.Windows.Forms.Panel pnl_Bottom1;
        private System.Windows.Forms.Panel pnl_Bottom2;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.ComboBox cbBox_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.DataGridView dgv_Resultado;
    }
}