namespace Academia
{
    partial class frmConfig
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
            label1 = new Label();
            switchAutoGerar = new ToggleSwitch();
            lblDescricao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 0;
            label1.Text = "AUTO MENSALIDADES";
            // 
            // switchAutoGerar
            // 
            switchAutoGerar.AnimationSpeed = 1;
            switchAutoGerar.Location = new Point(214, 12);
            switchAutoGerar.Name = "switchAutoGerar";
            switchAutoGerar.Size = new Size(73, 35);
            switchAutoGerar.TabIndex = 1;
            switchAutoGerar.Text = "toggleSwitch1";
            switchAutoGerar.CheckedChanged += switchAutoGerar_CheckedChanged;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.Location = new Point(20, 52);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(657, 19);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Após o pagamento, o sistema cria automaticamente a próxima mensalidade da matrícula.";
            // 
            // frmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(switchAutoGerar);
            Controls.Add(lblDescricao);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConfig";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            Load += frmConfig_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToggleSwitch switchAutoGerar;
        private Label lblDescricao;
    }
}