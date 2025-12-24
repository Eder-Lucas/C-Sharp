namespace Calculadora
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            txtHistorico = new TextBox();
            txtVisor = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnLimpar = new Button();
            btnBackSpace = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnRaiz = new Button();
            btnIgual = new Button();
            btnVirgula = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtHistorico
            // 
            txtHistorico.BackColor = SystemColors.ControlLightLight;
            txtHistorico.Location = new Point(12, 21);
            txtHistorico.Name = "txtHistorico";
            txtHistorico.ReadOnly = true;
            txtHistorico.Size = new Size(407, 27);
            txtHistorico.TabIndex = 0;
            txtHistorico.TextAlign = HorizontalAlignment.Right;
            // 
            // txtVisor
            // 
            txtVisor.BackColor = SystemColors.ControlLightLight;
            txtVisor.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVisor.Location = new Point(12, 77);
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.Size = new Size(407, 51);
            txtVisor.TabIndex = 0;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Image = Properties.Resources._7;
            btn7.Location = new Point(23, 168);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 63);
            btn7.TabIndex = 1;
            btn7.Tag = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += ClicouBotao_Click;
            // 
            // btn8
            // 
            btn8.Image = Properties.Resources._8;
            btn8.Location = new Point(94, 168);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 63);
            btn8.TabIndex = 1;
            btn8.Tag = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += ClicouBotao_Click;
            // 
            // btn9
            // 
            btn9.Image = Properties.Resources._9;
            btn9.Location = new Point(165, 168);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 63);
            btn9.TabIndex = 1;
            btn9.Tag = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += ClicouBotao_Click;
            // 
            // btn4
            // 
            btn4.Image = Properties.Resources._4;
            btn4.Location = new Point(23, 237);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 63);
            btn4.TabIndex = 1;
            btn4.Tag = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += ClicouBotao_Click;
            // 
            // btn5
            // 
            btn5.Image = Properties.Resources._5;
            btn5.Location = new Point(94, 237);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 63);
            btn5.TabIndex = 1;
            btn5.Tag = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += ClicouBotao_Click;
            // 
            // btn6
            // 
            btn6.Image = Properties.Resources._6;
            btn6.Location = new Point(165, 237);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 63);
            btn6.TabIndex = 1;
            btn6.Tag = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += ClicouBotao_Click;
            // 
            // btn1
            // 
            btn1.Image = Properties.Resources._1;
            btn1.Location = new Point(23, 306);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 63);
            btn1.TabIndex = 1;
            btn1.Tag = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += ClicouBotao_Click;
            // 
            // btn2
            // 
            btn2.Image = Properties.Resources._2;
            btn2.Location = new Point(94, 306);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 63);
            btn2.TabIndex = 1;
            btn2.Tag = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += ClicouBotao_Click;
            // 
            // btn3
            // 
            btn3.Image = Properties.Resources._3;
            btn3.Location = new Point(165, 306);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 63);
            btn3.TabIndex = 1;
            btn3.Tag = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += ClicouBotao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = Properties.Resources.limpar_tudo;
            btnLimpar.Location = new Point(270, 168);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(65, 63);
            btnLimpar.TabIndex = 1;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Image = Properties.Resources.apagar;
            btnBackSpace.Location = new Point(341, 168);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(65, 63);
            btnBackSpace.TabIndex = 1;
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Image = Properties.Resources.adicao;
            btnAdicao.Location = new Point(270, 237);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(65, 63);
            btnAdicao.TabIndex = 1;
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Image = Properties.Resources.subtracao;
            btnSubtracao.Location = new Point(341, 237);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(65, 63);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Image = Properties.Resources.multiplicacao;
            btnMultiplicacao.Location = new Point(270, 306);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(65, 63);
            btnMultiplicacao.TabIndex = 1;
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Image = Properties.Resources.divisao;
            btnDivisao.Location = new Point(341, 306);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(65, 63);
            btnDivisao.TabIndex = 1;
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Image = Properties.Resources.raiz_quadrada;
            btnRaiz.Location = new Point(270, 375);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(65, 63);
            btnRaiz.TabIndex = 1;
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnIgual
            // 
            btnIgual.Image = Properties.Resources.igual;
            btnIgual.Location = new Point(341, 375);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(65, 63);
            btnIgual.TabIndex = 1;
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Image = Properties.Resources.virgula;
            btnVirgula.Location = new Point(165, 375);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(65, 63);
            btnVirgula.TabIndex = 1;
            btnVirgula.Tag = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += ClicouBotao_Click;
            // 
            // btn0
            // 
            btn0.Image = Properties.Resources._0;
            btn0.Location = new Point(23, 375);
            btn0.Name = "btn0";
            btn0.Size = new Size(136, 63);
            btn0.TabIndex = 1;
            btn0.Tag = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += ClicouBotao_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 457);
            Controls.Add(btnIgual);
            Controls.Add(btnDivisao);
            Controls.Add(btnSubtracao);
            Controls.Add(btn0);
            Controls.Add(btnVirgula);
            Controls.Add(btnRaiz);
            Controls.Add(btnBackSpace);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btn3);
            Controls.Add(btnAdicao);
            Controls.Add(btn6);
            Controls.Add(btnLimpar);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtVisor);
            Controls.Add(txtHistorico);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHistorico;
        private TextBox txtVisor;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnLimpar;
        private Button btnBackSpace;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnRaiz;
        private Button btnIgual;
        private Button btnVirgula;
        private Button btn0;
    }
}
