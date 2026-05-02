namespace Academia
{
    partial class ucAlunos
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
            OBSERVACAO = new DataGridViewTextBoxColumn();
            TELEFONE_ALUNO = new DataGridViewTextBoxColumn();
            CPF_ALUNO = new DataGridViewTextBoxColumn();
            CEP_ALUNO = new DataGridViewTextBoxColumn();
            CIDADE_ALUNO = new DataGridViewTextBoxColumn();
            NUMERO_ALUNO = new DataGridViewTextBoxColumn();
            BAIRRO_ALUNO = new DataGridViewTextBoxColumn();
            ENDERECO_ALUNO = new DataGridViewTextBoxColumn();
            NOME_ALUNO = new DataGridViewTextBoxColumn();
            ID_ALUNO = new DataGridViewTextBoxColumn();
            dtgAlunos = new DataGridView();
            SEXO = new DataGridViewTextBoxColumn();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            rbCpf = new RadioButton();
            rbNome = new RadioButton();
            btnAdicionar = new Button();
            txtPesquisa = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OBSERVACAO
            // 
            OBSERVACAO.DataPropertyName = "OBSERVACAO";
            OBSERVACAO.HeaderText = "OBSERVAÇÃO";
            OBSERVACAO.MinimumWidth = 6;
            OBSERVACAO.Name = "OBSERVACAO";
            OBSERVACAO.ReadOnly = true;
            OBSERVACAO.Visible = false;
            OBSERVACAO.Width = 125;
            // 
            // TELEFONE_ALUNO
            // 
            TELEFONE_ALUNO.DataPropertyName = "TELEFONE_ALUNO";
            TELEFONE_ALUNO.HeaderText = "TELEFONE";
            TELEFONE_ALUNO.MinimumWidth = 6;
            TELEFONE_ALUNO.Name = "TELEFONE_ALUNO";
            TELEFONE_ALUNO.ReadOnly = true;
            TELEFONE_ALUNO.Width = 125;
            // 
            // CPF_ALUNO
            // 
            CPF_ALUNO.DataPropertyName = "CPF_ALUNO";
            CPF_ALUNO.HeaderText = "CPF";
            CPF_ALUNO.MinimumWidth = 6;
            CPF_ALUNO.Name = "CPF_ALUNO";
            CPF_ALUNO.ReadOnly = true;
            CPF_ALUNO.Width = 125;
            // 
            // CEP_ALUNO
            // 
            CEP_ALUNO.DataPropertyName = "CEP_ALUNO";
            CEP_ALUNO.HeaderText = "CEP";
            CEP_ALUNO.MinimumWidth = 6;
            CEP_ALUNO.Name = "CEP_ALUNO";
            CEP_ALUNO.ReadOnly = true;
            CEP_ALUNO.Visible = false;
            CEP_ALUNO.Width = 125;
            // 
            // CIDADE_ALUNO
            // 
            CIDADE_ALUNO.DataPropertyName = "CIDADE_ALUNO";
            CIDADE_ALUNO.HeaderText = "CIDADE";
            CIDADE_ALUNO.MinimumWidth = 6;
            CIDADE_ALUNO.Name = "CIDADE_ALUNO";
            CIDADE_ALUNO.ReadOnly = true;
            CIDADE_ALUNO.Visible = false;
            CIDADE_ALUNO.Width = 125;
            // 
            // NUMERO_ALUNO
            // 
            NUMERO_ALUNO.DataPropertyName = "NUMERO_ALUNO";
            NUMERO_ALUNO.HeaderText = "Nº";
            NUMERO_ALUNO.MinimumWidth = 6;
            NUMERO_ALUNO.Name = "NUMERO_ALUNO";
            NUMERO_ALUNO.ReadOnly = true;
            NUMERO_ALUNO.Visible = false;
            NUMERO_ALUNO.Width = 125;
            // 
            // BAIRRO_ALUNO
            // 
            BAIRRO_ALUNO.DataPropertyName = "BAIRRO_ALUNO";
            BAIRRO_ALUNO.HeaderText = "BAIRRO";
            BAIRRO_ALUNO.MinimumWidth = 6;
            BAIRRO_ALUNO.Name = "BAIRRO_ALUNO";
            BAIRRO_ALUNO.ReadOnly = true;
            BAIRRO_ALUNO.Visible = false;
            BAIRRO_ALUNO.Width = 125;
            // 
            // ENDERECO_ALUNO
            // 
            ENDERECO_ALUNO.DataPropertyName = "ENDERECO_ALUNO";
            ENDERECO_ALUNO.HeaderText = "ENDEREÇO";
            ENDERECO_ALUNO.MinimumWidth = 6;
            ENDERECO_ALUNO.Name = "ENDERECO_ALUNO";
            ENDERECO_ALUNO.ReadOnly = true;
            ENDERECO_ALUNO.Width = 200;
            // 
            // NOME_ALUNO
            // 
            NOME_ALUNO.DataPropertyName = "NOME_ALUNO";
            NOME_ALUNO.HeaderText = "NOME";
            NOME_ALUNO.MinimumWidth = 6;
            NOME_ALUNO.Name = "NOME_ALUNO";
            NOME_ALUNO.ReadOnly = true;
            NOME_ALUNO.Width = 323;
            // 
            // ID_ALUNO
            // 
            ID_ALUNO.DataPropertyName = "ID_ALUNO";
            ID_ALUNO.HeaderText = "ID_ALUNO";
            ID_ALUNO.MinimumWidth = 6;
            ID_ALUNO.Name = "ID_ALUNO";
            ID_ALUNO.ReadOnly = true;
            ID_ALUNO.Visible = false;
            ID_ALUNO.Width = 125;
            // 
            // dtgAlunos
            // 
            dtgAlunos.AllowUserToAddRows = false;
            dtgAlunos.AllowUserToDeleteRows = false;
            dtgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlunos.Columns.AddRange(new DataGridViewColumn[] { ID_ALUNO, NOME_ALUNO, ENDERECO_ALUNO, BAIRRO_ALUNO, NUMERO_ALUNO, CIDADE_ALUNO, CEP_ALUNO, CPF_ALUNO, TELEFONE_ALUNO, SEXO, OBSERVACAO });
            dtgAlunos.Location = new Point(3, 164);
            dtgAlunos.Name = "dtgAlunos";
            dtgAlunos.ReadOnly = true;
            dtgAlunos.RowHeadersVisible = false;
            dtgAlunos.RowHeadersWidth = 51;
            dtgAlunos.Size = new Size(776, 343);
            dtgAlunos.TabIndex = 15;
            dtgAlunos.DoubleClick += dtgAlunos_DoubleClick;
            // 
            // SEXO
            // 
            SEXO.DataPropertyName = "SEXO";
            SEXO.HeaderText = "SEXO";
            SEXO.MinimumWidth = 6;
            SEXO.Name = "SEXO";
            SEXO.ReadOnly = true;
            SEXO.Visible = false;
            SEXO.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 142);
            label3.Name = "label3";
            label3.Size = new Size(509, 19);
            label3.TabIndex = 14;
            label3.Text = "Para editar as informações dos alunos, dê um duplo clique sobre ele";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alunos;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // rbCpf
            // 
            rbCpf.AutoSize = true;
            rbCpf.Location = new Point(318, 90);
            rbCpf.Name = "rbCpf";
            rbCpf.Size = new Size(54, 24);
            rbCpf.TabIndex = 11;
            rbCpf.Text = "CPF";
            rbCpf.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Checked = true;
            rbNome.Location = new Point(230, 90);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(71, 24);
            rbNome.TabIndex = 12;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.adicionar_aluno;
            btnAdicionar.ImageAlign = ContentAlignment.TopCenter;
            btnAdicionar.Location = new Point(638, 53);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(141, 63);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar aluno";
            btnAdicionar.TextAlign = ContentAlignment.BottomCenter;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(230, 57);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(402, 27);
            txtPesquisa.TabIndex = 9;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(120, 58);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 7;
            label2.Text = "Pesquisar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 3);
            label1.Name = "label1";
            label1.Size = new Size(285, 33);
            label1.TabIndex = 8;
            label1.Text = "Alunos Cadastrados";
            // 
            // ucAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgAlunos);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(rbCpf);
            Controls.Add(rbNome);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucAlunos";
            Size = new Size(783, 512);
            Load += frmAlunos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn OBSERVACAO;
        private DataGridViewTextBoxColumn TELEFONE_ALUNO;
        private DataGridViewTextBoxColumn CPF_ALUNO;
        private DataGridViewTextBoxColumn CEP_ALUNO;
        private DataGridViewTextBoxColumn CIDADE_ALUNO;
        private DataGridViewTextBoxColumn NUMERO_ALUNO;
        private DataGridViewTextBoxColumn BAIRRO_ALUNO;
        private DataGridViewTextBoxColumn ENDERECO_ALUNO;
        private DataGridViewTextBoxColumn NOME_ALUNO;
        private DataGridViewTextBoxColumn ID_ALUNO;
        private DataGridView dtgAlunos;
        private DataGridViewTextBoxColumn SEXO;
        private Label label3;
        private PictureBox pictureBox1;
        private RadioButton rbCpf;
        private RadioButton rbNome;
        private Button btnAdicionar;
        private TextBox txtPesquisa;
        private Label label2;
        private Label label1;
    }
}
