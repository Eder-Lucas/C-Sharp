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
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtCaixa = new TextBox();
            txtDinheiro = new TextBox();
            label3 = new Label();
            btnAbrirCaixa = new Button();
            button1 = new Button();
            switchZerado = new ToggleSwitch();
            label4 = new Label();
            switchSaldoAnterior = new ToggleSwitch();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 102);
            panel1.TabIndex = 0;
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
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 35);
            label1.Name = "label1";
            label1.Size = new Size(257, 33);
            label1.TabIndex = 1;
            label1.Text = "Abertura do Caixa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(170, 27);
            label2.TabIndex = 2;
            label2.Text = "Modo de abertura";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(202, 21);
            label5.TabIndex = 13;
            label5.Text = "Saldo do Caixa anterior:";
            // 
            // txtCaixa
            // 
            txtCaixa.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaixa.Location = new Point(211, 11);
            txtCaixa.Name = "txtCaixa";
            txtCaixa.Size = new Size(167, 25);
            txtCaixa.TabIndex = 2;
            txtCaixa.Text = "0,00";
            txtCaixa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDinheiro
            // 
            txtDinheiro.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDinheiro.Location = new Point(211, 45);
            txtDinheiro.Name = "txtDinheiro";
            txtDinheiro.Size = new Size(167, 25);
            txtDinheiro.TabIndex = 2;
            txtDinheiro.Text = "0,00";
            txtDinheiro.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 47);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 11;
            label3.Text = "Valor da abertura:";
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.BackColor = Color.Green;
            btnAbrirCaixa.FlatAppearance.BorderSize = 0;
            btnAbrirCaixa.FlatStyle = FlatStyle.Flat;
            btnAbrirCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirCaixa.ForeColor = Color.White;
            btnAbrirCaixa.Image = Properties.Resources.confirmBranco;
            btnAbrirCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCaixa.Location = new Point(217, 401);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Padding = new Padding(28, 0, 28, 0);
            btnAbrirCaixa.Size = new Size(173, 31);
            btnAbrirCaixa.TabIndex = 17;
            btnAbrirCaixa.Text = "Confirmar";
            btnAbrirCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirCaixa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(196, 196, 196);
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.fecharPreto;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 401);
            button1.Name = "button1";
            button1.Padding = new Padding(32, 0, 28, 0);
            button1.Size = new Size(173, 31);
            button1.TabIndex = 18;
            button1.Text = "Cancelar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // switchZerado
            // 
            switchZerado.AnimationSpeed = 1;
            switchZerado.Location = new Point(6, 45);
            switchZerado.Name = "switchZerado";
            switchZerado.Size = new Size(47, 25);
            switchZerado.TabIndex = 19;
            switchZerado.MouseDown += switchZerado_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(59, 51);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 2;
            label4.Text = "Zerado";
            // 
            // switchSaldoAnterior
            // 
            switchSaldoAnterior.AnimationSpeed = 10;
            switchSaldoAnterior.Location = new Point(6, 79);
            switchSaldoAnterior.Name = "switchSaldoAnterior";
            switchSaldoAnterior.Size = new Size(47, 25);
            switchSaldoAnterior.TabIndex = 19;
            switchSaldoAnterior.MouseDown += switchSaldoAnterior_MouseDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(59, 85);
            label6.Name = "label6";
            label6.Size = new Size(213, 19);
            label6.TabIndex = 2;
            label6.Text = "Usar saldo do caixa anterior";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(49, 81);
            label7.Name = "label7";
            label7.Size = new Size(156, 21);
            label7.TabIndex = 11;
            label7.Text = " Total da abertura:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(211, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 25);
            textBox1.TabIndex = 2;
            textBox1.Text = "0,00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(switchZerado);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(switchSaldoAnterior);
            panel2.Location = new Point(12, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 125);
            panel2.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtDinheiro);
            panel3.Controls.Add(txtCaixa);
            panel3.Location = new Point(12, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 125);
            panel3.TabIndex = 21;
            // 
            // frmAberturaCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(btnAbrirCaixa);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAberturaCaixa";
            Load += frmAberturaCaixa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label1;
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
        private ToggleSwitch toggleSwitch1;
        private ToggleSwitch switchSaldoAnterior;
        private ToggleSwitch switchZerado;
        private Label label7;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel3;
        private ModernButton modernButton1;
    }
}