namespace primeiroApp
{
    partial class frmTabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuada));
            label1 = new Label();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            txtTabuada = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(308, 21);
            label1.TabIndex = 0;
            label1.Text = "Informe qual tabuada deseja calcular:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(326, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(92, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(24, 96);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 46);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(24, 178);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(103, 46);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtTabuada
            // 
            txtTabuada.Location = new Point(191, 96);
            txtTabuada.Multiline = true;
            txtTabuada.Name = "txtTabuada";
            txtTabuada.Size = new Size(286, 301);
            txtTabuada.TabIndex = 4;
            // 
            // frmTabuada
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 420);
            Controls.Add(txtTabuada);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTabuada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnCalcular;
        private Button btnLimpar;
        private TextBox txtTabuada;
    }
}