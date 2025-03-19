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
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.TabControl_Produto = new System.Windows.Forms.TabControl();
            this.Page_Inserir = new System.Windows.Forms.TabPage();
            this.cbBox_Categoria = new System.Windows.Forms.ComboBox();
            this.cbBox_Fornecedor = new System.Windows.Forms.ComboBox();
            this.txtBox_Quantidade = new System.Windows.Forms.TextBox();
            this.btn_Can = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Preco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.Page_Procurar = new System.Windows.Forms.TabPage();
            this.cbBox_pCategoria = new System.Windows.Forms.ComboBox();
            this.cbBox_pFornecedor = new System.Windows.Forms.ComboBox();
            this.txtBox_pQuantidade = new System.Windows.Forms.TextBox();
            this.btn_can2 = new System.Windows.Forms.Button();
            this.btn_EditaAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_pPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_pNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_pID = new System.Windows.Forms.TextBox();
            this.pnl_Top.SuspendLayout();
            this.TabControl_Produto.SuspendLayout();
            this.Page_Inserir.SuspendLayout();
            this.Page_Procurar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Top.Controls.Add(this.btn_Deletar);
            this.pnl_Top.Controls.Add(this.btn_Editar);
            this.pnl_Top.Controls.Add(this.btn_Procurar);
            this.pnl_Top.Controls.Add(this.btn_Inserir);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(554, 64);
            this.pnl_Top.TabIndex = 0;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Enabled = false;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Deletar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Deletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Deletar.Location = new System.Drawing.Point(195, 6);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(55, 55);
            this.btn_Deletar.TabIndex = 4;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Editar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Editar.Location = new System.Drawing.Point(134, 6);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(55, 55);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Procurar.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Procurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Procurar.Location = new System.Drawing.Point(73, 6);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(55, 55);
            this.btn_Procurar.TabIndex = 2;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Procurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Procurar.UseVisualStyleBackColor = true;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Inserir.Image = global::Sistema_de_Estoque.Properties.Resources.icon_addUser;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Inserir.Location = new System.Drawing.Point(12, 6);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(55, 55);
            this.btn_Inserir.TabIndex = 1;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Inserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // TabControl_Produto
            // 
            this.TabControl_Produto.Controls.Add(this.Page_Inserir);
            this.TabControl_Produto.Controls.Add(this.Page_Procurar);
            this.TabControl_Produto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl_Produto.Enabled = false;
            this.TabControl_Produto.Location = new System.Drawing.Point(0, 64);
            this.TabControl_Produto.Name = "TabControl_Produto";
            this.TabControl_Produto.SelectedIndex = 0;
            this.TabControl_Produto.Size = new System.Drawing.Size(554, 247);
            this.TabControl_Produto.TabIndex = 1;
            // 
            // Page_Inserir
            // 
            this.Page_Inserir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Page_Inserir.Controls.Add(this.cbBox_Categoria);
            this.Page_Inserir.Controls.Add(this.cbBox_Fornecedor);
            this.Page_Inserir.Controls.Add(this.txtBox_Quantidade);
            this.Page_Inserir.Controls.Add(this.btn_Can);
            this.Page_Inserir.Controls.Add(this.btn_Add);
            this.Page_Inserir.Controls.Add(this.label6);
            this.Page_Inserir.Controls.Add(this.txtBox_Preco);
            this.Page_Inserir.Controls.Add(this.label5);
            this.Page_Inserir.Controls.Add(this.label4);
            this.Page_Inserir.Controls.Add(this.label3);
            this.Page_Inserir.Controls.Add(this.label2);
            this.Page_Inserir.Controls.Add(this.txtBox_Nome);
            this.Page_Inserir.Controls.Add(this.label1);
            this.Page_Inserir.Controls.Add(this.txtBox_ID);
            this.Page_Inserir.Location = new System.Drawing.Point(4, 22);
            this.Page_Inserir.Name = "Page_Inserir";
            this.Page_Inserir.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Inserir.Size = new System.Drawing.Size(546, 221);
            this.Page_Inserir.TabIndex = 0;
            // 
            // cbBox_Categoria
            // 
            this.cbBox_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cbBox_Categoria.FormattingEnabled = true;
            this.cbBox_Categoria.Location = new System.Drawing.Point(313, 36);
            this.cbBox_Categoria.Name = "cbBox_Categoria";
            this.cbBox_Categoria.Size = new System.Drawing.Size(159, 24);
            this.cbBox_Categoria.TabIndex = 16;
            // 
            // cbBox_Fornecedor
            // 
            this.cbBox_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cbBox_Fornecedor.FormattingEnabled = true;
            this.cbBox_Fornecedor.Location = new System.Drawing.Point(11, 110);
            this.cbBox_Fornecedor.Name = "cbBox_Fornecedor";
            this.cbBox_Fornecedor.Size = new System.Drawing.Size(141, 24);
            this.cbBox_Fornecedor.TabIndex = 15;
            // 
            // txtBox_Quantidade
            // 
            this.txtBox_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Quantidade.Location = new System.Drawing.Point(208, 112);
            this.txtBox_Quantidade.Name = "txtBox_Quantidade";
            this.txtBox_Quantidade.Size = new System.Drawing.Size(75, 22);
            this.txtBox_Quantidade.TabIndex = 14;
            // 
            // btn_Can
            // 
            this.btn_Can.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Can.Image = global::Sistema_de_Estoque.Properties.Resources.icon_Cancelar;
            this.btn_Can.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Can.Location = new System.Drawing.Point(498, 175);
            this.btn_Can.Name = "btn_Can";
            this.btn_Can.Size = new System.Drawing.Size(40, 40);
            this.btn_Can.TabIndex = 13;
            this.btn_Can.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Can.UseVisualStyleBackColor = true;
            this.btn_Can.Click += new System.EventHandler(this.btn_Can_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_Add.Image = global::Sistema_de_Estoque.Properties.Resources.icon_add;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Add.Location = new System.Drawing.Point(446, 175);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.InserirAdd);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label6.Location = new System.Drawing.Point(310, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço";
            // 
            // txtBox_Preco
            // 
            this.txtBox_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Preco.Location = new System.Drawing.Point(313, 112);
            this.txtBox_Preco.Name = "txtBox_Preco";
            this.txtBox_Preco.Size = new System.Drawing.Size(82, 22);
            this.txtBox_Preco.TabIndex = 10;
            this.txtBox_Preco.Tag = "";
            this.txtBox_Preco.Leave += new System.EventHandler(this.txtBox_Preco_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label5.Location = new System.Drawing.Point(205, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label3.Location = new System.Drawing.Point(310, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label2.Location = new System.Drawing.Point(93, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome(Produto)";
            // 
            // txtBox_Nome
            // 
            this.txtBox_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_Nome.Location = new System.Drawing.Point(96, 36);
            this.txtBox_Nome.Name = "txtBox_Nome";
            this.txtBox_Nome.Size = new System.Drawing.Size(187, 22);
            this.txtBox_Nome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Enabled = false;
            this.txtBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_ID.Location = new System.Drawing.Point(11, 36);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.Size = new System.Drawing.Size(55, 22);
            this.txtBox_ID.TabIndex = 0;
            // 
            // Page_Procurar
            // 
            this.Page_Procurar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Page_Procurar.Controls.Add(this.cbBox_pCategoria);
            this.Page_Procurar.Controls.Add(this.cbBox_pFornecedor);
            this.Page_Procurar.Controls.Add(this.txtBox_pQuantidade);
            this.Page_Procurar.Controls.Add(this.btn_can2);
            this.Page_Procurar.Controls.Add(this.btn_EditaAdd);
            this.Page_Procurar.Controls.Add(this.label7);
            this.Page_Procurar.Controls.Add(this.txtBox_pPreco);
            this.Page_Procurar.Controls.Add(this.label8);
            this.Page_Procurar.Controls.Add(this.label9);
            this.Page_Procurar.Controls.Add(this.label10);
            this.Page_Procurar.Controls.Add(this.label11);
            this.Page_Procurar.Controls.Add(this.txtBox_pNome);
            this.Page_Procurar.Controls.Add(this.label12);
            this.Page_Procurar.Controls.Add(this.txtBox_pID);
            this.Page_Procurar.Location = new System.Drawing.Point(4, 22);
            this.Page_Procurar.Name = "Page_Procurar";
            this.Page_Procurar.Padding = new System.Windows.Forms.Padding(3);
            this.Page_Procurar.Size = new System.Drawing.Size(546, 221);
            this.Page_Procurar.TabIndex = 1;
            // 
            // cbBox_pCategoria
            // 
            this.cbBox_pCategoria.Enabled = false;
            this.cbBox_pCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cbBox_pCategoria.FormattingEnabled = true;
            this.cbBox_pCategoria.Location = new System.Drawing.Point(313, 34);
            this.cbBox_pCategoria.Name = "cbBox_pCategoria";
            this.cbBox_pCategoria.Size = new System.Drawing.Size(159, 24);
            this.cbBox_pCategoria.TabIndex = 30;
            // 
            // cbBox_pFornecedor
            // 
            this.cbBox_pFornecedor.Enabled = false;
            this.cbBox_pFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cbBox_pFornecedor.FormattingEnabled = true;
            this.cbBox_pFornecedor.Location = new System.Drawing.Point(11, 108);
            this.cbBox_pFornecedor.Name = "cbBox_pFornecedor";
            this.cbBox_pFornecedor.Size = new System.Drawing.Size(141, 24);
            this.cbBox_pFornecedor.TabIndex = 29;
            // 
            // txtBox_pQuantidade
            // 
            this.txtBox_pQuantidade.Enabled = false;
            this.txtBox_pQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pQuantidade.Location = new System.Drawing.Point(208, 110);
            this.txtBox_pQuantidade.Name = "txtBox_pQuantidade";
            this.txtBox_pQuantidade.Size = new System.Drawing.Size(75, 22);
            this.txtBox_pQuantidade.TabIndex = 28;
            // 
            // btn_can2
            // 
            this.btn_can2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_can2.Image = global::Sistema_de_Estoque.Properties.Resources.icon_Cancelar;
            this.btn_can2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_can2.Location = new System.Drawing.Point(498, 173);
            this.btn_can2.Name = "btn_can2";
            this.btn_can2.Size = new System.Drawing.Size(40, 42);
            this.btn_can2.TabIndex = 27;
            this.btn_can2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_can2.UseVisualStyleBackColor = true;
            this.btn_can2.Click += new System.EventHandler(this.btn_can2_Click);
            // 
            // btn_EditaAdd
            // 
            this.btn_EditaAdd.Enabled = false;
            this.btn_EditaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.btn_EditaAdd.Image = global::Sistema_de_Estoque.Properties.Resources.icon_add;
            this.btn_EditaAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_EditaAdd.Location = new System.Drawing.Point(446, 173);
            this.btn_EditaAdd.Name = "btn_EditaAdd";
            this.btn_EditaAdd.Size = new System.Drawing.Size(40, 42);
            this.btn_EditaAdd.TabIndex = 26;
            this.btn_EditaAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_EditaAdd.UseVisualStyleBackColor = true;
            this.btn_EditaAdd.Click += new System.EventHandler(this.btn_EditaAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label7.Location = new System.Drawing.Point(310, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Preço";
            // 
            // txtBox_pPreco
            // 
            this.txtBox_pPreco.Enabled = false;
            this.txtBox_pPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pPreco.Location = new System.Drawing.Point(313, 110);
            this.txtBox_pPreco.Name = "txtBox_pPreco";
            this.txtBox_pPreco.Size = new System.Drawing.Size(82, 22);
            this.txtBox_pPreco.TabIndex = 24;
            this.txtBox_pPreco.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label8.Location = new System.Drawing.Point(205, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label9.Location = new System.Drawing.Point(8, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fornecedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label10.Location = new System.Drawing.Point(310, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Categoria";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label11.Location = new System.Drawing.Point(93, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nome(Produto)";
            // 
            // txtBox_pNome
            // 
            this.txtBox_pNome.Enabled = false;
            this.txtBox_pNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pNome.Location = new System.Drawing.Point(96, 34);
            this.txtBox_pNome.Name = "txtBox_pNome";
            this.txtBox_pNome.Size = new System.Drawing.Size(187, 22);
            this.txtBox_pNome.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label12.Location = new System.Drawing.Point(8, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "ID";
            // 
            // txtBox_pID
            // 
            this.txtBox_pID.Enabled = false;
            this.txtBox_pID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtBox_pID.Location = new System.Drawing.Point(11, 34);
            this.txtBox_pID.Name = "txtBox_pID";
            this.txtBox_pID.Size = new System.Drawing.Size(55, 22);
            this.txtBox_pID.TabIndex = 17;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(554, 311);
            this.Controls.Add(this.TabControl_Produto);
            this.Controls.Add(this.pnl_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.pnl_Top.ResumeLayout(false);
            this.TabControl_Produto.ResumeLayout(false);
            this.Page_Inserir.ResumeLayout(false);
            this.Page_Inserir.PerformLayout();
            this.Page_Procurar.ResumeLayout(false);
            this.Page_Procurar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TabControl TabControl_Produto;
        private System.Windows.Forms.TabPage Page_Inserir;
        private System.Windows.Forms.TabPage Page_Procurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_Preco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Nome;
        private System.Windows.Forms.Button btn_Can;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtBox_Quantidade;
        private System.Windows.Forms.ComboBox cbBox_Fornecedor;
        private System.Windows.Forms.ComboBox cbBox_Categoria;
        private System.Windows.Forms.ComboBox cbBox_pCategoria;
        private System.Windows.Forms.ComboBox cbBox_pFornecedor;
        private System.Windows.Forms.TextBox txtBox_pQuantidade;
        private System.Windows.Forms.Button btn_can2;
        private System.Windows.Forms.Button btn_EditaAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_pPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_pNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_pID;
    }
}