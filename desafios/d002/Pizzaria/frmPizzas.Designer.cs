namespace Pizzaria
{
    partial class frmPizzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzas));
            this.tabPizzas = new System.Windows.Forms.TabControl();
            this.tabPageSabores = new System.Windows.Forms.TabPage();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgSabores = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTamanhos = new System.Windows.Forms.TabPage();
            this.btnExcluirTamanho = new System.Windows.Forms.Button();
            this.btnSalvarTamanho = new System.Windows.Forms.Button();
            this.btnNovoTamanho = new System.Windows.Forms.Button();
            this.dtgTamanhos = new System.Windows.Forms.DataGridView();
            this.Codigo_tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValorTamanho = new System.Windows.Forms.TextBox();
            this.txtNomeTamanho = new System.Windows.Forms.TextBox();
            this.txtCodigoTamanho = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saborTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.SaborTableAdapter();
            this.tamanhoTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.TamanhoTableAdapter();
            this.tabPizzas.SuspendLayout();
            this.tabPageSabores.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSabores)).BeginInit();
            this.tabPageTamanhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTamanhos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPizzas
            // 
            this.tabPizzas.Controls.Add(this.tabPageSabores);
            this.tabPizzas.Controls.Add(this.tabPageTamanhos);
            this.tabPizzas.Location = new System.Drawing.Point(3, 12);
            this.tabPizzas.Name = "tabPizzas";
            this.tabPizzas.SelectedIndex = 0;
            this.tabPizzas.Size = new System.Drawing.Size(549, 629);
            this.tabPizzas.TabIndex = 0;
            // 
            // tabPageSabores
            // 
            this.tabPageSabores.Controls.Add(this.gbPesquisa);
            this.tabPageSabores.Controls.Add(this.btnSalvar);
            this.tabPageSabores.Controls.Add(this.btnExcluir);
            this.tabPageSabores.Controls.Add(this.btnNovo);
            this.tabPageSabores.Controls.Add(this.dtgSabores);
            this.tabPageSabores.Controls.Add(this.txtIngrediente);
            this.tabPageSabores.Controls.Add(this.txtNome);
            this.tabPageSabores.Controls.Add(this.txtCodigo);
            this.tabPageSabores.Controls.Add(this.label3);
            this.tabPageSabores.Controls.Add(this.label2);
            this.tabPageSabores.Controls.Add(this.label1);
            this.tabPageSabores.Location = new System.Drawing.Point(4, 25);
            this.tabPageSabores.Name = "tabPageSabores";
            this.tabPageSabores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSabores.Size = new System.Drawing.Size(541, 600);
            this.tabPageSabores.TabIndex = 0;
            this.tabPageSabores.Text = "Sabores";
            this.tabPageSabores.UseVisualStyleBackColor = true;
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Controls.Add(this.txtPesquisa);
            this.gbPesquisa.Controls.Add(this.btnPesquisa);
            this.gbPesquisa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisa.Location = new System.Drawing.Point(19, 290);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(516, 71);
            this.gbPesquisa.TabIndex = 10;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(10, 27);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(372, 27);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Image = global::Pizzaria.Properties.Resources.lupa_maior;
            this.btnPesquisa.Location = new System.Drawing.Point(405, 18);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(97, 46);
            this.btnPesquisa.TabIndex = 9;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Pizzaria.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(421, 126);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 65);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::Pizzaria.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(421, 210);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 65);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::Pizzaria.Properties.Resources.adicionar;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(421, 42);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 65);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtgSabores
            // 
            this.dtgSabores.AllowUserToAddRows = false;
            this.dtgSabores.AllowUserToDeleteRows = false;
            this.dtgSabores.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgSabores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSabores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Ingredientes});
            this.dtgSabores.Location = new System.Drawing.Point(4, 381);
            this.dtgSabores.Name = "dtgSabores";
            this.dtgSabores.ReadOnly = true;
            this.dtgSabores.RowHeadersVisible = false;
            this.dtgSabores.RowHeadersWidth = 51;
            this.dtgSabores.RowTemplate.Height = 24;
            this.dtgSabores.Size = new System.Drawing.Size(534, 214);
            this.dtgSabores.TabIndex = 8;
            this.dtgSabores.DoubleClick += new System.EventHandler(this.dtgSabores_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "ID_SABOR";
            this.Codigo.HeaderText = "CÓDIGO";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 68;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NOME_SABOR";
            this.Nome.HeaderText = "NOME";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Ingredientes
            // 
            this.Ingredientes.DataPropertyName = "INGREDIENTES";
            this.Ingredientes.HeaderText = "INGREDIENTES";
            this.Ingredientes.MinimumWidth = 6;
            this.Ingredientes.Name = "Ingredientes";
            this.Ingredientes.ReadOnly = true;
            this.Ingredientes.Width = 263;
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente.Location = new System.Drawing.Point(19, 111);
            this.txtIngrediente.Multiline = true;
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIngrediente.Size = new System.Drawing.Size(382, 164);
            this.txtIngrediente.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(100, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 27);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(100, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(88, 27);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Tag = "zero";
            this.txtCodigo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingredientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tabPageTamanhos
            // 
            this.tabPageTamanhos.Controls.Add(this.btnExcluirTamanho);
            this.tabPageTamanhos.Controls.Add(this.btnSalvarTamanho);
            this.tabPageTamanhos.Controls.Add(this.btnNovoTamanho);
            this.tabPageTamanhos.Controls.Add(this.dtgTamanhos);
            this.tabPageTamanhos.Controls.Add(this.txtValorTamanho);
            this.tabPageTamanhos.Controls.Add(this.txtNomeTamanho);
            this.tabPageTamanhos.Controls.Add(this.txtCodigoTamanho);
            this.tabPageTamanhos.Controls.Add(this.label6);
            this.tabPageTamanhos.Controls.Add(this.label5);
            this.tabPageTamanhos.Controls.Add(this.label4);
            this.tabPageTamanhos.Location = new System.Drawing.Point(4, 25);
            this.tabPageTamanhos.Name = "tabPageTamanhos";
            this.tabPageTamanhos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTamanhos.Size = new System.Drawing.Size(541, 600);
            this.tabPageTamanhos.TabIndex = 1;
            this.tabPageTamanhos.Text = "Tamanhos";
            this.tabPageTamanhos.UseVisualStyleBackColor = true;
            // 
            // btnExcluirTamanho
            // 
            this.btnExcluirTamanho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTamanho.Image = global::Pizzaria.Properties.Resources.excluir_24px;
            this.btnExcluirTamanho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirTamanho.Location = new System.Drawing.Point(394, 119);
            this.btnExcluirTamanho.Name = "btnExcluirTamanho";
            this.btnExcluirTamanho.Size = new System.Drawing.Size(120, 45);
            this.btnExcluirTamanho.TabIndex = 12;
            this.btnExcluirTamanho.Text = "Excluir";
            this.btnExcluirTamanho.UseVisualStyleBackColor = true;
            this.btnExcluirTamanho.Click += new System.EventHandler(this.btnExcluirTamanho_Click);
            // 
            // btnSalvarTamanho
            // 
            this.btnSalvarTamanho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTamanho.Image = global::Pizzaria.Properties.Resources.salvar_24px;
            this.btnSalvarTamanho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarTamanho.Location = new System.Drawing.Point(394, 67);
            this.btnSalvarTamanho.Name = "btnSalvarTamanho";
            this.btnSalvarTamanho.Size = new System.Drawing.Size(120, 45);
            this.btnSalvarTamanho.TabIndex = 11;
            this.btnSalvarTamanho.Text = "Salvar";
            this.btnSalvarTamanho.UseVisualStyleBackColor = true;
            this.btnSalvarTamanho.Click += new System.EventHandler(this.btnSalvarTamanho_Click);
            // 
            // btnNovoTamanho
            // 
            this.btnNovoTamanho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoTamanho.Image = global::Pizzaria.Properties.Resources.adicionar_24px;
            this.btnNovoTamanho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoTamanho.Location = new System.Drawing.Point(394, 14);
            this.btnNovoTamanho.Name = "btnNovoTamanho";
            this.btnNovoTamanho.Size = new System.Drawing.Size(120, 46);
            this.btnNovoTamanho.TabIndex = 10;
            this.btnNovoTamanho.Text = "Novo";
            this.btnNovoTamanho.UseVisualStyleBackColor = true;
            this.btnNovoTamanho.Click += new System.EventHandler(this.btnNovoTamanho_Click);
            // 
            // dtgTamanhos
            // 
            this.dtgTamanhos.AllowUserToAddRows = false;
            this.dtgTamanhos.AllowUserToDeleteRows = false;
            this.dtgTamanhos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgTamanhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTamanhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_tamanho,
            this.Nome_Tamanho,
            this.Valor});
            this.dtgTamanhos.Location = new System.Drawing.Point(3, 180);
            this.dtgTamanhos.Name = "dtgTamanhos";
            this.dtgTamanhos.ReadOnly = true;
            this.dtgTamanhos.RowHeadersVisible = false;
            this.dtgTamanhos.RowHeadersWidth = 51;
            this.dtgTamanhos.RowTemplate.Height = 24;
            this.dtgTamanhos.Size = new System.Drawing.Size(534, 416);
            this.dtgTamanhos.TabIndex = 9;
            this.dtgTamanhos.DoubleClick += new System.EventHandler(this.dtgTamanhos_DoubleClick);
            // 
            // Codigo_tamanho
            // 
            this.Codigo_tamanho.DataPropertyName = "ID_TAMANHO";
            this.Codigo_tamanho.HeaderText = "CÓDIGO";
            this.Codigo_tamanho.MinimumWidth = 6;
            this.Codigo_tamanho.Name = "Codigo_tamanho";
            this.Codigo_tamanho.ReadOnly = true;
            this.Codigo_tamanho.Width = 68;
            // 
            // Nome_Tamanho
            // 
            this.Nome_Tamanho.DataPropertyName = "NOME_TAMANHO";
            this.Nome_Tamanho.HeaderText = "NOME";
            this.Nome_Tamanho.MinimumWidth = 6;
            this.Nome_Tamanho.Name = "Nome_Tamanho";
            this.Nome_Tamanho.ReadOnly = true;
            this.Nome_Tamanho.Width = 200;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "VALOR";
            this.Valor.HeaderText = "VALOR";
            this.Valor.MinimumWidth = 6;
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 263;
            // 
            // txtValorTamanho
            // 
            this.txtValorTamanho.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTamanho.Location = new System.Drawing.Point(91, 87);
            this.txtValorTamanho.Name = "txtValorTamanho";
            this.txtValorTamanho.Size = new System.Drawing.Size(88, 27);
            this.txtValorTamanho.TabIndex = 2;
            // 
            // txtNomeTamanho
            // 
            this.txtNomeTamanho.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTamanho.Location = new System.Drawing.Point(91, 52);
            this.txtNomeTamanho.Name = "txtNomeTamanho";
            this.txtNomeTamanho.Size = new System.Drawing.Size(278, 27);
            this.txtNomeTamanho.TabIndex = 2;
            // 
            // txtCodigoTamanho
            // 
            this.txtCodigoTamanho.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTamanho.Location = new System.Drawing.Point(91, 14);
            this.txtCodigoTamanho.Name = "txtCodigoTamanho";
            this.txtCodigoTamanho.Size = new System.Drawing.Size(88, 27);
            this.txtCodigoTamanho.TabIndex = 2;
            this.txtCodigoTamanho.Tag = "zero";
            this.txtCodigoTamanho.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código:";
            // 
            // saborTableAdapter1
            // 
            this.saborTableAdapter1.ClearBeforeFill = true;
            // 
            // tamanhoTableAdapter1
            // 
            this.tamanhoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 645);
            this.Controls.Add(this.tabPizzas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPizzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Pizzas";
            this.Load += new System.EventHandler(this.frmPizzas_Load);
            this.tabPizzas.ResumeLayout(false);
            this.tabPageSabores.ResumeLayout(false);
            this.tabPageSabores.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSabores)).EndInit();
            this.tabPageTamanhos.ResumeLayout(false);
            this.tabPageTamanhos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTamanhos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPizzas;
        private System.Windows.Forms.TabPage tabPageSabores;
        private System.Windows.Forms.TabPage tabPageTamanhos;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgSabores;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gbPesquisa;
        private PizzariaDataSetTableAdapters.SaborTableAdapter saborTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgTamanhos;
        private System.Windows.Forms.TextBox txtValorTamanho;
        private System.Windows.Forms.TextBox txtNomeTamanho;
        private System.Windows.Forms.TextBox txtCodigoTamanho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcluirTamanho;
        private System.Windows.Forms.Button btnSalvarTamanho;
        private System.Windows.Forms.Button btnNovoTamanho;
        private PizzariaDataSetTableAdapters.TamanhoTableAdapter tamanhoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}