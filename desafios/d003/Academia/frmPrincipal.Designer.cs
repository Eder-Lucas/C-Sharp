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
            toolStripButton5 = new ToolStripButton();
            btnAlunos = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnModalidades = new ToolStripButton();
            btnTurmas = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnCaixa = new ToolStripButton();
            btnRelatorioCaixa = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton5, btnAlunos, toolStripSeparator1, btnModalidades, btnTurmas, toolStripSeparator2, btnCaixa, btnRelatorioCaixa, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 59);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.icon_professores;
            toolStripButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(88, 56);
            toolStripButton5.Text = "Professores";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
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
            // 
            // btnRelatorioCaixa
            // 
            btnRelatorioCaixa.Image = Properties.Resources.icon_relatorioCaixa;
            btnRelatorioCaixa.ImageScaling = ToolStripItemImageScaling.None;
            btnRelatorioCaixa.ImageTransparentColor = Color.Magenta;
            btnRelatorioCaixa.Name = "btnRelatorioCaixa";
            btnRelatorioCaixa.Size = new Size(135, 56);
            btnRelatorioCaixa.Text = "Relatório de Caixa";
            btnRelatorioCaixa.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 59);
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "SCA - Sistema de Controle de Academia";
            Load += frmPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnRelatorioCaixa;
        private ToolStripButton toolStripButton5;
        private ToolStripButton btnAlunos;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnModalidades;
        private ToolStripButton btnTurmas;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnCaixa;
        private ToolStripSeparator toolStripSeparator3;
    }
}
