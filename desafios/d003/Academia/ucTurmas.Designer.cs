namespace Academia
{
    partial class ucTurmas
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
            btnHora = new DataGridViewImageColumn();
            btnEditar = new DataGridViewImageColumn();
            VAGAS = new DataGridViewTextBoxColumn();
            MAXIMO_ALUNOS = new DataGridViewTextBoxColumn();
            NOME_MODALIDADE = new DataGridViewTextBoxColumn();
            NUMERO_TURMA = new DataGridViewTextBoxColumn();
            ID_MODALIDADE = new DataGridViewTextBoxColumn();
            ID_TURMA = new DataGridViewTextBoxColumn();
            dtgTurmas = new DataGridView();
            btnExcluir = new DataGridViewImageColumn();
            lblMensagem = new Label();
            lblTitulo = new Label();
            FIM = new DataGridViewTextBoxColumn();
            INICIO = new DataGridViewTextBoxColumn();
            SEMANA_NOME = new DataGridViewTextBoxColumn();
            DIA_SEMANA = new DataGridViewTextBoxColumn();
            ID_TURMA1 = new DataGridViewTextBoxColumn();
            ID_HORARIO = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnSalvar = new ToolStripButton();
            panel1 = new Panel();
            cboModalidade = new ComboBox();
            txtAluno = new TextBox();
            txtTurma = new TextBox();
            txtCod = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtPesquisa = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgHorarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgTurmas).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHorarios).BeginInit();
            SuspendLayout();
            // 
            // btnHora
            // 
            btnHora.HeaderText = "";
            btnHora.Image = Properties.Resources.dtgHora;
            btnHora.MinimumWidth = 6;
            btnHora.Name = "btnHora";
            btnHora.ReadOnly = true;
            btnHora.Width = 36;
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
            // VAGAS
            // 
            VAGAS.DataPropertyName = "VAGAS";
            VAGAS.HeaderText = "VAGAS";
            VAGAS.MinimumWidth = 6;
            VAGAS.Name = "VAGAS";
            VAGAS.ReadOnly = true;
            VAGAS.Width = 125;
            // 
            // MAXIMO_ALUNOS
            // 
            MAXIMO_ALUNOS.DataPropertyName = "MAXIMO_ALUNOS";
            MAXIMO_ALUNOS.HeaderText = "MÁXIMO DE ALUNOS";
            MAXIMO_ALUNOS.MinimumWidth = 6;
            MAXIMO_ALUNOS.Name = "MAXIMO_ALUNOS";
            MAXIMO_ALUNOS.ReadOnly = true;
            MAXIMO_ALUNOS.Width = 200;
            // 
            // NOME_MODALIDADE
            // 
            NOME_MODALIDADE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NOME_MODALIDADE.DataPropertyName = "NOME_MODALIDADE";
            NOME_MODALIDADE.HeaderText = "MODALIDADE";
            NOME_MODALIDADE.MinimumWidth = 6;
            NOME_MODALIDADE.Name = "NOME_MODALIDADE";
            NOME_MODALIDADE.ReadOnly = true;
            // 
            // NUMERO_TURMA
            // 
            NUMERO_TURMA.DataPropertyName = "NUMERO_TURMA";
            NUMERO_TURMA.HeaderText = "TURMA";
            NUMERO_TURMA.MinimumWidth = 6;
            NUMERO_TURMA.Name = "NUMERO_TURMA";
            NUMERO_TURMA.ReadOnly = true;
            NUMERO_TURMA.Width = 125;
            // 
            // ID_MODALIDADE
            // 
            ID_MODALIDADE.DataPropertyName = "ID_MODALIDADE";
            ID_MODALIDADE.HeaderText = "ID_MODALIDADE";
            ID_MODALIDADE.MinimumWidth = 6;
            ID_MODALIDADE.Name = "ID_MODALIDADE";
            ID_MODALIDADE.ReadOnly = true;
            ID_MODALIDADE.Visible = false;
            ID_MODALIDADE.Width = 125;
            // 
            // ID_TURMA
            // 
            ID_TURMA.DataPropertyName = "ID_TURMA";
            ID_TURMA.HeaderText = "ID_TURMA";
            ID_TURMA.MinimumWidth = 6;
            ID_TURMA.Name = "ID_TURMA";
            ID_TURMA.ReadOnly = true;
            ID_TURMA.Visible = false;
            ID_TURMA.Width = 125;
            // 
            // dtgTurmas
            // 
            dtgTurmas.AllowUserToAddRows = false;
            dtgTurmas.AllowUserToDeleteRows = false;
            dtgTurmas.AllowUserToResizeColumns = false;
            dtgTurmas.AllowUserToResizeRows = false;
            dtgTurmas.ColumnHeadersHeight = 29;
            dtgTurmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgTurmas.Columns.AddRange(new DataGridViewColumn[] { ID_TURMA, ID_MODALIDADE, NUMERO_TURMA, NOME_MODALIDADE, MAXIMO_ALUNOS, VAGAS, btnEditar, btnExcluir, btnHora });
            dtgTurmas.EnableHeadersVisualStyles = false;
            dtgTurmas.Location = new Point(13, 306);
            dtgTurmas.Name = "dtgTurmas";
            dtgTurmas.ReadOnly = true;
            dtgTurmas.RowHeadersVisible = false;
            dtgTurmas.RowHeadersWidth = 51;
            dtgTurmas.Size = new Size(802, 351);
            dtgTurmas.TabIndex = 12;
            dtgTurmas.TabStop = false;
            dtgTurmas.CellContentClick += dtgTurmas_CellContentClick;
            dtgTurmas.CellDoubleClick += dtgTurmas_CellDoubleClick;
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
            // lblMensagem
            // 
            lblMensagem.BackColor = SystemColors.ControlDark;
            lblMensagem.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.FromArgb(192, 0, 0);
            lblMensagem.Location = new Point(418, 170);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(390, 47);
            lblMensagem.TabIndex = 9;
            lblMensagem.Text = "Para exibir os horários dê um duplo clique na turma desejada";
            lblMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ControlDark;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitulo.Location = new Point(568, 151);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(91, 24);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Horários";
            // 
            // FIM
            // 
            FIM.DataPropertyName = "FIM";
            FIM.HeaderText = "FIM";
            FIM.MinimumWidth = 6;
            FIM.Name = "FIM";
            FIM.ReadOnly = true;
            FIM.Width = 120;
            // 
            // INICIO
            // 
            INICIO.DataPropertyName = "INICIO";
            INICIO.HeaderText = "INICIO";
            INICIO.MinimumWidth = 6;
            INICIO.Name = "INICIO";
            INICIO.ReadOnly = true;
            INICIO.Width = 120;
            // 
            // SEMANA_NOME
            // 
            SEMANA_NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SEMANA_NOME.DataPropertyName = "SEMANA_NOME";
            SEMANA_NOME.HeaderText = "DIA DA SEMANA";
            SEMANA_NOME.MinimumWidth = 6;
            SEMANA_NOME.Name = "SEMANA_NOME";
            SEMANA_NOME.ReadOnly = true;
            // 
            // DIA_SEMANA
            // 
            DIA_SEMANA.DataPropertyName = "DIA_SEMANA";
            DIA_SEMANA.HeaderText = "DIA_SEMANA";
            DIA_SEMANA.MinimumWidth = 6;
            DIA_SEMANA.Name = "DIA_SEMANA";
            DIA_SEMANA.ReadOnly = true;
            DIA_SEMANA.Visible = false;
            DIA_SEMANA.Width = 125;
            // 
            // ID_TURMA1
            // 
            ID_TURMA1.DataPropertyName = "ID_TURMA";
            ID_TURMA1.HeaderText = "ID_TURMA1";
            ID_TURMA1.MinimumWidth = 6;
            ID_TURMA1.Name = "ID_TURMA1";
            ID_TURMA1.ReadOnly = true;
            ID_TURMA1.Visible = false;
            ID_TURMA1.Width = 125;
            // 
            // ID_HORARIO
            // 
            ID_HORARIO.DataPropertyName = "ID_HORARIO";
            ID_HORARIO.HeaderText = "ID_HORARIO";
            ID_HORARIO.MinimumWidth = 6;
            ID_HORARIO.Name = "ID_HORARIO";
            ID_HORARIO.ReadOnly = true;
            ID_HORARIO.Visible = false;
            ID_HORARIO.Width = 125;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnSalvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(828, 39);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
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
            // panel1
            // 
            panel1.Controls.Add(cboModalidade);
            panel1.Controls.Add(txtAluno);
            panel1.Controls.Add(txtTurma);
            panel1.Controls.Add(txtCod);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(13, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 243);
            panel1.TabIndex = 8;
            // 
            // cboModalidade
            // 
            cboModalidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboModalidade.FormattingEnabled = true;
            cboModalidade.Location = new Point(136, 49);
            cboModalidade.Name = "cboModalidade";
            cboModalidade.Size = new Size(237, 27);
            cboModalidade.TabIndex = 4;
            cboModalidade.Tag = "NOME_MODALIDADE";
            // 
            // txtAluno
            // 
            txtAluno.Location = new Point(282, 89);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(91, 27);
            txtAluno.TabIndex = 3;
            txtAluno.Tag = "MAXIMO_ALUNOS";
            // 
            // txtTurma
            // 
            txtTurma.Location = new Point(98, 89);
            txtTurma.Name = "txtTurma";
            txtTurma.Size = new Size(94, 27);
            txtTurma.TabIndex = 3;
            txtTurma.Tag = "NUMERO_TURMA";
            // 
            // txtCod
            // 
            txtCod.Location = new Point(98, 9);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(75, 27);
            txtCod.TabIndex = 3;
            txtCod.Tag = "ID_TURMA";
            txtCod.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtPesquisa);
            groupBox1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 104);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 36);
            label5.Name = "label5";
            label5.Size = new Size(260, 17);
            label5.TabIndex = 2;
            label5.Text = "Digite o nome da modalidade desejada";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(6, 56);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(354, 28);
            txtPesquisa.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(198, 91);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 2;
            label4.Text = "Alunos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 92);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 2;
            label3.Text = "Turma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 52);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 2;
            label2.Text = "Modalidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // dtgHorarios
            // 
            dtgHorarios.AllowUserToAddRows = false;
            dtgHorarios.AllowUserToDeleteRows = false;
            dtgHorarios.AllowUserToResizeColumns = false;
            dtgHorarios.AllowUserToResizeRows = false;
            dtgHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHorarios.Columns.AddRange(new DataGridViewColumn[] { ID_HORARIO, ID_TURMA1, DIA_SEMANA, SEMANA_NOME, INICIO, FIM });
            dtgHorarios.EnableHeadersVisualStyles = false;
            dtgHorarios.Location = new Point(412, 42);
            dtgHorarios.Name = "dtgHorarios";
            dtgHorarios.ReadOnly = true;
            dtgHorarios.RowHeadersVisible = false;
            dtgHorarios.RowHeadersWidth = 51;
            dtgHorarios.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgHorarios.Size = new Size(403, 243);
            dtgHorarios.TabIndex = 11;
            dtgHorarios.TabStop = false;
            // 
            // ucTurmas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgTurmas);
            Controls.Add(lblMensagem);
            Controls.Add(lblTitulo);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(dtgHorarios);
            Name = "ucTurmas";
            Size = new Size(828, 668);
            Load += ucTurmas_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTurmas).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewImageColumn btnHora;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewTextBoxColumn VAGAS;
        private DataGridViewTextBoxColumn MAXIMO_ALUNOS;
        private DataGridViewTextBoxColumn NOME_MODALIDADE;
        private DataGridViewTextBoxColumn NUMERO_TURMA;
        private DataGridViewTextBoxColumn ID_MODALIDADE;
        private DataGridViewTextBoxColumn ID_TURMA;
        private DataGridView dtgTurmas;
        private DataGridViewImageColumn btnExcluir;
        private Label lblMensagem;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn FIM;
        private DataGridViewTextBoxColumn INICIO;
        private DataGridViewTextBoxColumn SEMANA_NOME;
        private DataGridViewTextBoxColumn DIA_SEMANA;
        private DataGridViewTextBoxColumn ID_TURMA1;
        private DataGridViewTextBoxColumn ID_HORARIO;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnSalvar;
        private Panel panel1;
        private ComboBox cboModalidade;
        private TextBox txtAluno;
        private TextBox txtTurma;
        private TextBox txtCod;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txtPesquisa;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgHorarios;
    }
}
