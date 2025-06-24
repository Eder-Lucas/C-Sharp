namespace MediaAluno
{
    partial class frmCalculoMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoMedia));
            pictureBox1 = new PictureBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtTrabalho = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboPesoNota1 = new ComboBox();
            cboPesoNota2 = new ComboBox();
            cboPesoTrabalho = new ComboBox();
            txtQdeAulas = new TextBox();
            txtQdeFaltas = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMediaFinal = new TextBox();
            label7 = new Label();
            txtAproveitamento = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            label8 = new Label();
            numNotaCorte = new NumericUpDown();
            groupBox1 = new GroupBox();
            lblSituacao = new Label();
            groupBox2 = new GroupBox();
            txtRecuperacao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNotaCorte).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.painelMediaAluno;
            pictureBox1.Location = new Point(229, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtNota1
            // 
            txtNota1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota1.Location = new Point(75, 250);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(125, 32);
            txtNota1.TabIndex = 0;
            txtNota1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNota2
            // 
            txtNota2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota2.Location = new Point(222, 250);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(125, 32);
            txtNota2.TabIndex = 2;
            txtNota2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTrabalho
            // 
            txtTrabalho.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTrabalho.Location = new Point(369, 250);
            txtTrabalho.Name = "txtTrabalho";
            txtTrabalho.Size = new Size(125, 32);
            txtTrabalho.TabIndex = 4;
            txtTrabalho.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 221);
            label1.Name = "label1";
            label1.Size = new Size(79, 26);
            label1.TabIndex = 2;
            label1.Text = "Nota 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 221);
            label2.Name = "label2";
            label2.Size = new Size(79, 26);
            label2.TabIndex = 2;
            label2.Text = "Nota 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(381, 221);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 2;
            label3.Text = "Trabalho";
            // 
            // cboPesoNota1
            // 
            cboPesoNota1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesoNota1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPesoNota1.FormattingEnabled = true;
            cboPesoNota1.Items.AddRange(new object[] { "0,2", "0,3", "0,5" });
            cboPesoNota1.Location = new Point(75, 288);
            cboPesoNota1.Name = "cboPesoNota1";
            cboPesoNota1.Size = new Size(125, 34);
            cboPesoNota1.TabIndex = 1;
            // 
            // cboPesoNota2
            // 
            cboPesoNota2.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesoNota2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPesoNota2.FormattingEnabled = true;
            cboPesoNota2.Items.AddRange(new object[] { "0,2", "0,3", "0,5" });
            cboPesoNota2.Location = new Point(222, 288);
            cboPesoNota2.Name = "cboPesoNota2";
            cboPesoNota2.Size = new Size(125, 34);
            cboPesoNota2.TabIndex = 3;
            // 
            // cboPesoTrabalho
            // 
            cboPesoTrabalho.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPesoTrabalho.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPesoTrabalho.FormattingEnabled = true;
            cboPesoTrabalho.Items.AddRange(new object[] { "0,2", "0,3", "0,5" });
            cboPesoTrabalho.Location = new Point(369, 288);
            cboPesoTrabalho.Name = "cboPesoTrabalho";
            cboPesoTrabalho.Size = new Size(125, 34);
            cboPesoTrabalho.TabIndex = 5;
            // 
            // txtQdeAulas
            // 
            txtQdeAulas.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQdeAulas.Location = new Point(236, 351);
            txtQdeAulas.Name = "txtQdeAulas";
            txtQdeAulas.Size = new Size(111, 32);
            txtQdeAulas.TabIndex = 6;
            txtQdeAulas.TextAlign = HorizontalAlignment.Center;
            // 
            // txtQdeFaltas
            // 
            txtQdeFaltas.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQdeFaltas.Location = new Point(236, 401);
            txtQdeFaltas.Name = "txtQdeFaltas";
            txtQdeFaltas.Size = new Size(111, 32);
            txtQdeFaltas.TabIndex = 7;
            txtQdeFaltas.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 354);
            label4.Name = "label4";
            label4.Size = new Size(155, 26);
            label4.TabIndex = 2;
            label4.Text = "Qtd. de aulas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(75, 404);
            label5.Name = "label5";
            label5.Size = new Size(157, 26);
            label5.TabIndex = 2;
            label5.Text = "Qtd. de faltas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(75, 461);
            label6.Name = "label6";
            label6.Size = new Size(122, 26);
            label6.TabIndex = 2;
            label6.Text = "Média final";
            // 
            // txtMediaFinal
            // 
            txtMediaFinal.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMediaFinal.Location = new Point(74, 490);
            txtMediaFinal.Name = "txtMediaFinal";
            txtMediaFinal.Size = new Size(125, 32);
            txtMediaFinal.TabIndex = 16;
            txtMediaFinal.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(254, 461);
            label7.Name = "label7";
            label7.Size = new Size(173, 26);
            label7.TabIndex = 2;
            label7.Text = "Aproveitamento";
            // 
            // txtAproveitamento
            // 
            txtAproveitamento.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAproveitamento.Location = new Point(254, 490);
            txtAproveitamento.Name = "txtAproveitamento";
            txtAproveitamento.Size = new Size(173, 32);
            txtAproveitamento.TabIndex = 17;
            txtAproveitamento.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Image = Properties.Resources.calculadora;
            btnCalcular.ImageAlign = ContentAlignment.TopCenter;
            btnCalcular.Location = new Point(74, 559);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(179, 106);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.BottomCenter;
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Image = Properties.Resources.vassoura;
            btnLimpar.ImageAlign = ContentAlignment.TopCenter;
            btnLimpar.Location = new Point(275, 559);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(161, 106);
            btnLimpar.TabIndex = 18;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(381, 357);
            label8.Name = "label8";
            label8.Size = new Size(148, 26);
            label8.TabIndex = 2;
            label8.Text = "Nota de corte";
            // 
            // numNotaCorte
            // 
            numNotaCorte.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numNotaCorte.Location = new Point(381, 386);
            numNotaCorte.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numNotaCorte.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numNotaCorte.Name = "numNotaCorte";
            numNotaCorte.Size = new Size(148, 32);
            numNotaCorte.TabIndex = 8;
            numNotaCorte.TextAlign = HorizontalAlignment.Center;
            numNotaCorte.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSituacao);
            groupBox1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(573, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 125);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Situação";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(59, 62);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(0, 26);
            lblSituacao.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRecuperacao);
            groupBox2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Firebrick;
            groupBox2.Location = new Point(573, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(251, 125);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recuperação";
            // 
            // txtRecuperacao
            // 
            txtRecuperacao.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecuperacao.Location = new Point(42, 48);
            txtRecuperacao.Name = "txtRecuperacao";
            txtRecuperacao.Size = new Size(125, 32);
            txtRecuperacao.TabIndex = 0;
            txtRecuperacao.TextAlign = HorizontalAlignment.Center;
            // 
            // frmCalculoMedia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 703);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(numNotaCorte);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(cboPesoTrabalho);
            Controls.Add(cboPesoNota2);
            Controls.Add(cboPesoNota1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtTrabalho);
            Controls.Add(txtNota2);
            Controls.Add(txtAproveitamento);
            Controls.Add(txtMediaFinal);
            Controls.Add(txtQdeFaltas);
            Controls.Add(txtQdeAulas);
            Controls.Add(txtNota1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmCalculoMedia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo Média";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNotaCorte).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtTrabalho;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboPesoNota1;
        private ComboBox cboPesoNota2;
        private ComboBox cboPesoTrabalho;
        private TextBox txtQdeAulas;
        private TextBox txtQdeFaltas;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMediaFinal;
        private Label label7;
        private TextBox txtAproveitamento;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label label8;
        private NumericUpDown numNotaCorte;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtRecuperacao;
        private Label lblSituacao;
    }
}
