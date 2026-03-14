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
            tcAluno.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTurmas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tcAluno
            // 
            tcAluno.Controls.Add(tabPageCadastro);
            tcAluno.Controls.Add(tabPageMatricula);
            tcAluno.Dock = DockStyle.Fill;
            tcAluno.Location = new Point(0, 0);
            tcAluno.Name = "tcAluno";
            tcAluno.SelectedIndex = 0;
            tcAluno.Size = new Size(950, 622);
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
            tabPageCadastro.Size = new Size(942, 589);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // dtgTurmas
            // 
            dtgTurmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTurmas.Location = new Point(8, 327);
            dtgTurmas.Name = "dtgTurmas";
            dtgTurmas.RowHeadersWidth = 51;
            dtgTurmas.Size = new Size(588, 254);
            dtgTurmas.TabIndex = 6;
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
            // 
            // mtbCep
            // 
            mtbCep.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbCep.Location = new Point(527, 243);
            mtbCep.Mask = "99999-999";
            mtbCep.Name = "mtbCep";
            mtbCep.Size = new Size(91, 27);
            mtbCep.TabIndex = 4;
            // 
            // mtbCpf
            // 
            mtbCpf.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbCpf.Location = new Point(312, 276);
            mtbCpf.Mask = "999,999,999-99";
            mtbCpf.Name = "mtbCpf";
            mtbCpf.Size = new Size(126, 27);
            mtbCpf.TabIndex = 4;
            // 
            // mtbTel
            // 
            mtbTel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbTel.Location = new Point(112, 276);
            mtbTel.Mask = "(99) 99999-9999";
            mtbTel.Name = "mtbTel";
            mtbTel.Size = new Size(135, 27);
            mtbTel.TabIndex = 4;
            // 
            // txtObs
            // 
            txtObs.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObs.Location = new Point(622, 177);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(312, 126);
            txtObs.TabIndex = 3;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(112, 243);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(77, 27);
            txtNumero.TabIndex = 3;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(279, 243);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(182, 27);
            txtCidade.TabIndex = 3;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(437, 210);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(181, 27);
            txtBairro.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(112, 210);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(243, 27);
            txtEndereco.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(112, 177);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(506, 27);
            txtNome.TabIndex = 3;
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCod.Location = new Point(112, 144);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(93, 27);
            txtCod.TabIndex = 3;
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
            label14.Location = new Point(668, 374);
            label14.Name = "label14";
            label14.Size = new Size(242, 19);
            label14.TabIndex = 2;
            label14.Text = "- Onde o aluno está matrículado";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(668, 347);
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
            pictureBox2.Location = new Point(602, 327);
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
            toolStrip1.Size = new Size(936, 39);
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
            // 
            // tabPageMatricula
            // 
            tabPageMatricula.Location = new Point(4, 29);
            tabPageMatricula.Name = "tabPageMatricula";
            tabPageMatricula.Padding = new Padding(3);
            tabPageMatricula.Size = new Size(942, 589);
            tabPageMatricula.TabIndex = 1;
            tabPageMatricula.Text = "Matrícula";
            tabPageMatricula.UseVisualStyleBackColor = true;
            // 
            // frmControleAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 622);
            Controls.Add(tcAluno);
            Name = "frmControleAlunos";
            Text = "SCA - Controle de Alunos";
            tcAluno.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTurmas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
    }
}