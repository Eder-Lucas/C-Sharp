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
            toolStrip1 = new ToolStrip();
            btnProfessor = new ToolStripButton();
            btnAlunos = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnModalidades = new ToolStripButton();
            btnTurmas = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCaixa = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            btnConfig = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnProfessor, btnAlunos, toolStripSeparator1, btnModalidades, btnTurmas, toolStripSeparator2, btnCaixa, toolStripButton2, btnConfig });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 59);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnProfessor
            // 
            btnProfessor.Image = Properties.Resources.icon_professores;
            btnProfessor.ImageScaling = ToolStripItemImageScaling.None;
            btnProfessor.ImageTransparentColor = Color.Magenta;
            btnProfessor.Name = "btnProfessor";
            btnProfessor.Size = new Size(88, 56);
            btnProfessor.Text = "Professores";
            btnProfessor.TextImageRelation = TextImageRelation.ImageAboveText;
            btnProfessor.Click += btnProfessor_Click;
            // 
            // btnAlunos
            // 
            btnAlunos.Image = Properties.Resources.icon_alunos;
            btnAlunos.ImageScaling = ToolStripItemImageScaling.None;
            btnAlunos.ImageTransparentColor = Color.Magenta;
            btnAlunos.Name = "btnAlunos";
            btnAlunos.Size = new Size(58, 56);
            btnAlunos.Text = "Alunos";
            btnAlunos.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAlunos.Click += btnAlunos_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // btnModalidades
            // 
            btnModalidades.Image = Properties.Resources.icon_modalidades;
            btnModalidades.ImageScaling = ToolStripItemImageScaling.None;
            btnModalidades.ImageTransparentColor = Color.Magenta;
            btnModalidades.Name = "btnModalidades";
            btnModalidades.Size = new Size(100, 56);
            btnModalidades.Text = "Modalidades";
            btnModalidades.TextImageRelation = TextImageRelation.ImageAboveText;
            btnModalidades.Click += btnModalidades_Click;
            // 
            // btnTurmas
            // 
            btnTurmas.Image = Properties.Resources.icon_turma;
            btnTurmas.ImageScaling = ToolStripItemImageScaling.None;
            btnTurmas.ImageTransparentColor = Color.Magenta;
            btnTurmas.Name = "btnTurmas";
            btnTurmas.Size = new Size(61, 56);
            btnTurmas.Text = "Turmas";
            btnTurmas.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTurmas.Click += btnTurmas_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 59);
            // 
            // btnCaixa
            // 
            btnCaixa.Image = Properties.Resources.icon_caixa;
            btnCaixa.ImageScaling = ToolStripItemImageScaling.None;
            btnCaixa.ImageTransparentColor = Color.Magenta;
            btnCaixa.Name = "btnCaixa";
            btnCaixa.Size = new Size(49, 56);
            btnCaixa.Text = "Caixa";
            btnCaixa.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCaixa.Click += btnCaixa_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.icon_relatorioCaixa;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(135, 56);
            toolStripButton2.Text = "Relatório de Caixa";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnConfig
            // 
            btnConfig.Alignment = ToolStripItemAlignment.Right;
            btnConfig.Image = Properties.Resources.configuracoes;
            btnConfig.ImageScaling = ToolStripItemImageScaling.None;
            btnConfig.ImageTransparentColor = Color.Magenta;
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(108, 56);
            btnConfig.Text = "Configurações";
            btnConfig.TextImageRelation = TextImageRelation.ImageAboveText;
            btnConfig.Click += btnConfig_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCA - Sistema de Controle de Academia";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnProfessor;
        private ToolStripButton btnAlunos;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnModalidades;
        private ToolStripButton btnTurmas;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnCaixa;
        private ToolStripButton toolStripButton2;
        private ToolStripButton btnConfig;
    }
}
