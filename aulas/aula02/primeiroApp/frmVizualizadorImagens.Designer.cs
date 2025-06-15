namespace primeiroApp
{
    partial class frmVizualizadorImagens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVizualizadorImagens));
            pictureBox1 = new PictureBox();
            pbImagens = new PictureBox();
            rbStretch = new RadioButton();
            btnLimpaImagem = new Button();
            btnMostraImagem = new Button();
            ofdImagens = new OpenFileDialog();
            rbNormal = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImagens).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbImagens
            // 
            pbImagens.Image = (Image)resources.GetObject("pbImagens.Image");
            pbImagens.Location = new Point(34, 22);
            pbImagens.Name = "pbImagens";
            pbImagens.Size = new Size(748, 427);
            pbImagens.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagens.TabIndex = 1;
            pbImagens.TabStop = false;
            // 
            // rbStretch
            // 
            rbStretch.AutoSize = true;
            rbStretch.Checked = true;
            rbStretch.Location = new Point(478, 546);
            rbStretch.Name = "rbStretch";
            rbStretch.Size = new Size(76, 24);
            rbStretch.TabIndex = 3;
            rbStretch.TabStop = true;
            rbStretch.Text = "Stretch";
            rbStretch.UseVisualStyleBackColor = true;
            rbStretch.CheckedChanged += rbStretch_CheckedChanged;
            // 
            // btnLimpaImagem
            // 
            btnLimpaImagem.Location = new Point(247, 534);
            btnLimpaImagem.Name = "btnLimpaImagem";
            btnLimpaImagem.Size = new Size(166, 49);
            btnLimpaImagem.TabIndex = 4;
            btnLimpaImagem.Text = "Limpar imagem";
            btnLimpaImagem.UseVisualStyleBackColor = true;
            btnLimpaImagem.Click += btnLimpaImagem_Click;
            // 
            // btnMostraImagem
            // 
            btnMostraImagem.Location = new Point(34, 534);
            btnMostraImagem.Name = "btnMostraImagem";
            btnMostraImagem.Size = new Size(158, 49);
            btnMostraImagem.TabIndex = 5;
            btnMostraImagem.Text = "Mostrar imagem";
            btnMostraImagem.UseVisualStyleBackColor = true;
            btnMostraImagem.Click += btnMostraImagem_Click;
            // 
            // ofdImagens
            // 
            ofdImagens.FileName = "nome do arquivo";
            ofdImagens.Filter = "Images Files (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF| All Files (*.*)|*.*";
            ofdImagens.Title = "Selecione a imagem";
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(594, 546);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(80, 24);
            rbNormal.TabIndex = 2;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // frmVizualizadorImagens
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 605);
            Controls.Add(rbNormal);
            Controls.Add(btnMostraImagem);
            Controls.Add(btnLimpaImagem);
            Controls.Add(rbStretch);
            Controls.Add(pbImagens);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmVizualizadorImagens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vizualizador de imagens";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImagens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbImagens;
        private RadioButton rbStretch;
        private Button btnLimpaImagem;
        private Button btnMostraImagem;
        private OpenFileDialog ofdImagens;
        private RadioButton rbNormal;
    }
}