namespace Academia
{
    partial class frmAberturaCaixa
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
            panel1 = new Panel();
            cboValorInicial = new ComboBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tcCaixa = new TabControl();
            tabPageDadosCaixa = new TabPage();
            label5 = new Label();
            txtCaixa = new TextBox();
            txtDinheiro = new TextBox();
            label3 = new Label();
            btnAbrirCaixa = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tcCaixa.SuspendLayout();
            tabPageDadosCaixa.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(cboValorInicial);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 109);
            panel1.TabIndex = 0;
            // 
            // cboValorInicial
            // 
            cboValorInicial.DropDownStyle = ComboBoxStyle.DropDownList;
            cboValorInicial.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboValorInicial.FormattingEnabled = true;
            cboValorInicial.Items.AddRange(new object[] { "Zerado", "Com os valores que eu digitar", "Com o saldo do caixa anterior" });
            cboValorInicial.Location = new Point(79, 74);
            cboValorInicial.Name = "cboValorInicial";
            cboValorInicial.Size = new Size(299, 25);
            cboValorInicial.TabIndex = 1;
            cboValorInicial.SelectedIndexChanged += cboValorInicial_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 54);
            label2.Name = "label2";
            label2.Size = new Size(231, 17);
            label2.TabIndex = 2;
            label2.Text = "Abrir o caixa com o seguinte valor:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.caixa_maior;
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 13);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 1;
            label1.Text = "Abertura do Caixa";
            // 
            // tcCaixa
            // 
            tcCaixa.Controls.Add(tabPageDadosCaixa);
            tcCaixa.Location = new Point(12, 127);
            tcCaixa.Name = "tcCaixa";
            tcCaixa.SelectedIndex = 0;
            tcCaixa.Size = new Size(389, 114);
            tcCaixa.TabIndex = 1;
            // 
            // tabPageDadosCaixa
            // 
            tabPageDadosCaixa.Controls.Add(label5);
            tabPageDadosCaixa.Controls.Add(txtCaixa);
            tabPageDadosCaixa.Controls.Add(txtDinheiro);
            tabPageDadosCaixa.Controls.Add(label3);
            tabPageDadosCaixa.Location = new Point(4, 29);
            tabPageDadosCaixa.Name = "tabPageDadosCaixa";
            tabPageDadosCaixa.Padding = new Padding(3);
            tabPageDadosCaixa.Size = new Size(381, 81);
            tabPageDadosCaixa.TabIndex = 0;
            tabPageDadosCaixa.Text = "Dados do caixa";
            tabPageDadosCaixa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 48);
            label5.Name = "label5";
            label5.Size = new Size(180, 19);
            label5.TabIndex = 13;
            label5.Text = "Valor inicial em CAIXA:";
            // 
            // txtCaixa
            // 
            txtCaixa.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaixa.Location = new Point(201, 45);
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(164, 25);
            txtCaixa.TabIndex = 2;
            txtCaixa.Text = "0,00";
            txtCaixa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDinheiro
            // 
            txtDinheiro.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDinheiro.Location = new Point(201, 11);
            txtDinheiro.Name = "txtDinheiro";
            txtDinheiro.Size = new Size(164, 25);
            txtDinheiro.TabIndex = 2;
            txtDinheiro.Text = "0,00";
            txtDinheiro.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 14);
            label3.Name = "label3";
            label3.Size = new Size(192, 19);
            label3.TabIndex = 11;
            label3.Text = "Valor inicial em Dinheiro:";
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirCaixa.Image = Properties.Resources.cadeado_aberto;
            btnAbrirCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCaixa.Location = new Point(178, 248);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Size = new Size(132, 50);
            btnAbrirCaixa.TabIndex = 17;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(316, 247);
            button1.Name = "button1";
            button1.Size = new Size(82, 51);
            button1.TabIndex = 18;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAberturaCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 311);
            Controls.Add(button1);
            Controls.Add(btnAbrirCaixa);
            Controls.Add(tcCaixa);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAberturaCaixa";
            Load += frmAberturaCaixa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tcCaixa.ResumeLayout(false);
            tabPageDadosCaixa.ResumeLayout(false);
            tabPageDadosCaixa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
        private ComboBox cboValorInicial;
        private TabControl tcCaixa;
        private TabPage tabPageDadosCaixa;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtCaixa;
        private TextBox txtDinheiro;
        private Button btnAbrirCaixa;
        private Button button1;
    }
}