namespace Academia
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlConteudo = new Panel();
            btnProfessor = new Button();
            pnlMenu = new Panel();
            pnlDecoração = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblCaixa = new Label();
            btnConfiguracao = new Button();
            btnCaixa = new Button();
            btnTurma = new Button();
            btnModalidade = new Button();
            btnAluno = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(243, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1143, 674);
            pnlConteudo.TabIndex = 1;
            // 
            // btnProfessor
            // 
            btnProfessor.Cursor = Cursors.Hand;
            btnProfessor.FlatAppearance.BorderSize = 0;
            btnProfessor.FlatStyle = FlatStyle.Flat;
            btnProfessor.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfessor.ForeColor = SystemColors.ControlDark;
            btnProfessor.Image = Properties.Resources.professoresIcon_cinza;
            btnProfessor.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfessor.Location = new Point(0, 198);
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Padding = new Padding(45, 0, 5, 0);
            btnProfessor.Size = new Size(243, 36);
            btnProfessor.TabIndex = 2;
            btnProfessor.Text = " Professores";
            btnProfessor.UseVisualStyleBackColor = true;
            btnProfessor.Click += btnProfessor_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(9, 0, 94);
            pnlMenu.Controls.Add(pnlDecoração);
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Controls.Add(lblCaixa);
            pnlMenu.Controls.Add(btnConfiguracao);
            pnlMenu.Controls.Add(btnCaixa);
            pnlMenu.Controls.Add(btnTurma);
            pnlMenu.Controls.Add(btnModalidade);
            pnlMenu.Controls.Add(btnAluno);
            pnlMenu.Controls.Add(btnProfessor);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(243, 674);
            pnlMenu.TabIndex = 3;
            // 
            // pnlDecoração
            // 
            pnlDecoração.BackColor = Color.White;
            pnlDecoração.Location = new Point(0, 249);
            pnlDecoração.Name = "pnlDecoração";
            pnlDecoração.Size = new Size(5, 36);
            pnlDecoração.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 649);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 5;
            label2.Text = "V 0.0.1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 575);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 5;
            label1.Text = "CAIXA";
            // 
            // lblCaixa
            // 
            lblCaixa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCaixa.AutoSize = true;
            lblCaixa.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaixa.ForeColor = SystemColors.ControlText;
            lblCaixa.Location = new Point(105, 575);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(0, 28);
            lblCaixa.TabIndex = 5;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.Cursor = Cursors.Hand;
            btnConfiguracao.FlatAppearance.BorderSize = 0;
            btnConfiguracao.FlatStyle = FlatStyle.Flat;
            btnConfiguracao.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracao.ForeColor = SystemColors.ControlDark;
            btnConfiguracao.Image = Properties.Resources.configuracaoIcon_cinza;
            btnConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracao.Location = new Point(0, 453);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Padding = new Padding(45, 0, 0, 0);
            btnConfiguracao.Size = new Size(243, 36);
            btnConfiguracao.TabIndex = 2;
            btnConfiguracao.Text = "   Configurações";
            btnConfiguracao.UseVisualStyleBackColor = true;
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // btnCaixa
            // 
            btnCaixa.Cursor = Cursors.Hand;
            btnCaixa.FlatAppearance.BorderSize = 0;
            btnCaixa.FlatStyle = FlatStyle.Flat;
            btnCaixa.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCaixa.ForeColor = SystemColors.ControlDark;
            btnCaixa.Image = Properties.Resources.caixaIcon_cinza;
            btnCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaixa.Location = new Point(0, 402);
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Padding = new Padding(45, 0, 48, 0);
            btnCaixa.Size = new Size(243, 36);
            btnCaixa.TabIndex = 2;
            btnCaixa.Text = "Caixa";
            btnCaixa.UseVisualStyleBackColor = true;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // btnTurma
            // 
            btnTurma.Cursor = Cursors.Hand;
            btnTurma.FlatAppearance.BorderSize = 0;
            btnTurma.FlatStyle = FlatStyle.Flat;
            btnTurma.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTurma.ForeColor = SystemColors.ControlDark;
            btnTurma.Image = Properties.Resources.turmasIcon_cinza;
            btnTurma.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurma.Location = new Point(0, 351);
            btnTurma.Name = "btnTurma";
            btnTurma.Padding = new Padding(45, 0, 48, 0);
            btnTurma.Size = new Size(243, 36);
            btnTurma.TabIndex = 2;
            btnTurma.Text = "  Turmas";
            btnTurma.UseVisualStyleBackColor = true;
            btnTurma.Click += btnTurma_Click;
            // 
            // btnModalidade
            // 
            btnModalidade.Cursor = Cursors.Hand;
            btnModalidade.FlatAppearance.BorderSize = 0;
            btnModalidade.FlatStyle = FlatStyle.Flat;
            btnModalidade.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModalidade.ForeColor = SystemColors.ControlDark;
            btnModalidade.Image = Properties.Resources.modalidadesIcon_cinza;
            btnModalidade.ImageAlign = ContentAlignment.MiddleLeft;
            btnModalidade.Location = new Point(0, 300);
            btnModalidade.Name = "btnModalidade";
            btnModalidade.Padding = new Padding(45, 0, 3, 0);
            btnModalidade.Size = new Size(243, 36);
            btnModalidade.TabIndex = 2;
            btnModalidade.Text = "  Modalidades";
            btnModalidade.UseVisualStyleBackColor = true;
            btnModalidade.Click += btnModalidade_Click;
            // 
            // btnAluno
            // 
            btnAluno.Cursor = Cursors.Hand;
            btnAluno.FlatAppearance.BorderSize = 0;
            btnAluno.FlatStyle = FlatStyle.Flat;
            btnAluno.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluno.ForeColor = SystemColors.ButtonHighlight;
            btnAluno.Image = Properties.Resources.alunosIcon_branco;
            btnAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnAluno.Location = new Point(0, 249);
            btnAluno.Name = "btnAluno";
            btnAluno.Padding = new Padding(45, 0, 48, 0);
            btnAluno.Size = new Size(243, 36);
            btnAluno.TabIndex = 2;
            btnAluno.Text = "  Alunos";
            btnAluno.UseVisualStyleBackColor = true;
            btnAluno.Click += btnAluno_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 674);
            Controls.Add(pnlConteudo);
            Controls.Add(pnlMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCA - Sistema de Controle de Academia";
            Load += frmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlConteudo;
        private Button btnProfessor;
        private Panel pnlMenu;
        private Button btnModalidade;
        private Button btnAluno;
        private Button btnConfiguracao;
        private Button btnCaixa;
        private Button btnTurma;
        private Label lblCaixa;
        private Panel pnlDecoração;
        private Label label1;
        private Label label2;
    }
}
