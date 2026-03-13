namespace Academia
{
    partial class frmAlunos
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
            label1 = new Label();
            label2 = new Label();
            txtPesquisa = new TextBox();
            btnAdicionar = new Button();
            rbNome = new RadioButton();
            pictureBox1 = new PictureBox();
            rbCpf = new RadioButton();
            label3 = new Label();
            dtgAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 12);
            label1.Name = "label1";
            label1.Size = new Size(285, 33);
            label1.TabIndex = 0;
            label1.Text = "Alunos Cadastrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(129, 67);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 0;
            label2.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(239, 66);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(402, 27);
            txtPesquisa.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.adicionar_aluno;
            btnAdicionar.ImageAlign = ContentAlignment.TopCenter;
            btnAdicionar.Location = new Point(647, 62);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(141, 63);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar aluno";
            btnAdicionar.TextAlign = ContentAlignment.BottomCenter;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // rbNome
            // 
            rbNome.AutoSize = true;
            rbNome.Location = new Point(239, 99);
            rbNome.Name = "rbNome";
            rbNome.Size = new Size(71, 24);
            rbNome.TabIndex = 3;
            rbNome.TabStop = true;
            rbNome.Text = "Nome";
            rbNome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.alunos;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // rbCpf
            // 
            rbCpf.AutoSize = true;
            rbCpf.Location = new Point(327, 99);
            rbCpf.Name = "rbCpf";
            rbCpf.Size = new Size(54, 24);
            rbCpf.TabIndex = 3;
            rbCpf.TabStop = true;
            rbCpf.Text = "CPF";
            rbCpf.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(509, 19);
            label3.TabIndex = 5;
            label3.Text = "Para editar as informações dos alunos, dê um duplo clique sobre ele";
            // 
            // dtgAlunos
            // 
            dtgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlunos.Location = new Point(12, 173);
            dtgAlunos.Name = "dtgAlunos";
            dtgAlunos.RowHeadersWidth = 51;
            dtgAlunos.Size = new Size(776, 343);
            dtgAlunos.TabIndex = 6;
            // 
            // frmAlunos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(dtgAlunos);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(rbCpf);
            Controls.Add(rbNome);
            Controls.Add(btnAdicionar);
            Controls.Add(txtPesquisa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlunos";
            Text = "SCA - Alunos Cadastrados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPesquisa;
        private Button btnAdicionar;
        private Button button1;
        private RadioButton rbNome;
        private PictureBox pictureBox1;
        private RadioButton rbCpf;
        private Label label3;
        private DataGridView dtgAlunos;
    }
}