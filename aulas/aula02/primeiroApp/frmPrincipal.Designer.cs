namespace primeiroApp
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
            lblMensagem = new Label();
            btnMostrarMensagem = new Button();
            btnPropriedadesCheckBox = new Button();
            btnImagens = new Button();
            btnTabuada = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.ForeColor = Color.Black;
            lblMensagem.Location = new Point(35, 222);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 32);
            lblMensagem.TabIndex = 0;
            // 
            // btnMostrarMensagem
            // 
            btnMostrarMensagem.BackColor = Color.White;
            btnMostrarMensagem.Font = new Font("Arial", 10.8F);
            btnMostrarMensagem.ForeColor = Color.Black;
            btnMostrarMensagem.Location = new Point(140, 365);
            btnMostrarMensagem.Name = "btnMostrarMensagem";
            btnMostrarMensagem.Size = new Size(213, 50);
            btnMostrarMensagem.TabIndex = 1;
            btnMostrarMensagem.Text = "Mostrar Mensagem";
            btnMostrarMensagem.UseVisualStyleBackColor = false;
            btnMostrarMensagem.Click += btnMostrarMensagem_Click;
            // 
            // btnPropriedadesCheckBox
            // 
            btnPropriedadesCheckBox.BackColor = Color.White;
            btnPropriedadesCheckBox.Enabled = false;
            btnPropriedadesCheckBox.Font = new Font("Arial", 10.8F);
            btnPropriedadesCheckBox.ForeColor = Color.Black;
            btnPropriedadesCheckBox.Image = Properties.Resources.check;
            btnPropriedadesCheckBox.ImageAlign = ContentAlignment.TopCenter;
            btnPropriedadesCheckBox.Location = new Point(22, 21);
            btnPropriedadesCheckBox.Name = "btnPropriedadesCheckBox";
            btnPropriedadesCheckBox.Size = new Size(130, 100);
            btnPropriedadesCheckBox.TabIndex = 2;
            btnPropriedadesCheckBox.Text = "CheckBox";
            btnPropriedadesCheckBox.TextAlign = ContentAlignment.BottomCenter;
            btnPropriedadesCheckBox.UseVisualStyleBackColor = false;
            btnPropriedadesCheckBox.Click += btnPropriedadesCheckBox_Click;
            // 
            // btnImagens
            // 
            btnImagens.BackColor = Color.White;
            btnImagens.Enabled = false;
            btnImagens.Font = new Font("Arial", 10.8F);
            btnImagens.ForeColor = Color.Black;
            btnImagens.Image = Properties.Resources.gallery;
            btnImagens.ImageAlign = ContentAlignment.TopCenter;
            btnImagens.Location = new Point(183, 21);
            btnImagens.Name = "btnImagens";
            btnImagens.Size = new Size(130, 100);
            btnImagens.TabIndex = 3;
            btnImagens.Text = "Imagens";
            btnImagens.TextAlign = ContentAlignment.BottomCenter;
            btnImagens.UseVisualStyleBackColor = false;
            btnImagens.Click += btnImagens_Click;
            // 
            // btnTabuada
            // 
            btnTabuada.BackColor = Color.White;
            btnTabuada.Enabled = false;
            btnTabuada.Font = new Font("Arial", 10.8F);
            btnTabuada.ForeColor = Color.Black;
            btnTabuada.Image = Properties.Resources.tabuada;
            btnTabuada.ImageAlign = ContentAlignment.TopCenter;
            btnTabuada.Location = new Point(347, 21);
            btnTabuada.Name = "btnTabuada";
            btnTabuada.Size = new Size(130, 100);
            btnTabuada.TabIndex = 4;
            btnTabuada.Text = "Tabuada";
            btnTabuada.TextAlign = ContentAlignment.BottomCenter;
            btnTabuada.UseVisualStyleBackColor = false;
            btnTabuada.Click += btnTabuada_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(498, 450);
            Controls.Add(btnTabuada);
            Controls.Add(btnImagens);
            Controls.Add(btnPropriedadesCheckBox);
            Controls.Add(btnMostrarMensagem);
            Controls.Add(lblMensagem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primeiro Aplicativo em C-Sharp";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Button btnMostrarMensagem;
        private Button btnPropriedadesCheckBox;
        private Button btnImagens;
        private Button btnTabuada;
    }
}
