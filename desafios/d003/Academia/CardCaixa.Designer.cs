namespace Academia
{
    partial class CardCaixa
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
            label1 = new Label();
            lblCaixa = new Label();
            lblSaldo = new Label();
            lblSituacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "card";
            // 
            // lblCaixa
            // 
            lblCaixa.AutoSize = true;
            lblCaixa.Location = new Point(14, 47);
            lblCaixa.Name = "lblCaixa";
            lblCaixa.Size = new Size(22, 20);
            lblCaixa.TabIndex = 0;
            lblCaixa.Text = "id";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(14, 77);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(45, 20);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "saldo";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(14, 107);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(64, 20);
            lblSituacao.TabIndex = 0;
            lblSituacao.Text = "situacao";
            // 
            // CardCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lblSituacao);
            Controls.Add(lblSaldo);
            Controls.Add(lblCaixa);
            Controls.Add(label1);
            Margin = new Padding(15);
            Name = "CardCaixa";
            Size = new Size(329, 236);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCaixa;
        private Label lblSaldo;
        private Label lblSituacao;
    }
}
