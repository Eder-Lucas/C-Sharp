namespace Academia
{
    partial class frmModalidades
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
            toolStrip1 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            label1 = new Label();
            txtCod = new TextBox();
            cboProfessor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rbModalidade = new RadioButton();
            rbProfessor = new RadioButton();
            txtPesquisa = new TextBox();
            txtNome = new TextBox();
            txtMensalidade = new TextBox();
            dtgModalidades = new DataGridView();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgModalidades).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(559, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.adicionar;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(109, 36);
            toolStripButton2.Text = "Adicionar";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.salvar;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(85, 36);
            toolStripButton1.Text = "Salvar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 62);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCod.Location = new Point(118, 59);
            txtCod.Name = "txtCod";
            txtCod.ReadOnly = true;
            txtCod.Size = new Size(90, 27);
            txtCod.TabIndex = 2;
            txtCod.Text = "0";
            // 
            // cboProfessor
            // 
            cboProfessor.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProfessor.FormattingEnabled = true;
            cboProfessor.Location = new Point(118, 127);
            cboProfessor.Name = "cboProfessor";
            cboProfessor.Size = new Size(431, 27);
            cboProfessor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 96);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 130);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 1;
            label3.Text = "Professor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(297, 62);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 1;
            label4.Text = "Mensalidade:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbModalidade);
            groupBox1.Controls.Add(rbProfessor);
            groupBox1.Controls.Add(txtPesquisa);
            groupBox1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 110);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisa";
            // 
            // rbModalidade
            // 
            rbModalidade.AutoSize = true;
            rbModalidade.Checked = true;
            rbModalidade.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbModalidade.Location = new Point(6, 78);
            rbModalidade.Name = "rbModalidade";
            rbModalidade.Size = new Size(102, 21);
            rbModalidade.TabIndex = 5;
            rbModalidade.TabStop = true;
            rbModalidade.Text = "Modalidade";
            rbModalidade.UseVisualStyleBackColor = true;
            // 
            // rbProfessor
            // 
            rbProfessor.AutoSize = true;
            rbProfessor.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbProfessor.Location = new Point(114, 78);
            rbProfessor.Name = "rbProfessor";
            rbProfessor.Size = new Size(93, 21);
            rbProfessor.TabIndex = 5;
            rbProfessor.Text = "Professor";
            rbProfessor.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPesquisa.Location = new Point(6, 36);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(517, 27);
            txtPesquisa.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(118, 93);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(431, 27);
            txtNome.TabIndex = 2;
            // 
            // txtMensalidade
            // 
            txtMensalidade.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMensalidade.Location = new Point(430, 59);
            txtMensalidade.Name = "txtMensalidade";
            txtMensalidade.Size = new Size(119, 27);
            txtMensalidade.TabIndex = 2;
            // 
            // dtgModalidades
            // 
            dtgModalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgModalidades.Location = new Point(10, 287);
            dtgModalidades.Name = "dtgModalidades";
            dtgModalidades.RowHeadersWidth = 51;
            dtgModalidades.Size = new Size(539, 316);
            dtgModalidades.TabIndex = 5;
            // 
            // frmModalidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 613);
            Controls.Add(dtgModalidades);
            Controls.Add(groupBox1);
            Controls.Add(cboProfessor);
            Controls.Add(txtMensalidade);
            Controls.Add(txtNome);
            Controls.Add(txtCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmModalidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCA - Controle de Modalidades";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgModalidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private Label label1;
        private TextBox txtCod;
        private ComboBox cboProfessor;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbModalidade;
        private RadioButton rbProfessor;
        private TextBox txtPesquisa;
        private TextBox txtNome;
        private TextBox txtMensalidade;
        private DataGridView dtgModalidades;
    }
}