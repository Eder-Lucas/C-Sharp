namespace Academia
{
    partial class frmHorarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            cboSemana = new ComboBox();
            dtpInicio = new DateTimePicker();
            btnAdicionar = new Button();
            dtgHorarios = new DataGridView();
            ID_HORARIO = new DataGridViewTextBoxColumn();
            ID_TURMA = new DataGridViewTextBoxColumn();
            DIA_SEMANA = new DataGridViewTextBoxColumn();
            SEMANA_NOME = new DataGridViewTextBoxColumn();
            INICIO = new DataGridViewTextBoxColumn();
            FIM = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            dtpFim = new DateTimePicker();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgHorarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 0;
            label1.Text = "Dia da Semana:";
            // 
            // cboSemana
            // 
            cboSemana.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemana.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSemana.FormattingEnabled = true;
            cboSemana.Items.AddRange(new object[] { "- Selecione um dia -", "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" });
            cboSemana.Location = new Point(12, 33);
            cboSemana.Name = "cboSemana";
            cboSemana.Size = new Size(174, 27);
            cboSemana.TabIndex = 1;
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(202, 33);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(82, 27);
            dtpInicio.TabIndex = 2;
            dtpInicio.Value = new DateTime(2026, 3, 8, 15, 59, 0, 0);
            // 
            // btnAdicionar
            // 
            btnAdicionar.Image = Properties.Resources.adicionar;
            btnAdicionar.Location = new Point(388, 75);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(68, 54);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dtgHorarios
            // 
            dtgHorarios.AllowUserToAddRows = false;
            dtgHorarios.AllowUserToDeleteRows = false;
            dtgHorarios.AllowUserToResizeColumns = false;
            dtgHorarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHorarios.Columns.AddRange(new DataGridViewColumn[] { ID_HORARIO, ID_TURMA, DIA_SEMANA, SEMANA_NOME, INICIO, FIM });
            dtgHorarios.Location = new Point(12, 75);
            dtgHorarios.MultiSelect = false;
            dtgHorarios.Name = "dtgHorarios";
            dtgHorarios.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgHorarios.RowHeadersVisible = false;
            dtgHorarios.RowHeadersWidth = 51;
            dtgHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgHorarios.Size = new Size(370, 234);
            dtgHorarios.TabIndex = 4;
            // 
            // ID_HORARIO
            // 
            ID_HORARIO.DataPropertyName = "ID_HORARIO";
            ID_HORARIO.HeaderText = "ID_HORARIO";
            ID_HORARIO.MinimumWidth = 6;
            ID_HORARIO.Name = "ID_HORARIO";
            ID_HORARIO.ReadOnly = true;
            ID_HORARIO.Visible = false;
            ID_HORARIO.Width = 125;
            // 
            // ID_TURMA
            // 
            ID_TURMA.DataPropertyName = "ID_TURMA";
            ID_TURMA.HeaderText = "ID_TURMA";
            ID_TURMA.MinimumWidth = 6;
            ID_TURMA.Name = "ID_TURMA";
            ID_TURMA.ReadOnly = true;
            ID_TURMA.Visible = false;
            ID_TURMA.Width = 125;
            // 
            // DIA_SEMANA
            // 
            DIA_SEMANA.DataPropertyName = "DIA_SEMANA";
            DIA_SEMANA.HeaderText = "DIA_SEMANA";
            DIA_SEMANA.MinimumWidth = 6;
            DIA_SEMANA.Name = "DIA_SEMANA";
            DIA_SEMANA.ReadOnly = true;
            DIA_SEMANA.Visible = false;
            DIA_SEMANA.Width = 150;
            // 
            // SEMANA_NOME
            // 
            SEMANA_NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SEMANA_NOME.DataPropertyName = "SEMANA_NOME";
            SEMANA_NOME.HeaderText = "DIA DA SEMANA";
            SEMANA_NOME.MinimumWidth = 6;
            SEMANA_NOME.Name = "SEMANA_NOME";
            SEMANA_NOME.ReadOnly = true;
            // 
            // INICIO
            // 
            INICIO.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            INICIO.DataPropertyName = "INICIO";
            INICIO.HeaderText = "INÍCIO";
            INICIO.MinimumWidth = 6;
            INICIO.Name = "INICIO";
            INICIO.ReadOnly = true;
            INICIO.Width = 60;
            // 
            // FIM
            // 
            FIM.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FIM.DataPropertyName = "FIM";
            FIM.HeaderText = "FIM";
            FIM.MinimumWidth = 6;
            FIM.Name = "FIM";
            FIM.ReadOnly = true;
            FIM.Width = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 0;
            label2.Text = "Início:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 0;
            label3.Text = "Fim:";
            // 
            // dtpFim
            // 
            dtpFim.CustomFormat = "HH:mm";
            dtpFim.Format = DateTimePickerFormat.Custom;
            dtpFim.Location = new Point(300, 33);
            dtpFim.Name = "dtpFim";
            dtpFim.ShowUpDown = true;
            dtpFim.Size = new Size(82, 27);
            dtpFim.TabIndex = 2;
            dtpFim.Value = new DateTime(2026, 3, 8, 15, 59, 0, 0);
            // 
            // btnSalvar
            // 
            btnSalvar.Image = Properties.Resources.salvar;
            btnSalvar.Location = new Point(388, 135);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(68, 54);
            btnSalvar.TabIndex = 3;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = Properties.Resources.excluir;
            btnExcluir.Location = new Point(388, 195);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(68, 54);
            btnExcluir.TabIndex = 3;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(388, 255);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(68, 54);
            btnEditar.TabIndex = 3;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // frmHorarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 321);
            Controls.Add(dtgHorarios);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnAdicionar);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(cboSemana);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHorarios";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmHorarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgHorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboSemana;
        private DateTimePicker dtpInicio;
        private Button btnAdicionar;
        private DataGridView dtgHorarios;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpFim;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnEditar;
        private DataGridViewTextBoxColumn ID_HORARIO;
        private DataGridViewTextBoxColumn ID_TURMA;
        private DataGridViewTextBoxColumn DIA_SEMANA;
        private DataGridViewTextBoxColumn SEMANA_NOME;
        private DataGridViewTextBoxColumn INICIO;
        private DataGridViewTextBoxColumn FIM;
    }
}