namespace Academia
{
    partial class ucModalidades
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtMensalidade = new TextBox();
            txtNome = new TextBox();
            rbModalidade = new RadioButton();
            rbProfessor = new RadioButton();
            txtPesquisa = new TextBox();
            cboProfessor = new ComboBox();
            txtCod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSalvar = new ToolStripButton();
            btnAdicionar = new ToolStripButton();
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            dtgModalidades = new DataGridView();
            ID_MODALIDADE = new DataGridViewTextBoxColumn();
            NOME_MODALIDADE = new DataGridViewTextBoxColumn();
            NOME_PROFESSOR = new DataGridViewTextBoxColumn();
            MENSALIDADE = new DataGridViewTextBoxColumn();
            ID_PROFESSOR = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgModalidades).BeginInit();
            SuspendLayout();
            // 
            // txtMensalidade
            // 
            txtMensalidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMensalidade.Location = new Point(482, 54);
            txtMensalidade.Name = "txtMensalidade";
            txtMensalidade.Size = new Size(119, 27);
            txtMensalidade.TabIndex = 13;
            txtMensalidade.Tag = "MENSALIDADE";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(118, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(483, 27);
            txtNome.TabIndex = 6;
            txtNome.Tag = "NOME_MODALIDADE";
            // 
            // rbModalidade
            // 
            rbModalidade.AutoSize = true;
            rbModalidade.Checked = true;
            rbModalidade.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbModalidade.Location = new Point(6, 78);
            rbModalidade.Name = "rbModalidade";
            rbModalidade.Size = new Size(102, 21);
            rbModalidade.TabIndex = 5;
            rbModalidade.TabStop = true;
            rbModalidade.Text = "Modalidade";
            rbModalidade.UseVisualStyleBackColor = true;
            // 
            // rbProfessor
            // 
            rbProfessor.AutoSize = true;
            rbProfessor.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbProfessor.Location = new Point(114, 78);
            rbProfessor.Name = "rbProfessor";
            rbProfessor.Size = new Size(93, 21);
            rbProfessor.TabIndex = 5;
            rbProfessor.Text = "Professor";
            rbProfessor.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(6, 36);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(517, 27);
            txtPesquisa.TabIndex = 2;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // cboProfessor
            // 
            cboProfessor.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProfessor.FormattingEnabled = true;
            cboProfessor.Location = new Point(118, 122);
            cboProfessor.Name = "cboProfessor";
            cboProfessor.Size = new Size(483, 27);
            cboProfessor.TabIndex = 8;
            cboProfessor.Tag = "NOME_PROFESSOR";
            cboProfessor.Enter += cboProfessor_Enter;
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCod.Location = new Point(118, 54);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(90, 27);
            txtCod.TabIndex = 14;
            txtCod.TabStop = false;
            txtCod.Tag = "ID_MODALIDADE";
            txtCod.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(349, 57);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 9;
            label4.Text = "Mensalidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 10;
            label3.Text = "Professor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 91);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 11;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 57);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 12;
            label1.Text = "Código:";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.salvar;
            btnSalvar.ImageScaling = ToolStripItemImageScaling.None;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 36);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.adicionar;
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(109, 36);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbModalidade);
            groupBox1.Controls.Add(rbProfessor);
            groupBox1.Controls.Add(txtPesquisa);
            groupBox1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 110);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnSalvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(619, 39);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // dtgModalidades
            // 
            dtgModalidades.AllowUserToAddRows = false;
            dtgModalidades.AllowUserToDeleteRows = false;
            dtgModalidades.AllowUserToResizeColumns = false;
            dtgModalidades.AllowUserToResizeRows = false;
            dtgModalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgModalidades.Columns.AddRange(new DataGridViewColumn[] { ID_MODALIDADE, NOME_MODALIDADE, NOME_PROFESSOR, MENSALIDADE, ID_PROFESSOR, btnEditar, btnExcluir });
            dtgModalidades.Location = new Point(13, 285);
            dtgModalidades.Name = "dtgModalidades";
            dtgModalidades.ReadOnly = true;
            dtgModalidades.RowHeadersVisible = false;
            dtgModalidades.RowHeadersWidth = 51;
            dtgModalidades.Size = new Size(593, 316);
            dtgModalidades.TabIndex = 17;
            dtgModalidades.TabStop = false;
            dtgModalidades.CellContentClick += dtgModalidades_CellContentClick;
            // 
            // ID_MODALIDADE
            // 
            ID_MODALIDADE.DataPropertyName = "ID_MODALIDADE";
            ID_MODALIDADE.HeaderText = "CÓDIGO";
            ID_MODALIDADE.MinimumWidth = 6;
            ID_MODALIDADE.Name = "ID_MODALIDADE";
            ID_MODALIDADE.ReadOnly = true;
            ID_MODALIDADE.Visible = false;
            ID_MODALIDADE.Width = 75;
            // 
            // NOME_MODALIDADE
            // 
            NOME_MODALIDADE.DataPropertyName = "NOME_MODALIDADE";
            NOME_MODALIDADE.HeaderText = "NOME";
            NOME_MODALIDADE.MinimumWidth = 6;
            NOME_MODALIDADE.Name = "NOME_MODALIDADE";
            NOME_MODALIDADE.ReadOnly = true;
            NOME_MODALIDADE.Width = 200;
            // 
            // NOME_PROFESSOR
            // 
            NOME_PROFESSOR.DataPropertyName = "NOME_PROFESSOR";
            NOME_PROFESSOR.HeaderText = "PROFESSOR";
            NOME_PROFESSOR.MinimumWidth = 6;
            NOME_PROFESSOR.Name = "NOME_PROFESSOR";
            NOME_PROFESSOR.ReadOnly = true;
            NOME_PROFESSOR.Width = 200;
            // 
            // MENSALIDADE
            // 
            MENSALIDADE.DataPropertyName = "MENSALIDADE";
            MENSALIDADE.HeaderText = "MENSALIDADE";
            MENSALIDADE.MinimumWidth = 6;
            MENSALIDADE.Name = "MENSALIDADE";
            MENSALIDADE.ReadOnly = true;
            MENSALIDADE.Width = 118;
            // 
            // ID_PROFESSOR
            // 
            ID_PROFESSOR.DataPropertyName = "ID_PROFESSOR";
            ID_PROFESSOR.HeaderText = "ID_PROFESSOR";
            ID_PROFESSOR.MinimumWidth = 6;
            ID_PROFESSOR.Name = "ID_PROFESSOR";
            ID_PROFESSOR.ReadOnly = true;
            ID_PROFESSOR.Visible = false;
            ID_PROFESSOR.Width = 125;
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "";
            btnEditar.Image = Properties.Resources.dtgEditar;
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Resizable = DataGridViewTriState.True;
            btnEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEditar.Width = 36;
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "";
            btnExcluir.Image = Properties.Resources.dtgExcluir;
            btnExcluir.MinimumWidth = 6;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ReadOnly = true;
            btnExcluir.Resizable = DataGridViewTriState.True;
            btnExcluir.SortMode = DataGridViewColumnSortMode.Automatic;
            btnExcluir.Width = 36;
            // 
            // ucModalidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgModalidades);
            Controls.Add(txtMensalidade);
            Controls.Add(txtNome);
            Controls.Add(cboProfessor);
            Controls.Add(txtCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Name = "ucModalidades";
            Size = new Size(619, 605);
            Load += ucModalidades_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgModalidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMensalidade;
        private TextBox txtNome;
        private RadioButton rbModalidade;
        private RadioButton rbProfessor;
        private TextBox txtPesquisa;
        private ComboBox cboProfessor;
        private TextBox txtCod;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripButton btnSalvar;
        private ToolStripButton btnAdicionar;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private DataGridView dtgModalidades;
        private DataGridViewTextBoxColumn ID_MODALIDADE;
        private DataGridViewTextBoxColumn NOME_MODALIDADE;
        private DataGridViewTextBoxColumn NOME_PROFESSOR;
        private DataGridViewTextBoxColumn MENSALIDADE;
        private DataGridViewTextBoxColumn ID_PROFESSOR;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnExcluir;
    }
}
