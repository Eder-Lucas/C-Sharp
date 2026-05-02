namespace Academia
{
    partial class ucConfiguracoes
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
            switchAutoGerar = new ToggleSwitch();
            lblDescricao = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // switchAutoGerar
            // 
            switchAutoGerar.AnimationSpeed = 1;
            switchAutoGerar.Location = new Point(205, 6);
            switchAutoGerar.Name = "switchAutoGerar";
            switchAutoGerar.Size = new Size(73, 35);
            switchAutoGerar.TabIndex = 4;
            switchAutoGerar.Text = "toggleSwitch1";
            switchAutoGerar.CheckedChanged += switchAutoGerar_CheckedChanged;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(11, 46);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(657, 19);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Após o pagamento, o sistema cria automaticamente a próxima mensalidade da matrícula.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 3;
            label1.Text = "AUTO MENSALIDADES";
            // 
            // ucConfiguracoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(switchAutoGerar);
            Controls.Add(lblDescricao);
            Controls.Add(label1);
            Name = "ucConfiguracoes";
            Size = new Size(1092, 442);
            Load += frmConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToggleSwitch switchAutoGerar;
        private Label lblDescricao;
        private Label label1;
    }
}
