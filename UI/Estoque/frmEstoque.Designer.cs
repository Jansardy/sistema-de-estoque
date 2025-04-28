namespace Sistema_de_Estoque.UI.Estoque
{
    partial class frmEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.cbBox_Categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dgv_EstoquePro = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EstoquePro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbBox_Categoria);
            this.panel1.Controls.Add(this.txtBox_Nome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 80);
            this.panel1.TabIndex = 0;
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Nome.Location = new System.Drawing.Point(75, 13);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(191, 22);
            this.txtBox_Nome.TabIndex = 0;
            // 
            // cbBox_Categoria
            // 
            this.cbBox_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cbBox_Categoria.FormattingEnabled = true;
            this.cbBox_Categoria.Location = new System.Drawing.Point(75, 49);
            this.cbBox_Categoria.Name = "cbBox_Categoria";
            this.cbBox_Categoria.Size = new System.Drawing.Size(191, 24);
            this.cbBox_Categoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(635, 13);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 55);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "button1";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // dgv_EstoquePro
            // 
            this.dgv_EstoquePro.AllowUserToAddRows = false;
            this.dgv_EstoquePro.AllowUserToDeleteRows = false;
            this.dgv_EstoquePro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_EstoquePro.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgv_EstoquePro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_EstoquePro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_EstoquePro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EstoquePro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NomeProduto,
            this.Quantidade,
            this.Categoria,
            this.Preco,
            this.FornecedorID});
            this.dgv_EstoquePro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_EstoquePro.Location = new System.Drawing.Point(0, 80);
            this.dgv_EstoquePro.MultiSelect = false;
            this.dgv_EstoquePro.Name = "dgv_EstoquePro";
            this.dgv_EstoquePro.ReadOnly = true;
            this.dgv_EstoquePro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_EstoquePro.Size = new System.Drawing.Size(723, 360);
            this.dgv_EstoquePro.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Código";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Estoque Atual";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria (opcional)";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // FornecedorID
            // 
            this.FornecedorID.HeaderText = "Fornecedor";
            this.FornecedorID.Name = "FornecedorID";
            this.FornecedorID.ReadOnly = true;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 440);
            this.Controls.Add(this.dgv_EstoquePro);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EstoquePro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBox_Categoria;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.DataGridView dgv_EstoquePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorID;
    }
}