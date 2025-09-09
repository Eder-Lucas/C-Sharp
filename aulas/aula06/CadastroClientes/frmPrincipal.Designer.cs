namespace CadastroClientes
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
            painelPessoaJuridica = new Panel();
            txtEnderecoPessoaJuridica = new TextBox();
            txtNomePessoaJuridica = new TextBox();
            txtCNPJ = new TextBox();
            label1 = new Label();
            lblEnderecoPessoaJuridica = new Label();
            lblNomePessoaJuridica = new Label();
            txtPessoaJuridica = new TextBox();
            lbl_IE = new Label();
            txt_IE = new TextBox();
            painelPessoaFisica = new Panel();
            txtEnderecoPessoaFisica = new TextBox();
            txtNomePessoaFisica = new TextBox();
            txtCPF = new TextBox();
            lblCpf = new Label();
            lblEnderecoPessoaFisica = new Label();
            lblNomePessoaFisica = new Label();
            txtRG = new TextBox();
            txtPessoaFisica = new TextBox();
            lblRg = new Label();
            btnPessoaFisica = new Button();
            btnPessoaJuridica = new Button();
            btnSalvar = new Button();
            painelPessoaJuridica.SuspendLayout();
            painelPessoaFisica.SuspendLayout();
            SuspendLayout();
            // 
            // painelPessoaJuridica
            // 
            painelPessoaJuridica.Controls.Add(txtEnderecoPessoaJuridica);
            painelPessoaJuridica.Controls.Add(txtNomePessoaJuridica);
            painelPessoaJuridica.Controls.Add(txtCNPJ);
            painelPessoaJuridica.Controls.Add(label1);
            painelPessoaJuridica.Controls.Add(lblEnderecoPessoaJuridica);
            painelPessoaJuridica.Controls.Add(lblNomePessoaJuridica);
            painelPessoaJuridica.Controls.Add(txtPessoaJuridica);
            painelPessoaJuridica.Controls.Add(lbl_IE);
            painelPessoaJuridica.Controls.Add(txt_IE);
            painelPessoaJuridica.Location = new Point(12, 97);
            painelPessoaJuridica.Name = "painelPessoaJuridica";
            painelPessoaJuridica.Size = new Size(722, 545);
            painelPessoaJuridica.TabIndex = 0;
            painelPessoaJuridica.Visible = false;
            // 
            // txtEnderecoPessoaJuridica
            // 
            txtEnderecoPessoaJuridica.Location = new Point(114, 56);
            txtEnderecoPessoaJuridica.Name = "txtEnderecoPessoaJuridica";
            txtEnderecoPessoaJuridica.Size = new Size(591, 27);
            txtEnderecoPessoaJuridica.TabIndex = 4;
            // 
            // txtNomePessoaJuridica
            // 
            txtNomePessoaJuridica.Location = new Point(114, 12);
            txtNomePessoaJuridica.Name = "txtNomePessoaJuridica";
            txtNomePessoaJuridica.Size = new Size(591, 27);
            txtNomePessoaJuridica.TabIndex = 1;
            // 
            // txtCNPJ
            // 
            txtCNPJ.Location = new Point(114, 98);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(265, 27);
            txtCNPJ.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 102);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 0;
            label1.Text = "CNPJ:";
            // 
            // lblEnderecoPessoaJuridica
            // 
            lblEnderecoPessoaJuridica.AutoSize = true;
            lblEnderecoPessoaJuridica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnderecoPessoaJuridica.Location = new Point(8, 60);
            lblEnderecoPessoaJuridica.Name = "lblEnderecoPessoaJuridica";
            lblEnderecoPessoaJuridica.Size = new Size(100, 23);
            lblEnderecoPessoaJuridica.TabIndex = 0;
            lblEnderecoPessoaJuridica.Text = "Endereço:";
            // 
            // lblNomePessoaJuridica
            // 
            lblNomePessoaJuridica.AutoSize = true;
            lblNomePessoaJuridica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomePessoaJuridica.Location = new Point(41, 16);
            lblNomePessoaJuridica.Name = "lblNomePessoaJuridica";
            lblNomePessoaJuridica.Size = new Size(67, 23);
            lblNomePessoaJuridica.TabIndex = 0;
            lblNomePessoaJuridica.Text = "Nome:";
            // 
            // txtPessoaJuridica
            // 
            txtPessoaJuridica.Location = new Point(16, 139);
            txtPessoaJuridica.Multiline = true;
            txtPessoaJuridica.Name = "txtPessoaJuridica";
            txtPessoaJuridica.Size = new Size(689, 403);
            txtPessoaJuridica.TabIndex = 1;
            // 
            // lbl_IE
            // 
            lbl_IE.AutoSize = true;
            lbl_IE.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IE.Location = new Point(385, 102);
            lbl_IE.Name = "lbl_IE";
            lbl_IE.Size = new Size(35, 23);
            lbl_IE.TabIndex = 0;
            lbl_IE.Text = "IE:";
            // 
            // txt_IE
            // 
            txt_IE.Location = new Point(420, 98);
            txt_IE.Name = "txt_IE";
            txt_IE.Size = new Size(285, 27);
            txt_IE.TabIndex = 3;
            // 
            // painelPessoaFisica
            // 
            painelPessoaFisica.Controls.Add(txtEnderecoPessoaFisica);
            painelPessoaFisica.Controls.Add(txtNomePessoaFisica);
            painelPessoaFisica.Controls.Add(txtCPF);
            painelPessoaFisica.Controls.Add(lblCpf);
            painelPessoaFisica.Controls.Add(lblEnderecoPessoaFisica);
            painelPessoaFisica.Controls.Add(lblNomePessoaFisica);
            painelPessoaFisica.Controls.Add(txtRG);
            painelPessoaFisica.Controls.Add(txtPessoaFisica);
            painelPessoaFisica.Controls.Add(lblRg);
            painelPessoaFisica.Location = new Point(12, 97);
            painelPessoaFisica.Name = "painelPessoaFisica";
            painelPessoaFisica.Size = new Size(731, 555);
            painelPessoaFisica.TabIndex = 2;
            // 
            // txtEnderecoPessoaFisica
            // 
            txtEnderecoPessoaFisica.Location = new Point(114, 56);
            txtEnderecoPessoaFisica.Name = "txtEnderecoPessoaFisica";
            txtEnderecoPessoaFisica.Size = new Size(591, 27);
            txtEnderecoPessoaFisica.TabIndex = 2;
            // 
            // txtNomePessoaFisica
            // 
            txtNomePessoaFisica.Location = new Point(114, 12);
            txtNomePessoaFisica.Name = "txtNomePessoaFisica";
            txtNomePessoaFisica.Size = new Size(591, 27);
            txtNomePessoaFisica.TabIndex = 1;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(114, 98);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(257, 27);
            txtCPF.TabIndex = 1;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(53, 102);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(55, 23);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "CPF:";
            // 
            // lblEnderecoPessoaFisica
            // 
            lblEnderecoPessoaFisica.AutoSize = true;
            lblEnderecoPessoaFisica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnderecoPessoaFisica.Location = new Point(8, 60);
            lblEnderecoPessoaFisica.Name = "lblEnderecoPessoaFisica";
            lblEnderecoPessoaFisica.Size = new Size(100, 23);
            lblEnderecoPessoaFisica.TabIndex = 0;
            lblEnderecoPessoaFisica.Text = "Endereço:";
            // 
            // lblNomePessoaFisica
            // 
            lblNomePessoaFisica.AutoSize = true;
            lblNomePessoaFisica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomePessoaFisica.Location = new Point(41, 16);
            lblNomePessoaFisica.Name = "lblNomePessoaFisica";
            lblNomePessoaFisica.Size = new Size(67, 23);
            lblNomePessoaFisica.TabIndex = 0;
            lblNomePessoaFisica.Text = "Nome:";
            // 
            // txtRG
            // 
            txtRG.Location = new Point(420, 98);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(285, 27);
            txtRG.TabIndex = 1;
            // 
            // txtPessoaFisica
            // 
            txtPessoaFisica.Location = new Point(16, 139);
            txtPessoaFisica.Multiline = true;
            txtPessoaFisica.Name = "txtPessoaFisica";
            txtPessoaFisica.Size = new Size(689, 403);
            txtPessoaFisica.TabIndex = 1;
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRg.Location = new Point(377, 102);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(46, 23);
            lblRg.TabIndex = 0;
            lblRg.Text = "RG:";
            // 
            // btnPessoaFisica
            // 
            btnPessoaFisica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPessoaFisica.ForeColor = Color.Black;
            btnPessoaFisica.Image = (Image)resources.GetObject("btnPessoaFisica.Image");
            btnPessoaFisica.ImageAlign = ContentAlignment.MiddleLeft;
            btnPessoaFisica.Location = new Point(63, 22);
            btnPessoaFisica.Name = "btnPessoaFisica";
            btnPessoaFisica.Size = new Size(176, 59);
            btnPessoaFisica.TabIndex = 1;
            btnPessoaFisica.Text = "Pessoa Física";
            btnPessoaFisica.TextAlign = ContentAlignment.MiddleRight;
            btnPessoaFisica.UseVisualStyleBackColor = true;
            btnPessoaFisica.Click += btnPessoaFisica_Click;
            // 
            // btnPessoaJuridica
            // 
            btnPessoaJuridica.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPessoaJuridica.ForeColor = Color.Black;
            btnPessoaJuridica.Image = (Image)resources.GetObject("btnPessoaJuridica.Image");
            btnPessoaJuridica.ImageAlign = ContentAlignment.MiddleLeft;
            btnPessoaJuridica.Location = new Point(282, 22);
            btnPessoaJuridica.Name = "btnPessoaJuridica";
            btnPessoaJuridica.Size = new Size(191, 59);
            btnPessoaJuridica.TabIndex = 1;
            btnPessoaJuridica.Text = "Pessoa Jurídica";
            btnPessoaJuridica.TextAlign = ContentAlignment.MiddleRight;
            btnPessoaJuridica.UseVisualStyleBackColor = true;
            btnPessoaJuridica.Click += btnPessoaJuridica_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(523, 22);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(111, 59);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 654);
            Controls.Add(painelPessoaFisica);
            Controls.Add(btnSalvar);
            Controls.Add(btnPessoaJuridica);
            Controls.Add(btnPessoaFisica);
            Controls.Add(painelPessoaJuridica);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            painelPessoaJuridica.ResumeLayout(false);
            painelPessoaJuridica.PerformLayout();
            painelPessoaFisica.ResumeLayout(false);
            painelPessoaFisica.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelPessoaJuridica;
        private Button btnPessoaFisica;
        private Button btnPessoaJuridica;
        private Button btnSalvar;
        private Label lblNomePessoaJuridica;
        private Label lblEnderecoPessoaJuridica;
        private Label lbl_IE;
        private TextBox txtNomePessoaJuridica;
        private TextBox txtCNPJ;
        private TextBox txtPessoaJuridica;
        private TextBox txt_IE;
        private TextBox txtEnderecoPessoaJuridica;
        private Panel painelPessoaFisica;
        private TextBox txtEnderecoPessoaFisica;
        private TextBox txtNomePessoaFisica;
        private TextBox txtCPF;
        private Label lblCpf;
        private Label lblEnderecoPessoaFisica;
        private Label lblNomePessoaFisica;
        private TextBox txtRG;
        private TextBox txtPessoaFisica;
        private Label lblRg;
        private Label label1;
    }
}
