namespace Sistema_de_Estoque.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueAtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeMovimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.pnl_Bottom.SuspendLayout();
            this.mnStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_Bottom.Controls.Add(this.lbl_data);
            this.pnl_Bottom.Controls.Add(this.lbl_User);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 656);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1344, 25);
            this.pnl_Bottom.TabIndex = 0;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(867, 3);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(50, 18);
            this.lbl_data.TabIndex = 1;
            this.lbl_data.Text = "label2";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.Location = new System.Drawing.Point(71, 3);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(50, 18);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "label1";
            // 
            // mnStrip
            // 
            this.mnStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.mnStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnStrip.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Margin = new System.Windows.Forms.Padding(3);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Padding = new System.Windows.Forms.Padding(3);
            this.mnStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnStrip.Size = new System.Drawing.Size(1344, 32);
            this.mnStrip.TabIndex = 1;
            this.mnStrip.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtosToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_produto;
            this.produtosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.produtosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fornecedorToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_fornecedor;
            this.fornecedorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fornecedorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuárioToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_user;
            this.usuárioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuárioToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(189, 38);
            this.usuárioToolStripMenuItem.Text = "Usuários";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeProdutosToolStripMenuItem,
            this.saídaDeProdutosToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            this.entradaDeProdutosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaDeProdutosToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_entrada;
            this.entradaDeProdutosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.entradaDeProdutosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            this.entradaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.entradaDeProdutosToolStripMenuItem.Text = "Entrada de produtos";
            this.entradaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.entradaDeProdutosToolStripMenuItem_Click);
            // 
            // saídaDeProdutosToolStripMenuItem
            // 
            this.saídaDeProdutosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saídaDeProdutosToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_saida;
            this.saídaDeProdutosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saídaDeProdutosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.saídaDeProdutosToolStripMenuItem.Name = "saídaDeProdutosToolStripMenuItem";
            this.saídaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(233, 38);
            this.saídaDeProdutosToolStripMenuItem.Text = "Saída de produtos";
            this.saídaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.saídaDeProdutosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueAtualToolStripMenuItem,
            this.históricoDeMovimentaçõesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // estoqueAtualToolStripMenuItem
            // 
            this.estoqueAtualToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoqueAtualToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_caixas;
            this.estoqueAtualToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.estoqueAtualToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.estoqueAtualToolStripMenuItem.Name = "estoqueAtualToolStripMenuItem";
            this.estoqueAtualToolStripMenuItem.Size = new System.Drawing.Size(289, 38);
            this.estoqueAtualToolStripMenuItem.Text = "Estoque Atual";
            // 
            // históricoDeMovimentaçõesToolStripMenuItem
            // 
            this.históricoDeMovimentaçõesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.históricoDeMovimentaçõesToolStripMenuItem.Image = global::Sistema_de_Estoque.Properties.Resources.icon_fluxo_caixa;
            this.históricoDeMovimentaçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.históricoDeMovimentaçõesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.históricoDeMovimentaçõesToolStripMenuItem.Name = "históricoDeMovimentaçõesToolStripMenuItem";
            this.históricoDeMovimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(289, 38);
            this.históricoDeMovimentaçõesToolStripMenuItem.Text = "Histórico de Movimentações";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.atualizarBancoDeDadosToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3);
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarSenhaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.alterarSenhaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // atualizarBancoDeDadosToolStripMenuItem
            // 
            this.atualizarBancoDeDadosToolStripMenuItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarBancoDeDadosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.atualizarBancoDeDadosToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.atualizarBancoDeDadosToolStripMenuItem.Name = "atualizarBancoDeDadosToolStripMenuItem";
            this.atualizarBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.atualizarBancoDeDadosToolStripMenuItem.Text = "Atualizar Banco de Dados";
            // 
            // toolStrip
            // 
            this.toolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(0, 32);
            this.toolStrip.Margin = new System.Windows.Forms.Padding(10, 0, 35, 10);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.toolStrip.Size = new System.Drawing.Size(1344, 71);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::Sistema_de_Estoque.Properties.Resources.icon_saida;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 68);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 681);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.mnStrip);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_Bottom.PerformLayout();
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueAtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeMovimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
    }
}