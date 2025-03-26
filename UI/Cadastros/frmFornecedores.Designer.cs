namespace Sistema_de_Estoque.UI.Cadastros
{
    partial class frmFornecedores
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
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.TabControl_Fornecedores = new System.Windows.Forms.TabControl();
            this.Page_Inserir = new System.Windows.Forms.TabPage();
            this.btn_CanInserir = new System.Windows.Forms.Button();
            this.btn_AddInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Endereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.maskTxtBox_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Page_Proc = new System.Windows.Forms.TabPage();
            this.btn_CanProc = new System.Windows.Forms.Button();
            this.btn_AddProc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_pEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_pNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_pID = new System.Windows.Forms.TextBox();
            this.maskTxtBox_pTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_Top.SuspendLayout();
            this.TabControl_Fornecedores.SuspendLayout();
            this.Page_Inserir.SuspendLayout();
            this.Page_Proc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.btn_Deletar);
            this.pnl_Top.Controls.Add(this.btn_Inserir);
            this.pnl_Top.Controls.Add(this.btn_Editar);
            this.pnl_Top.Controls.Add(this.btn_Procurar);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(554, 66);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Deletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Deletar.Location = new System.Drawing.Point(183, 9);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(55, 55);
            this.btn_Deletar.TabIndex = 4;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Inserir.Location = new System.Drawing.Point(12, 9);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(55, 55);
            this.btn_Inserir.TabIndex = 1;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Editar.Location = new System.Drawing.Point(126, 9);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(55, 55);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Procurar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Procurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Procurar.Location = new System.Drawing.Point(69, 9);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(55, 55);
            this.btn_Procurar.TabIndex = 2;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Procurar.UseVisualStyleBackColor = true;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // TabControl_Fornecedores
            // 
            this.TabControl_Fornecedores.Controls.Add(this.Page_Inserir);
            this.TabControl_Fornecedores.Controls.Add(this.Page_Proc);
            this.TabControl_Fornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Fornecedores.Enabled = false;
            this.TabControl_Fornecedores.Location = new System.Drawing.Point(0, 66);
            this.TabControl_Fornecedores.Name = "TabControl_Fornecedores";
            this.TabControl_Fornecedores.SelectedIndex = 0;
            this.TabControl_Fornecedores.Size = new System.Drawing.Size(554, 245);
            this.TabControl_Fornecedores.TabIndex = 1;
            // 
            // Page_Inserir
            // 
            this.Page_Inserir.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Inserir.Controls.Add(this.btn_CanInserir);
            this.Page_Inserir.Controls.Add(this.btn_AddInserir);
            this.Page_Inserir.Controls.Add(this.label4);
            this.Page_Inserir.Controls.Add(this.txtBox_Endereco);
            this.Page_Inserir.Controls.Add(this.label3);
            this.Page_Inserir.Controls.Add(this.txtBox_Nome);
            this.Page_Inserir.Controls.Add(this.label2);
            this.Page_Inserir.Controls.Add(this.txtBox_ID);
            this.Page_Inserir.Controls.Add(this.maskTxtBox_Telefone);
            this.Page_Inserir.Controls.Add(this.label1);
            this.Page_Inserir.Location = new System.Drawing.Point(4, 22);
            this.Page_Inserir.Name = "Page_Inserir";
            this.Page_Inserir.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Inserir.Size = new System.Drawing.Size(546, 219);
            this.Page_Inserir.TabIndex = 0;
            // 
            // btn_CanInserir
            // 
            this.btn_CanInserir.Image = global::Sistema_de_Estoque.Properties.Resources.icon_Cancelar;
            this.btn_CanInserir.Location = new System.Drawing.Point(498, 175);
            this.btn_CanInserir.Name = "btn_CanInserir";
            this.btn_CanInserir.Size = new System.Drawing.Size(40, 40);
            this.btn_CanInserir.TabIndex = 9;
            this.btn_CanInserir.UseVisualStyleBackColor = true;
            this.btn_CanInserir.Click += new System.EventHandler(this.CanInserir);
            // 
            // btn_AddInserir
            // 
            this.btn_AddInserir.Image = global::Sistema_de_Estoque.Properties.Resources.icon_add;
            this.btn_AddInserir.Location = new System.Drawing.Point(446, 175);
            this.btn_AddInserir.Name = "btn_AddInserir";
            this.btn_AddInserir.Size = new System.Drawing.Size(40, 40);
            this.btn_AddInserir.TabIndex = 8;
            this.btn_AddInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AddInserir.UseVisualStyleBackColor = true;
            this.btn_AddInserir.Click += new System.EventHandler(this.btn_AddInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(190, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // txtBox_Endereco
            // 
            this.txtBox_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Endereco.Location = new System.Drawing.Point(193, 94);
            this.txtBox_Endereco.Name = "txtBox_Endereco";
            this.txtBox_Endereco.Size = new System.Drawing.Size(239, 22);
            this.txtBox_Endereco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contato";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Nome.Location = new System.Drawing.Point(193, 32);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(200, 22);
            this.txtBox_Nome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(190, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Enabled = false;
            this.txtBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_ID.Location = new System.Drawing.Point(20, 32);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(78, 22);
            this.txtBox_ID.TabIndex = 2;
            // 
            // maskTxtBox_Telefone
            // 
            this.maskTxtBox_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.maskTxtBox_Telefone.Location = new System.Drawing.Point(20, 94);
            this.maskTxtBox_Telefone.Mask = "(99) 99999-9999";
            this.maskTxtBox_Telefone.Name = "maskTxtBox_Telefone";
            this.maskTxtBox_Telefone.Size = new System.Drawing.Size(110, 22);
            this.maskTxtBox_Telefone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Page_Proc
            // 
            this.Page_Proc.BackColor = System.Drawing.SystemColors.Menu;
            this.Page_Proc.Controls.Add(this.btn_CanProc);
            this.Page_Proc.Controls.Add(this.btn_AddProc);
            this.Page_Proc.Controls.Add(this.label5);
            this.Page_Proc.Controls.Add(this.txtBox_pEndereco);
            this.Page_Proc.Controls.Add(this.label6);
            this.Page_Proc.Controls.Add(this.txtBox_pNome);
            this.Page_Proc.Controls.Add(this.label7);
            this.Page_Proc.Controls.Add(this.txtBox_pID);
            this.Page_Proc.Controls.Add(this.maskTxtBox_pTelefone);
            this.Page_Proc.Controls.Add(this.label8);
            this.Page_Proc.Location = new System.Drawing.Point(4, 22);
            this.Page_Proc.Name = "Page_Proc";
            this.Page_Proc.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Proc.Size = new System.Drawing.Size(546, 219);
            this.Page_Proc.TabIndex = 1;
            // 
            // btn_CanProc
            // 
            this.btn_CanProc.Image = global::Sistema_de_Estoque.Properties.Resources.icon_Cancelar;
            this.btn_CanProc.Location = new System.Drawing.Point(498, 174);
            this.btn_CanProc.Name = "btn_CanProc";
            this.btn_CanProc.Size = new System.Drawing.Size(40, 40);
            this.btn_CanProc.TabIndex = 19;
            this.btn_CanProc.UseVisualStyleBackColor = true;
            this.btn_CanProc.Click += new System.EventHandler(this.btn_CanProc_Click);
            // 
            // btn_AddProc
            // 
            this.btn_AddProc.Image = global::Sistema_de_Estoque.Properties.Resources.icon_add;
            this.btn_AddProc.Location = new System.Drawing.Point(446, 174);
            this.btn_AddProc.Name = "btn_AddProc";
            this.btn_AddProc.Size = new System.Drawing.Size(40, 40);
            this.btn_AddProc.TabIndex = 18;
            this.btn_AddProc.UseVisualStyleBackColor = true;
            this.btn_AddProc.Click += new System.EventHandler(this.btn_AddProc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(190, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Endereço";
            // 
            // txtBox_pEndereco
            // 
            this.txtBox_pEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pEndereco.Location = new System.Drawing.Point(193, 93);
            this.txtBox_pEndereco.Name = "txtBox_pEndereco";
            this.txtBox_pEndereco.Size = new System.Drawing.Size(239, 22);
            this.txtBox_pEndereco.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(17, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Contato";
            // 
            // txtBox_pNome
            // 
            this.txtBox_pNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pNome.Location = new System.Drawing.Point(193, 31);
            this.txtBox_pNome.Name = "txtBox_pNome";
            this.txtBox_pNome.Size = new System.Drawing.Size(200, 22);
            this.txtBox_pNome.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(190, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nome";
            // 
            // txtBox_pID
            // 
            this.txtBox_pID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pID.Location = new System.Drawing.Point(20, 31);
            this.txtBox_pID.Name = "txtBox_pID";
            this.txtBox_pID.Size = new System.Drawing.Size(78, 22);
            this.txtBox_pID.TabIndex = 12;
            // 
            // maskTxtBox_pTelefone
            // 
            this.maskTxtBox_pTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.maskTxtBox_pTelefone.Location = new System.Drawing.Point(20, 93);
            this.maskTxtBox_pTelefone.Mask = "(99) 9999-9999";
            this.maskTxtBox_pTelefone.Name = "maskTxtBox_pTelefone";
            this.maskTxtBox_pTelefone.Size = new System.Drawing.Size(110, 22);
            this.maskTxtBox_pTelefone.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "ID";
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(554, 311);
            this.Controls.Add(this.TabControl_Fornecedores);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.pnl_Top.ResumeLayout(false);
            this.TabControl_Fornecedores.ResumeLayout(false);
            this.Page_Inserir.ResumeLayout(false);
            this.Page_Inserir.PerformLayout();
            this.Page_Proc.ResumeLayout(false);
            this.Page_Proc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.TabControl TabControl_Fornecedores;
        private System.Windows.Forms.TabPage Page_Inserir;
        private System.Windows.Forms.TabPage Page_Proc;
        private System.Windows.Forms.MaskedTextBox maskTxtBox_Telefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Endereco;
        private System.Windows.Forms.Button btn_CanInserir;
        private System.Windows.Forms.Button btn_AddInserir;
        private System.Windows.Forms.Button btn_CanProc;
        private System.Windows.Forms.Button btn_AddProc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_pEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_pNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_pID;
        private System.Windows.Forms.MaskedTextBox maskTxtBox_pTelefone;
        private System.Windows.Forms.Label label8;
    }
}