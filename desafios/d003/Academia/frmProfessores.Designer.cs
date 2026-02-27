namespace Academia
{
    partial class frmProfessores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnSalvar = new ToolStripButton();
            label1 = new Label();
            rbNome = new RadioButton();
            groupBox1 = new GroupBox();
            txtPesquisa = new TextBox();
            rbCpf = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtSalario = new TextBox();
            txtObs = new TextBox();
            mtbCpf = new MaskedTextBox();
            mtbCep = new MaskedTextBox();
            txtCod = new TextBox();
            mtbFone = new MaskedTextBox();
            label11 = new Label();
            txtNum = new TextBox();
            dtgProfessores = new DataGridView();
            ID_PROFESSOR = new DataGridViewTextBoxColumn();
            NOME_PROFESSOR = new DataGridViewTextBoxColumn();
            ENDERECO_PROFESSOR = new DataGridViewTextBoxColumn();
            NUMERO_PROFESSOR = new DataGridViewTextBoxColumn();
            BAIRRO_PROFESSOR = new DataGridViewTextBoxColumn();
            CIDADE_PROFESSOR = new DataGridViewTextBoxColumn();
            CEP_PROFESSOR = new DataGridViewTextBoxColumn();
            CPF_PROFESSOR = new DataGridViewTextBoxColumn();
            SALARIO = new DataGridViewTextBoxColumn();
            TELEFONE_PROFESSOR = new DataGridViewTextBoxColumn();
            OBSERVACAO = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProfessores).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnSalvar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(945, 39);
            toolStrip1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Checked = true;
            rbNome.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbNome.Location = new Point(15, 67);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(68, 21);
            rbNome.TabIndex = 0;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPesquisa);
            groupBox1.Controls.Add(rbCpf);
            groupBox1.Controls.Add(rbNome);
            groupBox1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(622, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 102);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(6, 27);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(292, 27);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // rbCpf
            // 
            rbCpf.AutoSize = true;
            rbCpf.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCpf.Location = new Point(89, 67);
            rbCpf.Name = "rbCpf";
            rbCpf.Size = new Size(59, 21);
            rbCpf.TabIndex = 0;
            rbCpf.Text = "CPF";
            rbCpf.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 131);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 1;
            label3.Text = "Endereço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 167);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 1;
            label4.Text = "Bairro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 203);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 1;
            label5.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 239);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 1;
            label6.Text = "Telefone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(250, 239);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 1;
            label7.Text = "CPF:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(471, 167);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 1;
            label8.Text = "CEP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(437, 239);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 1;
            label9.Text = "Salário:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(622, 72);
            label10.Name = "label10";
            label10.Size = new Size(133, 21);
            label10.TabIndex = 1;
            label10.Text = "Observações:";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(121, 128);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(495, 27);
            txtEndereco.TabIndex = 2;
            txtEndereco.Tag = "ENDERECO_PROFESSOR";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(121, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(495, 27);
            txtNome.TabIndex = 1;
            txtNome.Tag = "NOME_PROFESSOR";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(122, 164);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(169, 27);
            txtBairro.TabIndex = 3;
            txtBairro.Tag = "BAIRRO_PROFESSOR";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(121, 200);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(495, 27);
            txtCidade.TabIndex = 6;
            txtCidade.Tag = "CIDADE_PROFESSOR";
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalario.Location = new Point(520, 236);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(96, 27);
            txtSalario.TabIndex = 9;
            txtSalario.Tag = "SALARIO";
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObs.Location = new Point(622, 96);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(311, 59);
            txtObs.TabIndex = 10;
            txtObs.Tag = "OBSERVACAO";
            // 
            // mtbCpf
            // 
            mtbCpf.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbCpf.Location = new Point(309, 236);
            mtbCpf.Mask = "999,999,999-99";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(122, 27);
            mtbCpf.TabIndex = 8;
            mtbCpf.Tag = "CPF_PROFESSOR";
            // 
            // mtbCep
            // 
            mtbCep.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbCep.Location = new Point(531, 164);
            mtbCep.Mask = "99999-000";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(85, 27);
            mtbCep.TabIndex = 5;
            mtbCep.Tag = "CEP_PROFESSOR";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCod.Location = new Point(122, 56);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(85, 27);
            txtCod.TabIndex = 0;
            txtCod.TabStop = false;
            txtCod.Tag = "ID_PROFESSOR";
            txtCod.Text = "0";
            // 
            // mtbFone
            // 
            mtbFone.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbFone.Location = new Point(122, 236);
            mtbFone.Mask = "(99) 99999-9999";
            mtbFone.Name = "mtbFone";
            mtbFone.Size = new Size(122, 27);
            mtbFone.TabIndex = 7;
            mtbFone.Tag = "TELEFONE_PROFESSOR";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(297, 167);
            label11.Name = "label11";
            label11.Size = new Size(87, 21);
            label11.TabIndex = 1;
            label11.Text = "Número:";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(390, 164);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(75, 27);
            txtNum.TabIndex = 4;
            txtNum.Tag = "NUMERO_PROFESSOR";
            // 
            // dtgProfessores
            // 
            dtgProfessores.AllowUserToAddRows = false;
            dtgProfessores.AllowUserToDeleteRows = false;
            dtgProfessores.AllowUserToResizeColumns = false;
            dtgProfessores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dtgProfessores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgProfessores.BackgroundColor = Color.FromArgb(224, 224, 224);
            dtgProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgProfessores.Columns.AddRange(new DataGridViewColumn[] { ID_PROFESSOR, NOME_PROFESSOR, ENDERECO_PROFESSOR, NUMERO_PROFESSOR, BAIRRO_PROFESSOR, CIDADE_PROFESSOR, CEP_PROFESSOR, CPF_PROFESSOR, SALARIO, TELEFONE_PROFESSOR, OBSERVACAO, btnEditar, btnExcluir });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgProfessores.DefaultCellStyle = dataGridViewCellStyle2;
            dtgProfessores.Location = new Point(14, 281);
            dtgProfessores.Name = "dtgProfessores";
            dtgProfessores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgProfessores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgProfessores.RowHeadersVisible = false;
            dtgProfessores.RowHeadersWidth = 51;
            dtgProfessores.Size = new Size(919, 260);
            dtgProfessores.TabIndex = 0;
            dtgProfessores.TabStop = false;
            dtgProfessores.CellContentClick += dtgProfessores_CellContentClick;
            // 
            // ID_PROFESSOR
            // 
            ID_PROFESSOR.DataPropertyName = "ID_PROFESSOR";
            ID_PROFESSOR.HeaderText = "CÓDIGO";
            ID_PROFESSOR.MinimumWidth = 6;
            ID_PROFESSOR.Name = "ID_PROFESSOR";
            ID_PROFESSOR.ReadOnly = true;
            ID_PROFESSOR.SortMode = DataGridViewColumnSortMode.NotSortable;
            ID_PROFESSOR.Width = 75;
            // 
            // NOME_PROFESSOR
            // 
            NOME_PROFESSOR.DataPropertyName = "NOME_PROFESSOR";
            NOME_PROFESSOR.HeaderText = "NOME";
            NOME_PROFESSOR.MinimumWidth = 6;
            NOME_PROFESSOR.Name = "NOME_PROFESSOR";
            NOME_PROFESSOR.ReadOnly = true;
            NOME_PROFESSOR.SortMode = DataGridViewColumnSortMode.NotSortable;
            NOME_PROFESSOR.Width = 300;
            // 
            // ENDERECO_PROFESSOR
            // 
            ENDERECO_PROFESSOR.DataPropertyName = "ENDERECO_PROFESSOR";
            ENDERECO_PROFESSOR.HeaderText = "ENDEREÇO";
            ENDERECO_PROFESSOR.MinimumWidth = 6;
            ENDERECO_PROFESSOR.Name = "ENDERECO_PROFESSOR";
            ENDERECO_PROFESSOR.ReadOnly = true;
            ENDERECO_PROFESSOR.SortMode = DataGridViewColumnSortMode.NotSortable;
            ENDERECO_PROFESSOR.Width = 161;
            // 
            // NUMERO_PROFESSOR
            // 
            NUMERO_PROFESSOR.DataPropertyName = "NUMERO_PROFESSOR";
            NUMERO_PROFESSOR.HeaderText = "NÚMERO";
            NUMERO_PROFESSOR.MinimumWidth = 6;
            NUMERO_PROFESSOR.Name = "NUMERO_PROFESSOR";
            NUMERO_PROFESSOR.ReadOnly = true;
            NUMERO_PROFESSOR.SortMode = DataGridViewColumnSortMode.NotSortable;
            NUMERO_PROFESSOR.Width = 80;
            // 
            // BAIRRO_PROFESSOR
            // 
            BAIRRO_PROFESSOR.DataPropertyName = "BAIRRO_PROFESSOR";
            BAIRRO_PROFESSOR.HeaderText = "BAIRRO";
            BAIRRO_PROFESSOR.MinimumWidth = 6;
            BAIRRO_PROFESSOR.Name = "BAIRRO_PROFESSOR";
            BAIRRO_PROFESSOR.ReadOnly = true;
            BAIRRO_PROFESSOR.Visible = false;
            BAIRRO_PROFESSOR.Width = 125;
            // 
            // CIDADE_PROFESSOR
            // 
            CIDADE_PROFESSOR.DataPropertyName = "CIDADE_PROFESSOR";
            CIDADE_PROFESSOR.HeaderText = "CIDADE";
            CIDADE_PROFESSOR.MinimumWidth = 6;
            CIDADE_PROFESSOR.Name = "CIDADE_PROFESSOR";
            CIDADE_PROFESSOR.ReadOnly = true;
            CIDADE_PROFESSOR.Visible = false;
            CIDADE_PROFESSOR.Width = 125;
            // 
            // CEP_PROFESSOR
            // 
            CEP_PROFESSOR.DataPropertyName = "CEP_PROFESSOR";
            CEP_PROFESSOR.HeaderText = "CEP";
            CEP_PROFESSOR.MinimumWidth = 6;
            CEP_PROFESSOR.Name = "CEP_PROFESSOR";
            CEP_PROFESSOR.ReadOnly = true;
            CEP_PROFESSOR.Visible = false;
            CEP_PROFESSOR.Width = 125;
            // 
            // CPF_PROFESSOR
            // 
            CPF_PROFESSOR.DataPropertyName = "CPF_PROFESSOR";
            CPF_PROFESSOR.HeaderText = "CPF";
            CPF_PROFESSOR.MinimumWidth = 6;
            CPF_PROFESSOR.Name = "CPF_PROFESSOR";
            CPF_PROFESSOR.ReadOnly = true;
            CPF_PROFESSOR.SortMode = DataGridViewColumnSortMode.NotSortable;
            CPF_PROFESSOR.Width = 110;
            // 
            // SALARIO
            // 
            SALARIO.DataPropertyName = "SALARIO";
            SALARIO.HeaderText = "SALÁRIO";
            SALARIO.MinimumWidth = 6;
            SALARIO.Name = "SALARIO";
            SALARIO.ReadOnly = true;
            SALARIO.Visible = false;
            SALARIO.Width = 125;
            // 
            // TELEFONE_PROFESSOR
            // 
            TELEFONE_PROFESSOR.DataPropertyName = "TELEFONE_PROFESSOR";
            TELEFONE_PROFESSOR.HeaderText = "FONE";
            TELEFONE_PROFESSOR.MinimumWidth = 6;
            TELEFONE_PROFESSOR.Name = "TELEFONE_PROFESSOR";
            TELEFONE_PROFESSOR.ReadOnly = true;
            TELEFONE_PROFESSOR.SortMode = DataGridViewColumnSortMode.NotSortable;
            TELEFONE_PROFESSOR.Width = 118;
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
            // btnEditar
            // 
            btnEditar.HeaderText = "";
            btnEditar.Image = Properties.Resources.dtgEditar;
            btnEditar.MinimumWidth = 6;
            btnEditar.Name = "btnEditar";
            btnEditar.ReadOnly = true;
            btnEditar.Width = 36;
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "";
            btnExcluir.Image = Properties.Resources.dtgExcluir;
            btnExcluir.MinimumWidth = 6;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.ReadOnly = true;
            btnExcluir.Width = 36;
            // 
            // frmProfessores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 553);
            Controls.Add(dtgProfessores);
            Controls.Add(mtbCep);
            Controls.Add(mtbFone);
            Controls.Add(mtbCpf);
            Controls.Add(groupBox1);
            Controls.Add(txtObs);
            Controls.Add(txtSalario);
            Controls.Add(txtCidade);
            Controls.Add(txtNum);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtCod);
            Controls.Add(txtNome);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProfessores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCA - Controle de Professores";
            Load += frmProfessores_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgProfessores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Label label1;
        private RadioButton rbNome;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnSalvar;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private RadioButton rbCpf;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtSalario;
        private TextBox txtPesquisa;
        private TextBox txtObs;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbCep;
        private TextBox txtCod;
        private MaskedTextBox mtbFone;
        private Label label11;
        private TextBox txtNum;
        private DataGridView dtgProfessores;
        private DataGridViewTextBoxColumn ID_PROFESSOR;
        private DataGridViewTextBoxColumn NOME_PROFESSOR;
        private DataGridViewTextBoxColumn ENDERECO_PROFESSOR;
        private DataGridViewTextBoxColumn NUMERO_PROFESSOR;
        private DataGridViewTextBoxColumn BAIRRO_PROFESSOR;
        private DataGridViewTextBoxColumn CIDADE_PROFESSOR;
        private DataGridViewTextBoxColumn CEP_PROFESSOR;
        private DataGridViewTextBoxColumn CPF_PROFESSOR;
        private DataGridViewTextBoxColumn SALARIO;
        private DataGridViewTextBoxColumn TELEFONE_PROFESSOR;
        private DataGridViewTextBoxColumn OBSERVACAO;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnExcluir;
    }
}