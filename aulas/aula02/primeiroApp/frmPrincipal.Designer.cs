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
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensagem.Location = new Point(127, 34);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 42);
            lblMensagem.TabIndex = 0;
            // 
            // btnMostrarMensagem
            // 
            btnMostrarMensagem.BackColor = SystemColors.Desktop;
            btnMostrarMensagem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarMensagem.ForeColor = Color.Magenta;
            btnMostrarMensagem.Location = new Point(196, 351);
            btnMostrarMensagem.Name = "btnMostrarMensagem";
            btnMostrarMensagem.Size = new Size(213, 44);
            btnMostrarMensagem.TabIndex = 1;
            btnMostrarMensagem.Text = "Mostrar Mensagem";
            btnMostrarMensagem.UseVisualStyleBackColor = false;
            btnMostrarMensagem.Click += btnMostrarMensagem_Click;
            // 
            // btnPropriedadesCheckBox
            // 
            btnPropriedadesCheckBox.BackColor = SystemColors.Desktop;
            btnPropriedadesCheckBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPropriedadesCheckBox.ForeColor = Color.Magenta;
            btnPropriedadesCheckBox.Location = new Point(437, 351);
            btnPropriedadesCheckBox.Name = "btnPropriedadesCheckBox";
            btnPropriedadesCheckBox.Size = new Size(130, 44);
            btnPropriedadesCheckBox.TabIndex = 2;
            btnPropriedadesCheckBox.Text = "CheckBox";
            btnPropriedadesCheckBox.UseVisualStyleBackColor = false;
            btnPropriedadesCheckBox.Click += btnPropriedadesCheckBox_Click;
            // 
            // btnImagens
            // 
            btnImagens.BackColor = SystemColors.Desktop;
            btnImagens.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImagens.ForeColor = Color.Magenta;
            btnImagens.Location = new Point(584, 351);
            btnImagens.Name = "btnImagens";
            btnImagens.Size = new Size(130, 44);
            btnImagens.TabIndex = 3;
            btnImagens.Text = "Imagens";
            btnImagens.UseVisualStyleBackColor = false;
            btnImagens.Click += btnImagens_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensagem;
        private Button btnMostrarMensagem;
        private Button btnPropriedadesCheckBox;
        private Button btnImagens;
    }
}
