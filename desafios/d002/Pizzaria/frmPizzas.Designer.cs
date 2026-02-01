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
            this.txtIgrediente = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageTamanhos = new System.Windows.Forms.TabPage();
            this.saborTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.SaborTableAdapter();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPizzas.SuspendLayout();
            this.tabPageSabores.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSabores)).BeginInit();
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
            this.tabPageSabores.Controls.Add(this.txtIgrediente);
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
            this.Igredientes});
            this.dtgSabores.Location = new System.Drawing.Point(4, 381);
            this.dtgSabores.Name = "dtgSabores";
            this.dtgSabores.ReadOnly = true;
            this.dtgSabores.RowHeadersVisible = false;
            this.dtgSabores.RowHeadersWidth = 51;
            this.dtgSabores.RowTemplate.Height = 24;
            this.dtgSabores.Size = new System.Drawing.Size(534, 214);
            this.dtgSabores.TabIndex = 8;
            // 
            // txtIgrediente
            // 
            this.txtIgrediente.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgrediente.Location = new System.Drawing.Point(19, 111);
            this.txtIgrediente.Multiline = true;
            this.txtIgrediente.Name = "txtIgrediente";
            this.txtIgrediente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIgrediente.Size = new System.Drawing.Size(382, 164);
            this.txtIgrediente.TabIndex = 1;
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
            this.txtCodigo.Size = new System.Drawing.Size(88, 27);
            this.txtCodigo.TabIndex = 1;
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
            this.tabPageTamanhos.Location = new System.Drawing.Point(4, 25);
            this.tabPageTamanhos.Name = "tabPageTamanhos";
            this.tabPageTamanhos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTamanhos.Size = new System.Drawing.Size(541, 600);
            this.tabPageTamanhos.TabIndex = 1;
            this.tabPageTamanhos.Text = "Tamanhos";
            this.tabPageTamanhos.UseVisualStyleBackColor = true;
            // 
            // saborTableAdapter1
            // 
            this.saborTableAdapter1.ClearBeforeFill = true;
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
            // Igredientes
            // 
            this.Igredientes.DataPropertyName = "INGREDIENTES";
            this.Igredientes.HeaderText = "INGREDIENTES";
            this.Igredientes.MinimumWidth = 6;
            this.Igredientes.Name = "Igredientes";
            this.Igredientes.ReadOnly = true;
            this.Igredientes.Width = 263;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPizzas;
        private System.Windows.Forms.TabPage tabPageSabores;
        private System.Windows.Forms.TabPage tabPageTamanhos;
        private System.Windows.Forms.TextBox txtIgrediente;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Igredientes;
    }
}