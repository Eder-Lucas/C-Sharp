namespace Academia
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            pictureBox3 = new PictureBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            cboTipoPagamento = new ComboBox();
            cboMovimento = new ComboBox();
            btnFiltrar = new Button();
            groupBox2 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblInicial = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnSuprimento = new Button();
            btnRetirada = new Button();
            btnAbrirCaixa = new Button();
            btnFecharCaixa = new Button();
            btnSair = new Button();
            dtgCaixa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCaixa).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.caixa_maior;
            pictureBox3.Location = new Point(8, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(cboTipoPagamento);
            groupBox1.Controls.Add(cboMovimento);
            groupBox1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(79, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 90);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(452, 30);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 12;
            label3.Text = "Data do pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 30);
            label2.Name = "label2";
            label2.Size = new Size(180, 21);
            label2.TabIndex = 12;
            label2.Text = "Forma de pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 12;
            label1.Text = "Movimento";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todas", "Pagas", "Pendentes" });
            comboBox1.Location = new Point(452, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 27);
            comboBox1.TabIndex = 12;
            // 
            // cboTipoPagamento
            // 
            cboTipoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPagamento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoPagamento.FormattingEnabled = true;
            cboTipoPagamento.Items.AddRange(new object[] { "Todas", "Pagas", "Pendentes" });
            cboTipoPagamento.Location = new Point(229, 54);
            cboTipoPagamento.Name = "cboTipoPagamento";
            cboTipoPagamento.Size = new Size(205, 27);
            cboTipoPagamento.TabIndex = 12;
            // 
            // cboMovimento
            // 
            cboMovimento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMovimento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMovimento.FormattingEnabled = true;
            cboMovimento.Items.AddRange(new object[] { "Todas", "Pagas", "Pendentes" });
            cboMovimento.Location = new Point(6, 54);
            cboMovimento.Name = "cboMovimento";
            cboMovimento.Size = new Size(205, 27);
            cboMovimento.TabIndex = 12;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Image = Properties.Resources.filtro_maior;
            btnFiltrar.Location = new Point(752, 25);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(72, 53);
            btnFiltrar.TabIndex = 12;
            btnFiltrar.TextAlign = ContentAlignment.BottomCenter;
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lblInicial);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(830, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 296);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 258);
            label10.Name = "label10";
            label10.Size = new Size(152, 28);
            label10.TabIndex = 20;
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 237);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 19;
            label9.Text = "Saldo:";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 196);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 18;
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 175);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 17;
            label7.Text = "Retirada:";
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 134);
            label6.Name = "label6";
            label6.Size = new Size(152, 28);
            label6.TabIndex = 16;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInicial
            // 
            lblInicial.BackColor = Color.White;
            lblInicial.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicial.Location = new Point(6, 72);
            lblInicial.Name = "lblInicial";
            lblInicial.Size = new Size(152, 28);
            lblInicial.TabIndex = 15;
            lblInicial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 13;
            label5.Text = "Entrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 51);
            label4.Name = "label4";
            label4.Size = new Size(60, 21);
            label4.TabIndex = 13;
            label4.Text = "Inicial:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Controls.Add(btnRetirada);
            groupBox3.Controls.Add(btnSuprimento);
            groupBox3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(830, 323);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 183);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lançamentos";
            // 
            // btnSuprimento
            // 
            btnSuprimento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuprimento.Image = Properties.Resources.seta_cima;
            btnSuprimento.ImageAlign = ContentAlignment.TopCenter;
            btnSuprimento.Location = new Point(21, 43);
            btnSuprimento.Name = "btnSuprimento";
            btnSuprimento.Size = new Size(137, 62);
            btnSuprimento.TabIndex = 15;
            btnSuprimento.Text = "Suprimento";
            btnSuprimento.TextAlign = ContentAlignment.BottomCenter;
            btnSuprimento.UseVisualStyleBackColor = true;
            // 
            // btnRetirada
            // 
            btnRetirada.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetirada.Image = Properties.Resources.seta_baixo;
            btnRetirada.ImageAlign = ContentAlignment.TopCenter;
            btnRetirada.Location = new Point(21, 111);
            btnRetirada.Name = "btnRetirada";
            btnRetirada.Size = new Size(137, 62);
            btnRetirada.TabIndex = 16;
            btnRetirada.Text = "Retirada";
            btnRetirada.TextAlign = ContentAlignment.BottomCenter;
            btnRetirada.UseVisualStyleBackColor = true;
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirCaixa.Image = Properties.Resources.cadeado_aberto;
            btnAbrirCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCaixa.Location = new Point(842, 528);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Padding = new Padding(0, 0, 22, 0);
            btnAbrirCaixa.Size = new Size(153, 50);
            btnAbrirCaixa.TabIndex = 16;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // btnFecharCaixa
            // 
            btnFecharCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCaixa.Image = Properties.Resources.cadeado_fechado;
            btnFecharCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnFecharCaixa.Location = new Point(842, 584);
            btnFecharCaixa.Name = "btnFecharCaixa";
            btnFecharCaixa.Padding = new Padding(0, 0, 6, 0);
            btnFecharCaixa.Size = new Size(153, 50);
            btnFecharCaixa.TabIndex = 17;
            btnFecharCaixa.Text = "Fechar Caixa";
            btnFecharCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnFecharCaixa.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Image = Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(842, 654);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(3, 0, 0, 0);
            btnSair.Size = new Size(76, 40);
            btnSair.TabIndex = 18;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = true;
            // 
            // dtgCaixa
            // 
            dtgCaixa.AllowUserToAddRows = false;
            dtgCaixa.AllowUserToDeleteRows = false;
            dtgCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCaixa.Location = new Point(8, 98);
            dtgCaixa.Name = "dtgCaixa";
            dtgCaixa.ReadOnly = true;
            dtgCaixa.RowHeadersWidth = 51;
            dtgCaixa.Size = new Size(816, 608);
            dtgCaixa.TabIndex = 19;
            // 
            // frmCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 718);
            Controls.Add(dtgCaixa);
            Controls.Add(btnSair);
            Controls.Add(btnFecharCaixa);
            Controls.Add(btnAbrirCaixa);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnFiltrar);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCaixa";
            Text = "SCA - Controle de Caixa";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCaixa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox3;
        private GroupBox groupBox1;
        private ComboBox cboMovimento;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox cboTipoPagamento;
        private Button btnFiltrar;
        private GroupBox groupBox2;
        private Label label4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblInicial;
        private Label label5;
        private GroupBox groupBox3;
        private Button btnSuprimento;
        private Button btnRetirada;
        private Button btnAbrirCaixa;
        private Button btnFecharCaixa;
        private Button btnSair;
        private DataGridView dtgCaixa;
    }
}