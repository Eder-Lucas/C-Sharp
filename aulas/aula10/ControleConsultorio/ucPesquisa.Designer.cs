namespace ControleConsultorio
{
    partial class ucPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisaUC = new System.Windows.Forms.Button();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.consultasTableAdapter1 = new ControleConsultorio.ConsultasDataSetTableAdapters.ConsultasTableAdapter();
            this.ID_CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETORNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(631, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 153);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultas do dia";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 88);
            this.label3.TabIndex = 0;
            this.label3.Text = "Para exibir consultas do dia, defina a data nos campos apropiados e clique em Pes" +
    "quisar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisaUC);
            this.groupBox2.Controls.Add(this.rbPaciente);
            this.groupBox2.Controls.Add(this.rbMedico);
            this.groupBox2.Controls.Add(this.txtPesquisa);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 153);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros de pesquisa";
            // 
            // btnPesquisaUC
            // 
            this.btnPesquisaUC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaUC.Image = global::ControleConsultorio.Properties.Resources.pequena_lupa;
            this.btnPesquisaUC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisaUC.Location = new System.Drawing.Point(255, 93);
            this.btnPesquisaUC.Name = "btnPesquisaUC";
            this.btnPesquisaUC.Size = new System.Drawing.Size(108, 27);
            this.btnPesquisaUC.TabIndex = 2;
            this.btnPesquisaUC.Text = "Pesquisar";
            this.btnPesquisaUC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisaUC.UseVisualStyleBackColor = true;
            this.btnPesquisaUC.Click += new System.EventHandler(this.btnPesquisaUC_Click);
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Checked = true;
            this.rbPaciente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaciente.Location = new System.Drawing.Point(16, 97);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(94, 23);
            this.rbPaciente.TabIndex = 1;
            this.rbPaciente.TabStop = true;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = true;
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedico.Location = new System.Drawing.Point(116, 97);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(83, 23);
            this.rbMedico.TabIndex = 1;
            this.rbMedico.Text = "Médico";
            this.rbMedico.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(357, 27);
            this.txtPesquisa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFinal);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo entre datas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "De:";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(54, 41);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(136, 27);
            this.dtpInicial.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Até:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(54, 93);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(136, 27);
            this.dtpFinal.TabIndex = 0;
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.AllowUserToAddRows = false;
            this.dtgConsultas.AllowUserToDeleteRows = false;
            this.dtgConsultas.AllowUserToOrderColumns = true;
            this.dtgConsultas.AllowUserToResizeColumns = false;
            this.dtgConsultas.AllowUserToResizeRows = false;
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CODIGO,
            this.ID_MEDICO,
            this.ID_PACIENTE,
            this.RETORNO,
            this.NOME_PACIENTE,
            this.NOME_MEDICO,
            this.DATA,
            this.HORARIO});
            this.dtgConsultas.Location = new System.Drawing.Point(3, 183);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.ReadOnly = true;
            this.dtgConsultas.RowHeadersVisible = false;
            this.dtgConsultas.RowHeadersWidth = 51;
            this.dtgConsultas.RowTemplate.Height = 24;
            this.dtgConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsultas.Size = new System.Drawing.Size(929, 360);
            this.dtgConsultas.TabIndex = 9;
            // 
            // consultasTableAdapter1
            // 
            this.consultasTableAdapter1.ClearBeforeFill = true;
            // 
            // ID_CODIGO
            // 
            this.ID_CODIGO.DataPropertyName = "ID_CONSULTA";
            this.ID_CODIGO.FillWeight = 3.790212F;
            this.ID_CODIGO.HeaderText = "CÓDIGO";
            this.ID_CODIGO.MinimumWidth = 6;
            this.ID_CODIGO.Name = "ID_CODIGO";
            this.ID_CODIGO.ReadOnly = true;
            this.ID_CODIGO.Width = 71;
            // 
            // ID_MEDICO
            // 
            this.ID_MEDICO.DataPropertyName = "ID_MEDICO";
            this.ID_MEDICO.HeaderText = "CÓDIGO MÉDICO";
            this.ID_MEDICO.MinimumWidth = 6;
            this.ID_MEDICO.Name = "ID_MEDICO";
            this.ID_MEDICO.ReadOnly = true;
            this.ID_MEDICO.Visible = false;
            this.ID_MEDICO.Width = 125;
            // 
            // ID_PACIENTE
            // 
            this.ID_PACIENTE.DataPropertyName = "ID_PACIENTE";
            this.ID_PACIENTE.HeaderText = "CÓDIGO PACIENTE";
            this.ID_PACIENTE.MinimumWidth = 6;
            this.ID_PACIENTE.Name = "ID_PACIENTE";
            this.ID_PACIENTE.ReadOnly = true;
            this.ID_PACIENTE.Visible = false;
            this.ID_PACIENTE.Width = 125;
            // 
            // RETORNO
            // 
            this.RETORNO.DataPropertyName = "RETORNO";
            this.RETORNO.HeaderText = "RETORNO";
            this.RETORNO.MinimumWidth = 6;
            this.RETORNO.Name = "RETORNO";
            this.RETORNO.ReadOnly = true;
            this.RETORNO.Visible = false;
            this.RETORNO.Width = 125;
            // 
            // NOME_PACIENTE
            // 
            this.NOME_PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.NOME_PACIENTE.FillWeight = 57.28467F;
            this.NOME_PACIENTE.HeaderText = "PACIENTE";
            this.NOME_PACIENTE.MinimumWidth = 6;
            this.NOME_PACIENTE.Name = "NOME_PACIENTE";
            this.NOME_PACIENTE.ReadOnly = true;
            this.NOME_PACIENTE.Width = 345;
            // 
            // NOME_MEDICO
            // 
            this.NOME_MEDICO.DataPropertyName = "NOME_MEDICO";
            this.NOME_MEDICO.FillWeight = 435.8289F;
            this.NOME_MEDICO.HeaderText = "MÉDICO";
            this.NOME_MEDICO.MinimumWidth = 6;
            this.NOME_MEDICO.Name = "NOME_MEDICO";
            this.NOME_MEDICO.ReadOnly = true;
            this.NOME_MEDICO.Width = 345;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle5;
            this.DATA.FillWeight = 1.548115F;
            this.DATA.HeaderText = "DATA";
            this.DATA.MinimumWidth = 6;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 81;
            // 
            // HORARIO
            // 
            this.HORARIO.DataPropertyName = "HORARIO";
            dataGridViewCellStyle6.Format = "t";
            dataGridViewCellStyle6.NullValue = null;
            this.HORARIO.DefaultCellStyle = dataGridViewCellStyle6;
            this.HORARIO.FillWeight = 1.548115F;
            this.HORARIO.HeaderText = "HORÁRIO";
            this.HORARIO.MinimumWidth = 6;
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            this.HORARIO.Width = 84;
            // 
            // ucPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgConsultas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucPesquisa";
            this.Size = new System.Drawing.Size(935, 547);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnPesquisaUC;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private ConsultasDataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETORNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
    }
}
