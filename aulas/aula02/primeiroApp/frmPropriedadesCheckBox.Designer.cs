namespace primeiroApp
{
    partial class frmPropriedadesCheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPropriedadesCheckBox));
            chkPessoaFisica = new CheckBox();
            chkPessoaJuridica = new CheckBox();
            pnlPessoaFisica = new Panel();
            textBox2 = new TextBox();
            lblCpf = new Label();
            textBox1 = new TextBox();
            lblNomeFisica = new Label();
            pnlPessoaJuridica = new Panel();
            lblNomeJuridica = new Label();
            textBox3 = new TextBox();
            lblCnpj = new Label();
            textBox4 = new TextBox();
            pnlPessoaFisica.SuspendLayout();
            pnlPessoaJuridica.SuspendLayout();
            SuspendLayout();
            // 
            // chkPessoaFisica
            // 
            chkPessoaFisica.AutoSize = true;
            chkPessoaFisica.Font = new Font("Arial", 10.8F);
            chkPessoaFisica.Location = new Point(77, 93);
            chkPessoaFisica.Name = "chkPessoaFisica";
            chkPessoaFisica.Size = new Size(139, 25);
            chkPessoaFisica.TabIndex = 0;
            chkPessoaFisica.Text = "Pessoa física";
            chkPessoaFisica.UseVisualStyleBackColor = true;
            chkPessoaFisica.CheckStateChanged += chkPessoaFisica_CheckStateChanged;
            // 
            // chkPessoaJuridica
            // 
            chkPessoaJuridica.AutoSize = true;
            chkPessoaJuridica.Font = new Font("Arial", 10.8F);
            chkPessoaJuridica.Location = new Point(76, 155);
            chkPessoaJuridica.Name = "chkPessoaJuridica";
            chkPessoaJuridica.Size = new Size(155, 25);
            chkPessoaJuridica.TabIndex = 1;
            chkPessoaJuridica.Text = "Pessoa jurídica";
            chkPessoaJuridica.UseVisualStyleBackColor = true;
            chkPessoaJuridica.CheckStateChanged += chkPessoaJuridica_CheckStateChanged;
            // 
            // pnlPessoaFisica
            // 
            pnlPessoaFisica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaFisica.Controls.Add(textBox2);
            pnlPessoaFisica.Controls.Add(lblCpf);
            pnlPessoaFisica.Controls.Add(textBox1);
            pnlPessoaFisica.Controls.Add(lblNomeFisica);
            pnlPessoaFisica.Font = new Font("Arial", 10.8F);
            pnlPessoaFisica.Location = new Point(391, 48);
            pnlPessoaFisica.Name = "pnlPessoaFisica";
            pnlPessoaFisica.Size = new Size(287, 151);
            pnlPessoaFisica.TabIndex = 2;
            pnlPessoaFisica.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 10.8F);
            textBox2.Location = new Point(98, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 28);
            textBox2.TabIndex = 3;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 10.8F);
            lblCpf.Location = new Point(30, 85);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(51, 21);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 10.8F);
            textBox1.Location = new Point(98, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 28);
            textBox1.TabIndex = 1;
            // 
            // lblNomeFisica
            // 
            lblNomeFisica.AutoSize = true;
            lblNomeFisica.Font = new Font("Arial", 10.8F);
            lblNomeFisica.Location = new Point(30, 33);
            lblNomeFisica.Name = "lblNomeFisica";
            lblNomeFisica.Size = new Size(62, 21);
            lblNomeFisica.TabIndex = 0;
            lblNomeFisica.Text = "Nome:";
            // 
            // pnlPessoaJuridica
            // 
            pnlPessoaJuridica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaJuridica.Controls.Add(lblNomeJuridica);
            pnlPessoaJuridica.Controls.Add(textBox3);
            pnlPessoaJuridica.Controls.Add(lblCnpj);
            pnlPessoaJuridica.Controls.Add(textBox4);
            pnlPessoaJuridica.Font = new Font("Arial", 10.8F);
            pnlPessoaJuridica.Location = new Point(391, 238);
            pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            pnlPessoaJuridica.Size = new Size(287, 151);
            pnlPessoaJuridica.TabIndex = 4;
            pnlPessoaJuridica.Visible = false;
            // 
            // lblNomeJuridica
            // 
            lblNomeJuridica.AutoSize = true;
            lblNomeJuridica.Font = new Font("Arial", 10.8F);
            lblNomeJuridica.Location = new Point(30, 30);
            lblNomeJuridica.Name = "lblNomeJuridica";
            lblNomeJuridica.Size = new Size(62, 21);
            lblNomeJuridica.TabIndex = 4;
            lblNomeJuridica.Text = "Nome:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 10.8F);
            textBox3.Location = new Point(98, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 28);
            textBox3.TabIndex = 3;
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Font = new Font("Arial", 10.8F);
            lblCnpj.Location = new Point(30, 85);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(62, 21);
            lblCnpj.TabIndex = 2;
            lblCnpj.Text = "CNPJ:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 10.8F);
            textBox4.Location = new Point(98, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 28);
            textBox4.TabIndex = 1;
            // 
            // frmPropriedadesCheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPessoaJuridica);
            Controls.Add(pnlPessoaFisica);
            Controls.Add(chkPessoaJuridica);
            Controls.Add(chkPessoaFisica);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPropriedadesCheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Propriedades do CheckBox";
            pnlPessoaFisica.ResumeLayout(false);
            pnlPessoaFisica.PerformLayout();
            pnlPessoaJuridica.ResumeLayout(false);
            pnlPessoaJuridica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPessoaFisica;
        private CheckBox chkPessoaJuridica;
        private Panel pnlPessoaFisica;
        private Label lblNomeFisica;
        private TextBox textBox1;
        private Label lblCpf;
        private TextBox textBox2;
        private Panel pnlPessoaJuridica;
        private TextBox textBox3;
        private Label lblCnpj;
        private TextBox textBox4;
        private Label lblNomeJuridica;
    }
}