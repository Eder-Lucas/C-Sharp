namespace Academia
{
    partial class frmControleAlunos
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
            tcAluno = new TabControl();
            tabPageCadastro = new TabPage();
            dtgTurmas = new DataGridView();
            SITUACAO1 = new DataGridViewTextBoxColumn();
            MODALIDADE = new DataGridViewTextBoxColumn();
            TURMA = new DataGridViewTextBoxColumn();
            MENSALIDADE1 = new DataGridViewTextBoxColumn();
            VENCIMENTO1 = new DataGridViewTextBoxColumn();
            cboSexo = new ComboBox();
            mtbCep = new MaskedTextBox();
            mtbCpf = new MaskedTextBox();
            mtbTel = new MaskedTextBox();
            txtObs = new TextBox();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtEndereco = new TextBox();
            txtNome = new TextBox();
            txtCod = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label13 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            label3 = new Label();
            label14 = new Label();
            label12 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnSalvar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            tabPageMatricula = new TabPage();
            switchSituacao = new ToggleSwitch();
            lblMensagem = new Label();
            dtpVencimento = new DateTimePicker();
            btnSalvarMatricula = new Button();
            btnIncluir = new Button();
            btnExcluirMatricula = new Button();
            pictureBox3 = new PictureBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            lblSwitchSituacao = new Label();
            label19 = new Label();
            label15 = new Label();
            groupBox1 = new GroupBox();
            txtNomeAluno = new TextBox();
            txtCodAluno = new TextBox();
            dtgMatricula = new DataGridView();
            ID_MATRICULA = new DataGridViewTextBoxColumn();
            ID_TURMA1 = new DataGridViewTextBoxColumn();
            ID_ALUNO = new DataGridViewTextBoxColumn();
            SITUACAO = new DataGridViewTextBoxColumn();
            NOME_MODALIDADE1 = new DataGridViewTextBoxColumn();
            NUMERO_TURMA1 = new DataGridViewTextBoxColumn();
            MENSALIDADE = new DataGridViewTextBoxColumn();
            VENCIMENTO = new DataGridViewTextBoxColumn();
            dtgTurmasCadastradas = new DataGridView();
            ID_MODALIDADE = new DataGridViewTextBoxColumn();
            ID_TURMA = new DataGridViewTextBoxColumn();
            NOME_MODALIDADE = new DataGridViewTextBoxColumn();
            NUMERO_TURMA = new DataGridViewTextBoxColumn();
            VAGAS = new DataGridViewTextBoxColumn();
            MAXIMO_ALUNOS = new DataGridViewTextBoxColumn();
            btnHora = new DataGridViewImageColumn();
            tabPageMensalidade = new TabPage();
            dtgMensalidades = new DataGridView();
            MODALIDADE1 = new DataGridViewTextBoxColumn();
            VENCIMENTO2 = new DataGridViewTextBoxColumn();
            DATA_PAGAMENTO = new DataGridViewTextBoxColumn();
            VALOR = new DataGridViewTextBoxColumn();
            SITUACAO_MENSALIDADE = new DataGridViewTextBoxColumn();
            STATUS_MENSALIDADE = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            btnPagamento = new Button();
            groupBox3 = new GroupBox();
            lblAtraso = new Label();
            label22 = new Label();
            groupBox2 = new GroupBox();
            btnFiltro = new Button();
            cboSituacaoMensalidade = new ComboBox();
            label21 = new Label();
            pictureBox4 = new PictureBox();
            tcAluno.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTurmas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            tabPageMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMatricula).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgTurmasCadastradas).BeginInit();
            tabPageMensalidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMensalidades).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // tcAluno
            // 
            tcAluno.Controls.Add(tabPageCadastro);
            tcAluno.Controls.Add(tabPageMatricula);
            tcAluno.Controls.Add(tabPageMensalidade);
            tcAluno.Dock = DockStyle.Fill;
            tcAluno.Location = new Point(0, 0);
            tcAluno.Name = "tcAluno";
            tcAluno.SelectedIndex = 0;
            tcAluno.Size = new Size(839, 622);
            tcAluno.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(dtgTurmas);
            tabPageCadastro.Controls.Add(cboSexo);
            tabPageCadastro.Controls.Add(mtbCep);
            tabPageCadastro.Controls.Add(mtbCpf);
            tabPageCadastro.Controls.Add(mtbTel);
            tabPageCadastro.Controls.Add(txtObs);
            tabPageCadastro.Controls.Add(txtNumero);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtCod);
            tabPageCadastro.Controls.Add(label11);
            tabPageCadastro.Controls.Add(label10);
            tabPageCadastro.Controls.Add(label7);
            tabPageCadastro.Controls.Add(label13);
            tabPageCadastro.Controls.Add(label6);
            tabPageCadastro.Controls.Add(label5);
            tabPageCadastro.Controls.Add(label4);
            tabPageCadastro.Controls.Add(label2);
            tabPageCadastro.Controls.Add(label9);
            tabPageCadastro.Controls.Add(label8);
            tabPageCadastro.Controls.Add(label3);
            tabPageCadastro.Controls.Add(label14);
            tabPageCadastro.Controls.Add(label12);
            tabPageCadastro.Controls.Add(label1);
            tabPageCadastro.Controls.Add(pictureBox2);
            tabPageCadastro.Controls.Add(pictureBox1);
            tabPageCadastro.Controls.Add(toolStrip1);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(831, 589);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // dtgTurmas
            // 
            dtgTurmas.AllowUserToAddRows = false;
            dtgTurmas.AllowUserToDeleteRows = false;
            dtgTurmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTurmas.Columns.AddRange(new DataGridViewColumn[] { SITUACAO1, MODALIDADE, TURMA, MENSALIDADE1, VENCIMENTO1 });
            dtgTurmas.Location = new Point(8, 327);
            dtgTurmas.Name = "dtgTurmas";
            dtgTurmas.ReadOnly = true;
            dtgTurmas.RowHeadersVisible = false;
            dtgTurmas.RowHeadersWidth = 51;
            dtgTurmas.Size = new Size(506, 254);
            dtgTurmas.TabIndex = 6;
            // 
            // SITUACAO1
            // 
            SITUACAO1.DataPropertyName = "SITUACAO";
            SITUACAO1.HeaderText = "SITUAÇÃO";
            SITUACAO1.MinimumWidth = 6;
            SITUACAO1.Name = "SITUACAO1";
            SITUACAO1.ReadOnly = true;
            SITUACAO1.Width = 90;
            // 
            // MODALIDADE
            // 
            MODALIDADE.DataPropertyName = "NOME_MODALIDADE";
            MODALIDADE.HeaderText = "MODALIDADE";
            MODALIDADE.MinimumWidth = 6;
            MODALIDADE.Name = "MODALIDADE";
            MODALIDADE.ReadOnly = true;
            MODALIDADE.Width = 115;
            // 
            // TURMA
            // 
            TURMA.DataPropertyName = "NUMERO_TURMA";
            TURMA.HeaderText = "TURMA";
            TURMA.MinimumWidth = 6;
            TURMA.Name = "TURMA";
            TURMA.ReadOnly = true;
            TURMA.Width = 70;
            // 
            // MENSALIDADE1
            // 
            MENSALIDADE1.DataPropertyName = "MENSALIDADE";
            MENSALIDADE1.HeaderText = "MENSALIDADE";
            MENSALIDADE1.MinimumWidth = 6;
            MENSALIDADE1.Name = "MENSALIDADE1";
            MENSALIDADE1.ReadOnly = true;
            MENSALIDADE1.Width = 118;
            // 
            // VENCIMENTO1
            // 
            VENCIMENTO1.DataPropertyName = "VENCIMENTO";
            VENCIMENTO1.HeaderText = "VENCIMENTO";
            VENCIMENTO1.MinimumWidth = 6;
            VENCIMENTO1.Name = "VENCIMENTO1";
            VENCIMENTO1.ReadOnly = true;
            VENCIMENTO1.Width = 110;
            // 
            // cboSexo
            // 
            cboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSexo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSexo.FormattingEnabled = true;
            cboSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cboSexo.Location = new Point(512, 276);
            cboSexo.Name = "cboSexo";
            cboSexo.Size = new Size(106, 27);
            cboSexo.TabIndex = 5;
            cboSexo.Tag = "SEXO";
            // 
            // mtbCep
            // 
            mtbCep.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbCep.Location = new Point(527, 243);
            mtbCep.Mask = "99999-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(91, 27);
            mtbCep.TabIndex = 4;
            mtbCep.Tag = "CEP_ALUNO";
            // 
            // mtbCpf
            // 
            mtbCpf.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbCpf.Location = new Point(312, 276);
            mtbCpf.Mask = "999,999,999-99";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(126, 27);
            mtbCpf.TabIndex = 4;
            mtbCpf.Tag = "CPF_ALUNO";
            // 
            // mtbTel
            // 
            mtbTel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbTel.Location = new Point(112, 276);
            mtbTel.Mask = "(99) 99999-9999";
            mtbTel.Name = "mtbTel";
            mtbTel.Size = new Size(135, 27);
            mtbTel.TabIndex = 4;
            mtbTel.Tag = "TELEFONE_ALUNO";
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObs.Location = new Point(622, 177);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(201, 126);
            txtObs.TabIndex = 3;
            txtObs.Tag = "OBSERVACAO";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(112, 243);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(77, 27);
            txtNumero.TabIndex = 3;
            txtNumero.Tag = "NUMERO_ALUNO";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(279, 243);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(182, 27);
            txtCidade.TabIndex = 3;
            txtCidade.Tag = "CIDADE_ALUNO";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(437, 210);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(181, 27);
            txtBairro.TabIndex = 3;
            txtBairro.Tag = "BAIRRO_ALUNO";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(112, 210);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(243, 27);
            txtEndereco.TabIndex = 3;
            txtEndereco.Tag = "ENDERECO_ALUNO";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(112, 177);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(506, 27);
            txtNome.TabIndex = 3;
            txtNome.Tag = "NOME_ALUNO";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCod.Location = new Point(112, 144);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(93, 27);
            txtCod.TabIndex = 3;
            txtCod.Tag = "ID_ALUNO";
            txtCod.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(622, 153);
            label11.Name = "label11";
            label11.Size = new Size(133, 21);
            label11.TabIndex = 2;
            label11.Text = "Observações:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(444, 279);
            label10.Name = "label10";
            label10.Size = new Size(62, 21);
            label10.TabIndex = 2;
            label10.Text = "Sexo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 279);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 2;
            label7.Text = "Celular:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(72, 246);
            label13.Name = "label13";
            label13.Size = new Size(37, 21);
            label13.TabIndex = 2;
            label13.Text = "Nº:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(195, 246);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 2;
            label6.Text = "Cidade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(361, 213);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 2;
            label5.Text = "Bairro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 213);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 2;
            label4.Text = "Endereço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 180);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(467, 246);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 2;
            label9.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(253, 279);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 2;
            label8.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 147);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 2;
            label3.Text = "Código:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(586, 374);
            label14.Name = "label14";
            label14.Size = new Size(242, 19);
            label14.TabIndex = 2;
            label14.Text = "- Onde o aluno está matrículado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(590, 347);
            label12.Name = "label12";
            label12.Size = new Size(94, 27);
            label12.TabIndex = 2;
            label12.Text = "Turmas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 70);
            label1.Name = "label1";
            label1.Size = new Size(228, 27);
            label1.TabIndex = 2;
            label1.Text = "Controle de Alunos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.turmas_maior;
            pictureBox2.Location = new Point(520, 327);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alunos;
            pictureBox1.Location = new Point(8, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnSalvar, btnExcluir });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(825, 39);
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
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.excluir;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 36);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // tabPageMatricula
            // 
            tabPageMatricula.Controls.Add(switchSituacao);
            tabPageMatricula.Controls.Add(lblMensagem);
            tabPageMatricula.Controls.Add(dtpVencimento);
            tabPageMatricula.Controls.Add(btnSalvarMatricula);
            tabPageMatricula.Controls.Add(btnIncluir);
            tabPageMatricula.Controls.Add(btnExcluirMatricula);
            tabPageMatricula.Controls.Add(pictureBox3);
            tabPageMatricula.Controls.Add(label18);
            tabPageMatricula.Controls.Add(label17);
            tabPageMatricula.Controls.Add(label16);
            tabPageMatricula.Controls.Add(lblSwitchSituacao);
            tabPageMatricula.Controls.Add(label19);
            tabPageMatricula.Controls.Add(label15);
            tabPageMatricula.Controls.Add(groupBox1);
            tabPageMatricula.Controls.Add(dtgMatricula);
            tabPageMatricula.Controls.Add(dtgTurmasCadastradas);
            tabPageMatricula.Location = new Point(4, 29);
            tabPageMatricula.Name = "tabPageMatricula";
            tabPageMatricula.Padding = new Padding(3);
            tabPageMatricula.Size = new Size(831, 589);
            tabPageMatricula.TabIndex = 1;
            tabPageMatricula.Text = "Matrícula";
            tabPageMatricula.UseVisualStyleBackColor = true;
            // 
            // switchSituacao
            // 
            switchSituacao.Checked = true;
            switchSituacao.Location = new Point(8, 153);
            switchSituacao.Name = "switchSituacao";
            switchSituacao.OffColor = Color.Firebrick;
            switchSituacao.Size = new Size(65, 25);
            switchSituacao.TabIndex = 12;
            switchSituacao.Text = "toggleSwitch1";
            switchSituacao.CheckedChanged += switchSituacao_CheckedChanged;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.BackColor = Color.DarkGray;
            lblMensagem.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Red;
            lblMensagem.Location = new Point(446, 220);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(252, 19);
            lblMensagem.TabIndex = 11;
            lblMensagem.Text = "nenhuma matrícula encontrada";
            // 
            // dtpVencimento
            // 
            dtpVencimento.CustomFormat = "dd/MM/yy";
            dtpVencimento.Format = DateTimePickerFormat.Custom;
            dtpVencimento.Location = new Point(139, 123);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(89, 27);
            dtpVencimento.TabIndex = 10;
            dtpVencimento.Tag = "VENCIMENTO";
            // 
            // btnSalvarMatricula
            // 
            btnSalvarMatricula.Image = Properties.Resources.salvar;
            btnSalvarMatricula.Location = new Point(247, 123);
            btnSalvarMatricula.Name = "btnSalvarMatricula";
            btnSalvarMatricula.Size = new Size(66, 55);
            btnSalvarMatricula.TabIndex = 9;
            btnSalvarMatricula.UseVisualStyleBackColor = true;
            btnSalvarMatricula.Click += btnSalvarMatricula_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Image = Properties.Resources.sinal_mais;
            btnIncluir.Location = new Point(446, 318);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(69, 63);
            btnIncluir.TabIndex = 9;
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnExcluirMatricula
            // 
            btnExcluirMatricula.Image = Properties.Resources.excluir;
            btnExcluirMatricula.Location = new Point(247, 184);
            btnExcluirMatricula.Name = "btnExcluirMatricula";
            btnExcluirMatricula.Size = new Size(66, 55);
            btnExcluirMatricula.TabIndex = 9;
            btnExcluirMatricula.UseVisualStyleBackColor = true;
            btnExcluirMatricula.Click += btnExcluirMatricula_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.registrar_matriculas;
            pictureBox3.Location = new Point(8, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(440, 100);
            label18.Name = "label18";
            label18.Size = new Size(79, 21);
            label18.TabIndex = 7;
            label18.Text = "do aluno";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(94, 290);
            label17.Name = "label17";
            label17.Size = new Size(108, 21);
            label17.TabIndex = 7;
            label17.Text = "cadastradas";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(8, 285);
            label16.Name = "label16";
            label16.Size = new Size(94, 27);
            label16.TabIndex = 7;
            label16.Text = "Turmas";
            // 
            // lblSwitchSituacao
            // 
            lblSwitchSituacao.AutoSize = true;
            lblSwitchSituacao.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSwitchSituacao.Location = new Point(79, 159);
            lblSwitchSituacao.Name = "lblSwitchSituacao";
            lblSwitchSituacao.Size = new Size(134, 19);
            lblSwitchSituacao.TabIndex = 7;
            lblSwitchSituacao.Text = "Inativar matrícula";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(6, 123);
            label19.Name = "label19";
            label19.Size = new Size(127, 24);
            label19.TabIndex = 7;
            label19.Text = "Vencimento:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(319, 95);
            label15.Name = "label15";
            label15.Size = new Size(128, 27);
            label15.TabIndex = 7;
            label15.Text = "Matrículas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNomeAluno);
            groupBox1.Controls.Add(txtCodAluno);
            groupBox1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(79, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(855, 72);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do aluno";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeAluno.Location = new Point(79, 33);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.PlaceholderText = "Nome do aluno";
            txtNomeAluno.Size = new Size(766, 27);
            txtNomeAluno.TabIndex = 1;
            txtNomeAluno.Tag = "NOME_ALUNO";
            // 
            // txtCodAluno
            // 
            txtCodAluno.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodAluno.Location = new Point(6, 33);
            txtCodAluno.Name = "txtCodAluno";
            txtCodAluno.ReadOnly = true;
            txtCodAluno.Size = new Size(67, 27);
            txtCodAluno.TabIndex = 1;
            txtCodAluno.Tag = "ID_ALUNO";
            txtCodAluno.Text = "0";
            // 
            // dtgMatricula
            // 
            dtgMatricula.AllowUserToAddRows = false;
            dtgMatricula.AllowUserToDeleteRows = false;
            dtgMatricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMatricula.Columns.AddRange(new DataGridViewColumn[] { ID_MATRICULA, ID_TURMA1, ID_ALUNO, SITUACAO, NOME_MODALIDADE1, NUMERO_TURMA1, MENSALIDADE, VENCIMENTO });
            dtgMatricula.Location = new Point(317, 124);
            dtgMatricula.Name = "dtgMatricula";
            dtgMatricula.ReadOnly = true;
            dtgMatricula.RowHeadersVisible = false;
            dtgMatricula.RowHeadersWidth = 51;
            dtgMatricula.Size = new Size(506, 188);
            dtgMatricula.TabIndex = 5;
            // 
            // ID_MATRICULA
            // 
            ID_MATRICULA.DataPropertyName = "ID_MATRICULA";
            ID_MATRICULA.HeaderText = "ID_MATRICULA";
            ID_MATRICULA.MinimumWidth = 6;
            ID_MATRICULA.Name = "ID_MATRICULA";
            ID_MATRICULA.ReadOnly = true;
            ID_MATRICULA.Visible = false;
            ID_MATRICULA.Width = 125;
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
            // SITUACAO
            // 
            SITUACAO.DataPropertyName = "SITUACAO";
            SITUACAO.HeaderText = "SITUACAO";
            SITUACAO.MinimumWidth = 6;
            SITUACAO.Name = "SITUACAO";
            SITUACAO.ReadOnly = true;
            SITUACAO.Width = 90;
            // 
            // NOME_MODALIDADE1
            // 
            NOME_MODALIDADE1.DataPropertyName = "NOME_MODALIDADE";
            NOME_MODALIDADE1.HeaderText = "MODALIDADE";
            NOME_MODALIDADE1.MinimumWidth = 6;
            NOME_MODALIDADE1.Name = "NOME_MODALIDADE1";
            NOME_MODALIDADE1.ReadOnly = true;
            NOME_MODALIDADE1.Width = 115;
            // 
            // NUMERO_TURMA1
            // 
            NUMERO_TURMA1.DataPropertyName = "NUMERO_TURMA";
            NUMERO_TURMA1.HeaderText = "TURMA";
            NUMERO_TURMA1.MinimumWidth = 6;
            NUMERO_TURMA1.Name = "NUMERO_TURMA1";
            NUMERO_TURMA1.ReadOnly = true;
            NUMERO_TURMA1.Width = 70;
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
            // VENCIMENTO
            // 
            VENCIMENTO.DataPropertyName = "VENCIMENTO";
            VENCIMENTO.HeaderText = "VENCIMENTO";
            VENCIMENTO.MinimumWidth = 6;
            VENCIMENTO.Name = "VENCIMENTO";
            VENCIMENTO.ReadOnly = true;
            VENCIMENTO.Width = 110;
            // 
            // dtgTurmasCadastradas
            // 
            dtgTurmasCadastradas.AllowUserToAddRows = false;
            dtgTurmasCadastradas.AllowUserToDeleteRows = false;
            dtgTurmasCadastradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTurmasCadastradas.Columns.AddRange(new DataGridViewColumn[] { ID_MODALIDADE, ID_TURMA, NOME_MODALIDADE, NUMERO_TURMA, VAGAS, MAXIMO_ALUNOS, btnHora });
            dtgTurmasCadastradas.Location = new Point(8, 318);
            dtgTurmasCadastradas.Name = "dtgTurmasCadastradas";
            dtgTurmasCadastradas.ReadOnly = true;
            dtgTurmasCadastradas.RowHeadersVisible = false;
            dtgTurmasCadastradas.RowHeadersWidth = 51;
            dtgTurmasCadastradas.Size = new Size(432, 263);
            dtgTurmasCadastradas.TabIndex = 5;
            dtgTurmasCadastradas.CellContentClick += dtgTurmasCadastradas_CellContentClick;
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
            // NOME_MODALIDADE
            // 
            NOME_MODALIDADE.DataPropertyName = "NOME_MODALIDADE";
            NOME_MODALIDADE.HeaderText = "MODALIDADE";
            NOME_MODALIDADE.MinimumWidth = 6;
            NOME_MODALIDADE.Name = "NOME_MODALIDADE";
            NOME_MODALIDADE.ReadOnly = true;
            NOME_MODALIDADE.Width = 125;
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
            MAXIMO_ALUNOS.HeaderText = "MAXIMO_ALUNOS";
            MAXIMO_ALUNOS.MinimumWidth = 6;
            MAXIMO_ALUNOS.Name = "MAXIMO_ALUNOS";
            MAXIMO_ALUNOS.ReadOnly = true;
            MAXIMO_ALUNOS.Visible = false;
            MAXIMO_ALUNOS.Width = 125;
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
            // tabPageMensalidade
            // 
            tabPageMensalidade.Controls.Add(dtgMensalidades);
            tabPageMensalidade.Controls.Add(groupBox4);
            tabPageMensalidade.Controls.Add(groupBox3);
            tabPageMensalidade.Controls.Add(groupBox2);
            tabPageMensalidade.Controls.Add(pictureBox4);
            tabPageMensalidade.Location = new Point(4, 29);
            tabPageMensalidade.Name = "tabPageMensalidade";
            tabPageMensalidade.Size = new Size(831, 589);
            tabPageMensalidade.TabIndex = 2;
            tabPageMensalidade.Text = "Mensalidade";
            tabPageMensalidade.UseVisualStyleBackColor = true;
            // 
            // dtgMensalidades
            // 
            dtgMensalidades.AllowUserToAddRows = false;
            dtgMensalidades.AllowUserToDeleteRows = false;
            dtgMensalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMensalidades.Columns.AddRange(new DataGridViewColumn[] { MODALIDADE1, VENCIMENTO2, DATA_PAGAMENTO, VALOR, SITUACAO_MENSALIDADE, STATUS_MENSALIDADE });
            dtgMensalidades.Location = new Point(8, 104);
            dtgMensalidades.Name = "dtgMensalidades";
            dtgMensalidades.ReadOnly = true;
            dtgMensalidades.RowHeadersVisible = false;
            dtgMensalidades.RowHeadersWidth = 51;
            dtgMensalidades.Size = new Size(817, 477);
            dtgMensalidades.TabIndex = 13;
            // 
            // MODALIDADE1
            // 
            MODALIDADE1.DataPropertyName = "NOME_MODALIDADE";
            MODALIDADE1.HeaderText = "MODALIDADE";
            MODALIDADE1.MinimumWidth = 6;
            MODALIDADE1.Name = "MODALIDADE1";
            MODALIDADE1.ReadOnly = true;
            MODALIDADE1.Width = 125;
            // 
            // VENCIMENTO2
            // 
            VENCIMENTO2.DataPropertyName = "DATA_VENCIMENTO";
            VENCIMENTO2.HeaderText = "VENCIMENTO";
            VENCIMENTO2.MinimumWidth = 6;
            VENCIMENTO2.Name = "VENCIMENTO2";
            VENCIMENTO2.ReadOnly = true;
            VENCIMENTO2.Width = 125;
            // 
            // DATA_PAGAMENTO
            // 
            DATA_PAGAMENTO.DataPropertyName = "DATA_PAGAMENTO";
            DATA_PAGAMENTO.HeaderText = "DATA DO PAGAMENTO";
            DATA_PAGAMENTO.MinimumWidth = 6;
            DATA_PAGAMENTO.Name = "DATA_PAGAMENTO";
            DATA_PAGAMENTO.ReadOnly = true;
            DATA_PAGAMENTO.Width = 125;
            // 
            // VALOR
            // 
            VALOR.DataPropertyName = "MENSALIDADE";
            VALOR.HeaderText = "VALOR";
            VALOR.MinimumWidth = 6;
            VALOR.Name = "VALOR";
            VALOR.ReadOnly = true;
            VALOR.Width = 125;
            // 
            // SITUACAO_MENSALIDADE
            // 
            SITUACAO_MENSALIDADE.DataPropertyName = "SITUACAO";
            SITUACAO_MENSALIDADE.HeaderText = "SITUACAO";
            SITUACAO_MENSALIDADE.MinimumWidth = 6;
            SITUACAO_MENSALIDADE.Name = "SITUACAO_MENSALIDADE";
            SITUACAO_MENSALIDADE.ReadOnly = true;
            SITUACAO_MENSALIDADE.Visible = false;
            SITUACAO_MENSALIDADE.Width = 125;
            // 
            // STATUS_MENSALIDADE
            // 
            STATUS_MENSALIDADE.DataPropertyName = "STATUS_MENSALIDADE";
            STATUS_MENSALIDADE.HeaderText = "SITUAÇÃO";
            STATUS_MENSALIDADE.MinimumWidth = 6;
            STATUS_MENSALIDADE.Name = "STATUS_MENSALIDADE";
            STATUS_MENSALIDADE.ReadOnly = true;
            STATUS_MENSALIDADE.Width = 125;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnPagamento);
            groupBox4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(631, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(194, 92);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Controle";
            // 
            // btnPagamento
            // 
            btnPagamento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagamento.Image = Properties.Resources.dinheiro;
            btnPagamento.ImageAlign = ContentAlignment.TopCenter;
            btnPagamento.Location = new Point(20, 30);
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Size = new Size(153, 52);
            btnPagamento.TabIndex = 13;
            btnPagamento.Text = "Pagamento";
            btnPagamento.TextAlign = ContentAlignment.BottomCenter;
            btnPagamento.UseVisualStyleBackColor = true;
            btnPagamento.Click += btnPagamento_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblAtraso);
            groupBox3.Controls.Add(label22);
            groupBox3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(461, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(164, 92);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalhes";
            // 
            // lblAtraso
            // 
            lblAtraso.BackColor = Color.CornflowerBlue;
            lblAtraso.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtraso.Location = new Point(6, 55);
            lblAtraso.Name = "lblAtraso";
            lblAtraso.Size = new Size(152, 25);
            lblAtraso.TabIndex = 14;
            lblAtraso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(0, 0, 192);
            label22.Location = new Point(6, 30);
            label22.Name = "label22";
            label22.Size = new Size(117, 22);
            label22.TabIndex = 12;
            label22.Text = "Total em atraso";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFiltro);
            groupBox2.Controls.Add(cboSituacaoMensalidade);
            groupBox2.Controls.Add(label21);
            groupBox2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(79, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 92);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtro";
            // 
            // btnFiltro
            // 
            btnFiltro.Image = Properties.Resources.icon_filtro;
            btnFiltro.Location = new Point(308, 37);
            btnFiltro.Name = "btnFiltro";
            btnFiltro.Size = new Size(62, 31);
            btnFiltro.TabIndex = 13;
            btnFiltro.UseVisualStyleBackColor = true;
            btnFiltro.Click += btnFiltro_Click;
            // 
            // cboSituacaoMensalidade
            // 
            cboSituacaoMensalidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituacaoMensalidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSituacaoMensalidade.FormattingEnabled = true;
            cboSituacaoMensalidade.Items.AddRange(new object[] { "Todas", "Pagas", "Pendentes" });
            cboSituacaoMensalidade.Location = new Point(97, 39);
            cboSituacaoMensalidade.Name = "cboSituacaoMensalidade";
            cboSituacaoMensalidade.Size = new Size(205, 27);
            cboSituacaoMensalidade.TabIndex = 12;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(6, 42);
            label21.Name = "label21";
            label21.Size = new Size(85, 21);
            label21.TabIndex = 11;
            label21.Text = "Situação:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pagamento;
            pictureBox4.Location = new Point(8, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // frmControleAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 622);
            Controls.Add(tcAluno);
            Name = "frmControleAlunos";
            Text = "SCA - Controle de Alunos";
            FormClosed += frmControleAlunos_FormClosed;
            Load += frmControleAlunos_Load;
            tcAluno.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTurmas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPageMatricula.ResumeLayout(false);
            tabPageMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMatricula).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgTurmasCadastradas).EndInit();
            tabPageMensalidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgMensalidades).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAluno;
        private TabPage tabPageCadastro;
        private TabPage tabPageMatricula;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSalvar;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnExcluir;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtCod;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private TextBox txtEndereco;
        private TextBox txtNome;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private MaskedTextBox mtbCpf;
        private MaskedTextBox mtbTel;
        private MaskedTextBox mtbCep;
        private ComboBox cboSexo;
        private TextBox txtObs;
        private PictureBox pictureBox2;
        private DataGridView dtgTurmas;
        private Label label14;
        private Label label12;
        private TextBox txtNumero;
        private Label label13;
        private GroupBox groupBox1;
        private DataGridView dtgMensalidades;
        private TextBox txtCodAluno;
        private TextBox txtNomeAluno;
        private Label label15;
        private DataGridView dtgMatricula;
        private DataGridView dtgTurmasCadastradas;
        private PictureBox pictureBox3;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label19;
        private Label lblSwitchSituacao;
        private Button btnSalvarMatricula;
        private Button btnExcluirMatricula;
        private Button btnIncluir;
        private DateTimePicker dtpVencimento;
        private Label lblMensagem;
        private DataGridViewTextBoxColumn ID_MODALIDADE;
        private DataGridViewTextBoxColumn ID_TURMA;
        private DataGridViewTextBoxColumn NOME_MODALIDADE;
        private DataGridViewTextBoxColumn NUMERO_TURMA;
        private DataGridViewTextBoxColumn VAGAS;
        private DataGridViewTextBoxColumn MAXIMO_ALUNOS;
        private DataGridViewImageColumn btnHora;
        private TabPage tabPageMensalidade;
        private PictureBox pictureBox4;
        private Label label21;
        private GroupBox groupBox2;
        private ComboBox cboSituacaoMensalidade;
        private Button btnFiltro;
        private GroupBox groupBox3;
        private Label label22;
        private GroupBox groupBox4;
        private Button btnPagamento;
        private DataGridViewTextBoxColumn ID_MATRICULA;
        private DataGridViewTextBoxColumn ID_TURMA1;
        private DataGridViewTextBoxColumn ID_ALUNO;
        private DataGridViewTextBoxColumn SITUACAO;
        private DataGridViewTextBoxColumn NOME_MODALIDADE1;
        private DataGridViewTextBoxColumn NUMERO_TURMA1;
        private DataGridViewTextBoxColumn MENSALIDADE;
        private DataGridViewTextBoxColumn VENCIMENTO;
        private DataGridViewTextBoxColumn SITUACAO1;
        private DataGridViewTextBoxColumn MODALIDADE;
        private DataGridViewTextBoxColumn TURMA;
        private DataGridViewTextBoxColumn MENSALIDADE1;
        private DataGridViewTextBoxColumn VENCIMENTO1;
        private Label lblAtraso;
        private DataGridViewTextBoxColumn MODALIDADE1;
        private DataGridViewTextBoxColumn VENCIMENTO2;
        private DataGridViewTextBoxColumn DATA_PAGAMENTO;
        private DataGridViewTextBoxColumn VALOR;
        private DataGridViewTextBoxColumn SITUACAO_MENSALIDADE;
        private DataGridViewTextBoxColumn STATUS_MENSALIDADE;
        private ToggleSwitch switchSituacao;
    }
}