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
            btnMostrarMensagem.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarMensagem.Location = new Point(308, 344);
            btnMostrarMensagem.Name = "btnMostrarMensagem";
            btnMostrarMensagem.Size = new Size(187, 44);
            btnMostrarMensagem.TabIndex = 1;
            btnMostrarMensagem.Text = "Mostrar Mensagem";
            btnMostrarMensagem.UseVisualStyleBackColor = true;
            btnMostrarMensagem.Click += btnMostrarMensagem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
