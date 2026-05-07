namespace Academia
{
    partial class ucHome
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
            pbHome = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbHome).BeginInit();
            SuspendLayout();
            // 
            // pbHome
            // 
            pbHome.BackColor = Color.MediumPurple;
            pbHome.BackgroundImageLayout = ImageLayout.Stretch;
            pbHome.Dock = DockStyle.Fill;
            pbHome.Image = Properties.Resources.home;
            pbHome.Location = new Point(0, 0);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(1920, 1200);
            pbHome.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHome.TabIndex = 2;
            pbHome.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(1789, 1172);
            label3.Name = "label3";
            label3.Size = new Size(119, 16);
            label3.TabIndex = 7;
            label3.Text = "By Cactus System";
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(pbHome);
            Name = "ucHome";
            Size = new Size(1920, 1200);
            ((System.ComponentModel.ISupportInitialize)pbHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHome;
        private Label label3;
    }
}
