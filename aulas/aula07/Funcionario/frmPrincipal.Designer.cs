namespace SistemaFuncionario
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
            label1 = new Label();
            txtFuncionario = new TextBox();
            btnSalvar = new Button();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalario = new TextBox();
            cboCargo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtFuncionario
            // 
            txtFuncionario.Location = new Point(22, 163);
            txtFuncionario.Multiline = true;
            txtFuncionario.Name = "txtFuncionario";
            txtFuncionario.ReadOnly = true;
            txtFuncionario.Size = new Size(640, 275);
            txtFuncionario.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Image = Properties.Resources.save;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(505, 27);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(157, 80);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 0;
            label2.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold);
            label3.Location = new Point(22, 114);
            label3.Name = "label3";
            label3.Size = new Size(110, 32);
            label3.TabIndex = 0;
            label3.Text = "Salário:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(136, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(363, 27);
            txtNome.TabIndex = 1;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(136, 119);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(139, 27);
            txtSalario.TabIndex = 1;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Assistente Administrativo", "Assistente de Designer" });
            cboCargo.Location = new Point(136, 75);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(363, 28);
            cboCargo.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 450);
            Controls.Add(cboCargo);
            Controls.Add(btnSalvar);
            Controls.Add(txtNome);
            Controls.Add(txtSalario);
            Controls.Add(txtFuncionario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de funcionários";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFuncionario;
        private Button btnSalvar;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalario;
        private ComboBox cboCargo;
    }
}
