namespace Academia
{
    partial class ucCaixa
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnRetirada = new Button();
            lblSaldo = new Label();
            label9 = new Label();
            lblRetirada = new Label();
            label7 = new Label();
            lblEntrada = new Label();
            lblInicial = new Label();
            btnSuprimento = new Button();
            lblDataAbertura = new Label();
            dtgCaixa = new DataGridView();
            IMAGEM = new DataGridViewImageColumn();
            MOVIMENTO = new DataGridViewTextBoxColumn();
            TIPO_MOVIMENTO = new DataGridViewTextBoxColumn();
            DATA = new DataGridViewTextBoxColumn();
            PAGAMENTO = new DataGridViewTextBoxColumn();
            VALOR = new DataGridViewTextBoxColumn();
            btnSair = new Button();
            btnFecharCaixa = new Button();
            btnAbrirCaixa = new Button();
            label5 = new Label();
            label4 = new Label();
            lblCaixaId = new Label();
            groupBox2 = new GroupBox();
            btnFiltrar = new Button();
            dtpDataPagamento = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cboTipoPagamento = new ComboBox();
            cboMovimento = new ComboBox();
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgCaixa).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            btnRetirada.Click += btnRetirada_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.BackColor = Color.White;
            lblSaldo.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.ForeColor = Color.Green;
            lblSaldo.Location = new Point(6, 258);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(152, 28);
            lblSaldo.TabIndex = 20;
            lblSaldo.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblRetirada
            // 
            lblRetirada.BackColor = Color.White;
            lblRetirada.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetirada.ForeColor = Color.Red;
            lblRetirada.Location = new Point(6, 196);
            lblRetirada.Name = "lblRetirada";
            lblRetirada.Size = new Size(152, 28);
            lblRetirada.TabIndex = 18;
            lblRetirada.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblEntrada
            // 
            lblEntrada.BackColor = Color.White;
            lblEntrada.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrada.ForeColor = Color.Green;
            lblEntrada.Location = new Point(6, 134);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(152, 28);
            lblEntrada.TabIndex = 16;
            lblEntrada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInicial
            // 
            lblInicial.BackColor = Color.White;
            lblInicial.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicial.ForeColor = Color.Green;
            lblInicial.Location = new Point(6, 72);
            lblInicial.Name = "lblInicial";
            lblInicial.Size = new Size(152, 28);
            lblInicial.TabIndex = 15;
            lblInicial.TextAlign = ContentAlignment.MiddleCenter;
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
            btnSuprimento.Click += btnSuprimento_Click;
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataAbertura.ForeColor = Color.Purple;
            lblDataAbertura.Location = new Point(120, 684);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(142, 19);
            lblDataAbertura.TabIndex = 30;
            lblDataAbertura.Text = "Caixa aberto em:";
            // 
            // dtgCaixa
            // 
            dtgCaixa.AllowUserToAddRows = false;
            dtgCaixa.AllowUserToDeleteRows = false;
            dtgCaixa.AllowUserToResizeColumns = false;
            dtgCaixa.AllowUserToResizeRows = false;
            dtgCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCaixa.Columns.AddRange(new DataGridViewColumn[] { IMAGEM, MOVIMENTO, TIPO_MOVIMENTO, DATA, PAGAMENTO, VALOR });
            dtgCaixa.Location = new Point(10, 96);
            dtgCaixa.MultiSelect = false;
            dtgCaixa.Name = "dtgCaixa";
            dtgCaixa.ReadOnly = true;
            dtgCaixa.RowHeadersVisible = false;
            dtgCaixa.RowHeadersWidth = 51;
            dtgCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCaixa.Size = new Size(775, 576);
            dtgCaixa.TabIndex = 29;
            dtgCaixa.CellFormatting += dtgCaixa_CellFormatting;
            dtgCaixa.RowPrePaint += dtgCaixa_RowPrePaint;
            // 
            // IMAGEM
            // 
            IMAGEM.HeaderText = "";
            IMAGEM.MinimumWidth = 6;
            IMAGEM.Name = "IMAGEM";
            IMAGEM.ReadOnly = true;
            IMAGEM.Width = 36;
            // 
            // MOVIMENTO
            // 
            MOVIMENTO.DataPropertyName = "MOVIMENTO";
            MOVIMENTO.HeaderText = "REAL_MOVIMENTO";
            MOVIMENTO.MinimumWidth = 6;
            MOVIMENTO.Name = "MOVIMENTO";
            MOVIMENTO.ReadOnly = true;
            MOVIMENTO.Visible = false;
            MOVIMENTO.Width = 125;
            // 
            // TIPO_MOVIMENTO
            // 
            TIPO_MOVIMENTO.DataPropertyName = "TIPO_MOVIMENTO";
            TIPO_MOVIMENTO.HeaderText = "MOVIMENTO";
            TIPO_MOVIMENTO.MinimumWidth = 6;
            TIPO_MOVIMENTO.Name = "TIPO_MOVIMENTO";
            TIPO_MOVIMENTO.ReadOnly = true;
            TIPO_MOVIMENTO.Width = 225;
            // 
            // DATA
            // 
            DATA.DataPropertyName = "DATA_TRANSACAO";
            DATA.HeaderText = "DATA";
            DATA.MinimumWidth = 6;
            DATA.Name = "DATA";
            DATA.ReadOnly = true;
            DATA.Width = 150;
            // 
            // PAGAMENTO
            // 
            PAGAMENTO.DataPropertyName = "TIPO_PAGAMENTO";
            PAGAMENTO.HeaderText = "PAGAMENTO";
            PAGAMENTO.MinimumWidth = 6;
            PAGAMENTO.Name = "PAGAMENTO";
            PAGAMENTO.ReadOnly = true;
            PAGAMENTO.Width = 150;
            // 
            // VALOR
            // 
            VALOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VALOR.DataPropertyName = "VALOR";
            VALOR.HeaderText = "VALOR";
            VALOR.MinimumWidth = 6;
            VALOR.Name = "VALOR";
            VALOR.ReadOnly = true;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Image = Properties.Resources.sair;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(803, 632);
            btnSair.Name = "btnSair";
            btnSair.Padding = new Padding(3, 0, 0, 0);
            btnSair.Size = new Size(76, 40);
            btnSair.TabIndex = 28;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnFecharCaixa
            // 
            btnFecharCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFecharCaixa.Image = Properties.Resources.cadeado_fechado;
            btnFecharCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnFecharCaixa.Location = new Point(803, 527);
            btnFecharCaixa.Name = "btnFecharCaixa";
            btnFecharCaixa.Padding = new Padding(0, 0, 6, 0);
            btnFecharCaixa.Size = new Size(153, 50);
            btnFecharCaixa.TabIndex = 27;
            btnFecharCaixa.Text = "Fechar Caixa";
            btnFecharCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnFecharCaixa.UseVisualStyleBackColor = true;
            btnFecharCaixa.Click += btnFecharCaixa_Click;
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAbrirCaixa.Image = Properties.Resources.cadeado_aberto;
            btnAbrirCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirCaixa.Location = new Point(803, 527);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Padding = new Padding(0, 0, 22, 0);
            btnAbrirCaixa.Size = new Size(153, 50);
            btnAbrirCaixa.TabIndex = 26;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirCaixa.UseVisualStyleBackColor = true;
            btnAbrirCaixa.Click += btnAbrirCaixa_Click;
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
            // lblCaixaId
            // 
            lblCaixaId.AutoSize = true;
            lblCaixaId.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaixaId.ForeColor = Color.Blue;
            lblCaixaId.Location = new Point(14, 684);
            lblCaixaId.Name = "lblCaixaId";
            lblCaixaId.Size = new Size(84, 19);
            lblCaixaId.TabIndex = 31;
            lblCaixaId.Text = "Caixa #00";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(224, 224, 224);
            groupBox2.Controls.Add(lblSaldo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(lblRetirada);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblEntrada);
            groupBox2.Controls.Add(lblInicial);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(791, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(176, 296);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Image = Properties.Resources.filtro_maior;
            btnFiltrar.Location = new Point(713, 23);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(72, 53);
            btnFiltrar.TabIndex = 23;
            btnFiltrar.TextAlign = ContentAlignment.BottomCenter;
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dtpDataPagamento
            // 
            dtpDataPagamento.CustomFormat = "dd/MM/yy";
            dtpDataPagamento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataPagamento.Format = DateTimePickerFormat.Custom;
            dtpDataPagamento.Location = new Point(452, 55);
            dtpDataPagamento.Name = "dtpDataPagamento";
            dtpDataPagamento.Size = new Size(167, 27);
            dtpDataPagamento.TabIndex = 13;
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
            // cboTipoPagamento
            // 
            cboTipoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPagamento.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoPagamento.FormattingEnabled = true;
            cboTipoPagamento.Items.AddRange(new object[] { "PIX", "Dinheiro", "Cartão" });
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
            cboMovimento.Items.AddRange(new object[] { "Todos", "Suprimento", "Retirada" });
            cboMovimento.Location = new Point(6, 54);
            cboMovimento.Name = "cboMovimento";
            cboMovimento.Size = new Size(205, 27);
            cboMovimento.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Controls.Add(btnRetirada);
            groupBox3.Controls.Add(btnSuprimento);
            groupBox3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(791, 321);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 183);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lançamentos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDataPagamento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboTipoPagamento);
            groupBox1.Controls.Add(cboMovimento);
            groupBox1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(81, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(626, 90);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.caixa_maior;
            pictureBox3.Location = new Point(10, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // ucCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDataAbertura);
            Controls.Add(dtgCaixa);
            Controls.Add(btnSair);
            Controls.Add(btnFecharCaixa);
            Controls.Add(btnAbrirCaixa);
            Controls.Add(lblCaixaId);
            Controls.Add(groupBox2);
            Controls.Add(btnFiltrar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox3);
            Name = "ucCaixa";
            Size = new Size(974, 708);
            Load += ucCaixa_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCaixa).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetirada;
        private Label lblSaldo;
        private Label label9;
        private Label lblRetirada;
        private Label label7;
        private Label lblEntrada;
        private Label lblInicial;
        private Button btnSuprimento;
        private Label lblDataAbertura;
        private DataGridView dtgCaixa;
        private DataGridViewImageColumn IMAGEM;
        private DataGridViewTextBoxColumn MOVIMENTO;
        private DataGridViewTextBoxColumn TIPO_MOVIMENTO;
        private DataGridViewTextBoxColumn DATA;
        private DataGridViewTextBoxColumn PAGAMENTO;
        private DataGridViewTextBoxColumn VALOR;
        private Button btnSair;
        private Button btnFecharCaixa;
        private Button btnAbrirCaixa;
        private Label label5;
        private Label label4;
        private Label lblCaixaId;
        private GroupBox groupBox2;
        private Button btnFiltrar;
        private DateTimePicker dtpDataPagamento;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboTipoPagamento;
        private ComboBox cboMovimento;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
    }
}
