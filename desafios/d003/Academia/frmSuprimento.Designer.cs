namespace Academia
{
    partial class frmSuprimento
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
            tcCaixa = new TabControl();
            tabPageDadosCaixa = new TabPage();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            btnAbrirCaixa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tcCaixa.SuspendLayout();
            tabPageDadosCaixa.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 109);
            panel1.TabIndex = 1;
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
            label1.Location = new Point(102, 42);
            label1.Name = "label1";
            label1.Size = new Size(243, 27);
            label1.TabIndex = 1;
            label1.Text = "Suprimento do Caixa";
            // 
            // tcCaixa
            // 
            tcCaixa.Controls.Add(tabPageDadosCaixa);
            tcCaixa.Location = new Point(12, 127);
            tcCaixa.Name = "tcCaixa";
            tcCaixa.SelectedIndex = 0;
            tcCaixa.Size = new Size(400, 86);
            tcCaixa.TabIndex = 2;
            // 
            // tabPageDadosCaixa
            // 
            tabPageDadosCaixa.Controls.Add(comboBox1);
            tabPageDadosCaixa.Controls.Add(label2);
            tabPageDadosCaixa.Controls.Add(textBox1);
            tabPageDadosCaixa.Controls.Add(label3);
            tabPageDadosCaixa.Location = new Point(4, 29);
            tabPageDadosCaixa.Name = "tabPageDadosCaixa";
            tabPageDadosCaixa.Padding = new Padding(3);
            tabPageDadosCaixa.Size = new Size(392, 53);
            tabPageDadosCaixa.TabIndex = 0;
            tabPageDadosCaixa.Text = "Dados do caixa";
            tabPageDadosCaixa.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(63, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 25);
            textBox1.TabIndex = 2;
            textBox1.Text = "0,00";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 17);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 11;
            label3.Text = "Valor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(164, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 12;
            label2.Text = "Forma:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(230, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(326, 219);
            button1.Name = "button1";
            button1.Size = new Size(82, 51);
            button1.TabIndex = 19;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirCaixa.Image = Properties.Resources.confirmar;
            btnAbrirCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCaixa.Location = new Point(188, 219);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Padding = new Padding(3, 0, 3, 0);
            btnAbrirCaixa.Size = new Size(132, 50);
            btnAbrirCaixa.TabIndex = 20;
            btnAbrirCaixa.Text = "Confirmar";
            btnAbrirCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // frmSuprimento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 281);
            Controls.Add(btnAbrirCaixa);
            Controls.Add(button1);
            Controls.Add(tcCaixa);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmSuprimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimento do Caixa";
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
        private Label label1;
        private TabControl tcCaixa;
        private TabPage tabPageDadosCaixa;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
        private Button btnAbrirCaixa;
    }
}