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
            comboBox1 = new ComboBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            tcCaixa = new TabControl();
            tabPageDadosCaixa = new TabPage();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 109);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 25);
            comboBox1.TabIndex = 1;
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
            tcCaixa.Size = new Size(389, 148);
            tcCaixa.TabIndex = 1;
            // 
            // tabPageDadosCaixa
            // 
            tabPageDadosCaixa.Controls.Add(label5);
            tabPageDadosCaixa.Controls.Add(label6);
            tabPageDadosCaixa.Controls.Add(label4);
            tabPageDadosCaixa.Controls.Add(textBox3);
            tabPageDadosCaixa.Controls.Add(textBox2);
            tabPageDadosCaixa.Controls.Add(textBox1);
            tabPageDadosCaixa.Controls.Add(label3);
            tabPageDadosCaixa.Location = new Point(4, 29);
            tabPageDadosCaixa.Name = "tabPageDadosCaixa";
            tabPageDadosCaixa.Padding = new Padding(3);
            tabPageDadosCaixa.Size = new Size(381, 115);
            tabPageDadosCaixa.TabIndex = 0;
            tabPageDadosCaixa.Text = "Dados do caixa";
            tabPageDadosCaixa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 82);
            label5.Name = "label5";
            label5.Size = new Size(180, 19);
            label5.TabIndex = 13;
            label5.Text = "Valor inicial em CAIXA:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 48);
            label6.Name = "label6";
            label6.Size = new Size(187, 19);
            label6.TabIndex = 12;
            label6.Text = "Valor inicial em Cheque:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 48);
            label4.Name = "label4";
            label4.Size = new Size(192, 19);
            label4.TabIndex = 12;
            label4.Text = "Valor inicial em Dinheiro:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(201, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 25);
            textBox3.TabIndex = 2;
            textBox3.Text = "0,00";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(201, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 25);
            textBox2.TabIndex = 2;
            textBox2.Text = "0,00";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(201, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 25);
            textBox1.TabIndex = 2;
            textBox1.Text = "0,00";
            textBox1.TextAlign = HorizontalAlignment.Right;
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
            btnAbrirCaixa.Location = new Point(177, 281);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Size = new Size(132, 40);
            btnAbrirCaixa.TabIndex = 17;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(315, 280);
            button1.Name = "button1";
            button1.Size = new Size(82, 40);
            button1.TabIndex = 18;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAberturaCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 332);
            Controls.Add(button1);
            Controls.Add(btnAbrirCaixa);
            Controls.Add(tcCaixa);
            Controls.Add(panel1);
            Name = "frmAberturaCaixa";
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
        private ComboBox comboBox1;
        private TabControl tcCaixa;
        private TabPage tabPageDadosCaixa;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnAbrirCaixa;
        private Button button1;
    }
}