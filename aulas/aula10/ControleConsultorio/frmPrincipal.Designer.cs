namespace ControleConsultorio
{
    partial class frmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMedicos = new System.Windows.Forms.ToolStripButton();
            this.btnPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConsultas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPesquisas = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMedicos,
            this.btnPacientes,
            this.toolStripSeparator2,
            this.btnConsultas,
            this.toolStripSeparator1,
            this.btnPesquisas,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(937, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMedicos
            // 
            this.btnMedicos.Image = global::ControleConsultorio.Properties.Resources.medico;
            this.btnMedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(69, 56);
            this.btnMedicos.Text = "Médicos";
            this.btnMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Image = global::ControleConsultorio.Properties.Resources.paciente;
            this.btnPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(74, 56);
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Image = global::ControleConsultorio.Properties.Resources.consulta;
            this.btnConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(76, 56);
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // btnPesquisas
            // 
            this.btnPesquisas.Image = global::ControleConsultorio.Properties.Resources.pesquisa;
            this.btnPesquisas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPesquisas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisas.Name = "btnPesquisas";
            this.btnPesquisas.Size = new System.Drawing.Size(75, 56);
            this.btnPesquisas.Text = "Pesquisas";
            this.btnPesquisas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisas.Click += new System.EventHandler(this.btnPesquisas_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFechar.Image = global::ControleConsultorio.Properties.Resources.fechar;
            this.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(56, 56);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.Transparent;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 59);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(937, 547);
            this.pnlConteudo.TabIndex = 2;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(0, 59);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(937, 547);
            this.pnlLogo.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 606);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle para Consultório";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMedicos;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.ToolStripButton btnPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.ToolStripButton btnConsultas;
        private System.Windows.Forms.ToolStripButton btnPesquisas;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

