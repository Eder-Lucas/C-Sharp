namespace ControleConsultorio
{
    partial class frmConsultas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_CONSULTALabel;
            System.Windows.Forms.Label iD_MEDICOLabel;
            System.Windows.Forms.Label iD_PACIENTELabel;
            System.Windows.Forms.Label dATALabel;
            System.Windows.Forms.Label hORARIOLabel;
            System.Windows.Forms.Label rETORNOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.consultasDataSet = new ControleConsultorio.ConsultasDataSet();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasTableAdapter = new ControleConsultorio.ConsultasDataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new ControleConsultorio.ConsultasDataSetTableAdapters.TableAdapterManager();
            this.medicoTableAdapter = new ControleConsultorio.ConsultasDataSetTableAdapters.MedicoTableAdapter();
            this.pacienteTableAdapter = new ControleConsultorio.ConsultasDataSetTableAdapters.PacienteTableAdapter();
            this.consultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CONSULTATextBox = new System.Windows.Forms.TextBox();
            this.iD_MEDICOComboBox = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_PACIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORARIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rETORNOCheckBox = new System.Windows.Forms.CheckBox();
            iD_CONSULTALabel = new System.Windows.Forms.Label();
            iD_MEDICOLabel = new System.Windows.Forms.Label();
            iD_PACIENTELabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            hORARIOLabel = new System.Windows.Forms.Label();
            rETORNOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONSULTALabel
            // 
            iD_CONSULTALabel.AutoSize = true;
            iD_CONSULTALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CONSULTALabel.Location = new System.Drawing.Point(30, 49);
            iD_CONSULTALabel.Name = "iD_CONSULTALabel";
            iD_CONSULTALabel.Size = new System.Drawing.Size(84, 24);
            iD_CONSULTALabel.TabIndex = 1;
            iD_CONSULTALabel.Text = "Código:";
            // 
            // iD_MEDICOLabel
            // 
            iD_MEDICOLabel.AutoSize = true;
            iD_MEDICOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_MEDICOLabel.Location = new System.Drawing.Point(29, 87);
            iD_MEDICOLabel.Name = "iD_MEDICOLabel";
            iD_MEDICOLabel.Size = new System.Drawing.Size(85, 24);
            iD_MEDICOLabel.TabIndex = 3;
            iD_MEDICOLabel.Text = "Médico:";
            // 
            // iD_PACIENTELabel
            // 
            iD_PACIENTELabel.AutoSize = true;
            iD_PACIENTELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PACIENTELabel.Location = new System.Drawing.Point(16, 125);
            iD_PACIENTELabel.Name = "iD_PACIENTELabel";
            iD_PACIENTELabel.Size = new System.Drawing.Size(98, 24);
            iD_PACIENTELabel.TabIndex = 5;
            iD_PACIENTELabel.Text = "Paciente:";
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATALabel.Location = new System.Drawing.Point(54, 163);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(60, 24);
            dATALabel.TabIndex = 7;
            dATALabel.Text = "Data:";
            // 
            // hORARIOLabel
            // 
            hORARIOLabel.AutoSize = true;
            hORARIOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hORARIOLabel.Location = new System.Drawing.Point(308, 164);
            hORARIOLabel.Name = "hORARIOLabel";
            hORARIOLabel.Size = new System.Drawing.Size(87, 24);
            hORARIOLabel.TabIndex = 9;
            hORARIOLabel.Text = "Horário:";
            // 
            // rETORNOLabel
            // 
            rETORNOLabel.AutoSize = true;
            rETORNOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rETORNOLabel.Location = new System.Drawing.Point(22, 201);
            rETORNOLabel.Name = "rETORNOLabel";
            rETORNOLabel.Size = new System.Drawing.Size(93, 24);
            rETORNOLabel.TabIndex = 11;
            rETORNOLabel.Text = "Retorno:";
            // 
            // consultasDataSet
            // 
            this.consultasDataSet.DataSetName = "ConsultasDataSet";
            this.consultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.consultasDataSet;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = this.consultasTableAdapter;
            this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControleConsultorio.ConsultasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // consultasBindingNavigator
            // 
            this.consultasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultasBindingNavigator.BindingSource = this.consultasBindingSource;
            this.consultasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultasBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.consultasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consultasBindingNavigatorSaveItem});
            this.consultasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultasBindingNavigator.Name = "consultasBindingNavigator";
            this.consultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultasBindingNavigator.Size = new System.Drawing.Size(506, 27);
            this.consultasBindingNavigator.TabIndex = 0;
            this.consultasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // consultasBindingNavigatorSaveItem
            // 
            this.consultasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasBindingNavigatorSaveItem.Image")));
            this.consultasBindingNavigatorSaveItem.Name = "consultasBindingNavigatorSaveItem";
            this.consultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.consultasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click_1);
            // 
            // iD_CONSULTATextBox
            // 
            this.iD_CONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "ID_CONSULTA", true));
            this.iD_CONSULTATextBox.Enabled = false;
            this.iD_CONSULTATextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CONSULTATextBox.Location = new System.Drawing.Point(120, 49);
            this.iD_CONSULTATextBox.Name = "iD_CONSULTATextBox";
            this.iD_CONSULTATextBox.ReadOnly = true;
            this.iD_CONSULTATextBox.Size = new System.Drawing.Size(87, 27);
            this.iD_CONSULTATextBox.TabIndex = 2;
            // 
            // iD_MEDICOComboBox
            // 
            this.iD_MEDICOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultasBindingSource, "ID_MEDICO", true));
            this.iD_MEDICOComboBox.DataSource = this.medicoBindingSource;
            this.iD_MEDICOComboBox.DisplayMember = "NOME_MEDICO";
            this.iD_MEDICOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_MEDICOComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_MEDICOComboBox.FormattingEnabled = true;
            this.iD_MEDICOComboBox.Location = new System.Drawing.Point(120, 87);
            this.iD_MEDICOComboBox.Name = "iD_MEDICOComboBox";
            this.iD_MEDICOComboBox.Size = new System.Drawing.Size(361, 27);
            this.iD_MEDICOComboBox.TabIndex = 4;
            this.iD_MEDICOComboBox.ValueMember = "ID_MEDICO";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultasDataSet;
            // 
            // iD_PACIENTEComboBox
            // 
            this.iD_PACIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultasBindingSource, "ID_PACIENTE", true));
            this.iD_PACIENTEComboBox.DataSource = this.pacienteBindingSource;
            this.iD_PACIENTEComboBox.DisplayMember = "NOME_PACIENTE";
            this.iD_PACIENTEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_PACIENTEComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PACIENTEComboBox.FormattingEnabled = true;
            this.iD_PACIENTEComboBox.Location = new System.Drawing.Point(120, 125);
            this.iD_PACIENTEComboBox.Name = "iD_PACIENTEComboBox";
            this.iD_PACIENTEComboBox.Size = new System.Drawing.Size(361, 27);
            this.iD_PACIENTEComboBox.TabIndex = 6;
            this.iD_PACIENTEComboBox.ValueMember = "ID_PACIENTE";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultasDataSet;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "DATA", true));
            this.dATADateTimePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(120, 163);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(128, 27);
            this.dATADateTimePicker.TabIndex = 8;
            // 
            // hORARIODateTimePicker
            // 
            this.hORARIODateTimePicker.CustomFormat = "HH:mm";
            this.hORARIODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "HORARIO", true));
            this.hORARIODateTimePicker.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hORARIODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hORARIODateTimePicker.Location = new System.Drawing.Point(401, 164);
            this.hORARIODateTimePicker.Name = "hORARIODateTimePicker";
            this.hORARIODateTimePicker.ShowUpDown = true;
            this.hORARIODateTimePicker.Size = new System.Drawing.Size(81, 27);
            this.hORARIODateTimePicker.TabIndex = 10;
            // 
            // rETORNOCheckBox
            // 
            this.rETORNOCheckBox.Checked = true;
            this.rETORNOCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rETORNOCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.consultasBindingSource, "RETORNO", true));
            this.rETORNOCheckBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rETORNOCheckBox.Location = new System.Drawing.Point(121, 201);
            this.rETORNOCheckBox.Name = "rETORNOCheckBox";
            this.rETORNOCheckBox.Size = new System.Drawing.Size(200, 27);
            this.rETORNOCheckBox.TabIndex = 12;
            this.rETORNOCheckBox.Text = "Sim";
            this.rETORNOCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 242);
            this.Controls.Add(iD_CONSULTALabel);
            this.Controls.Add(this.iD_CONSULTATextBox);
            this.Controls.Add(iD_MEDICOLabel);
            this.Controls.Add(this.iD_MEDICOComboBox);
            this.Controls.Add(iD_PACIENTELabel);
            this.Controls.Add(this.iD_PACIENTEComboBox);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dATADateTimePicker);
            this.Controls.Add(hORARIOLabel);
            this.Controls.Add(this.hORARIODateTimePicker);
            this.Controls.Add(rETORNOLabel);
            this.Controls.Add(this.rETORNOCheckBox);
            this.Controls.Add(this.consultasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultasDataSet consultasDataSet;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private ConsultasDataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private ConsultasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consultasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CONSULTATextBox;
        private System.Windows.Forms.ComboBox iD_MEDICOComboBox;
        private System.Windows.Forms.ComboBox iD_PACIENTEComboBox;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.DateTimePicker hORARIODateTimePicker;
        private System.Windows.Forms.CheckBox rETORNOCheckBox;
        private ConsultasDataSetTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ConsultasDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
    }
}