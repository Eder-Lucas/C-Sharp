namespace Consultorio
{
    partial class frmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_CONSULTALabel;
            System.Windows.Forms.Label nOME_PACIENTELabel;
            System.Windows.Forms.Label nOME_MEDICOLabel;
            System.Windows.Forms.Label dATALabel;
            System.Windows.Forms.Label hORARIOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.nOME_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.nOME_MEDICOTextBox = new System.Windows.Forms.TextBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORARIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasDataSet = new Consultorio.ConsultasDataSet();
            this.consultasTableAdapter = new Consultorio.ConsultasDataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new Consultorio.ConsultasDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CONSULTALabel = new System.Windows.Forms.Label();
            nOME_PACIENTELabel = new System.Windows.Forms.Label();
            nOME_MEDICOLabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            hORARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONSULTALabel
            // 
            iD_CONSULTALabel.AutoSize = true;
            iD_CONSULTALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CONSULTALabel.Location = new System.Drawing.Point(29, 55);
            iD_CONSULTALabel.Name = "iD_CONSULTALabel";
            iD_CONSULTALabel.Size = new System.Drawing.Size(84, 24);
            iD_CONSULTALabel.TabIndex = 1;
            iD_CONSULTALabel.Text = "Código:";
            // 
            // nOME_PACIENTELabel
            // 
            nOME_PACIENTELabel.AutoSize = true;
            nOME_PACIENTELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_PACIENTELabel.Location = new System.Drawing.Point(15, 100);
            nOME_PACIENTELabel.Name = "nOME_PACIENTELabel";
            nOME_PACIENTELabel.Size = new System.Drawing.Size(98, 24);
            nOME_PACIENTELabel.TabIndex = 3;
            nOME_PACIENTELabel.Text = "Paciente:";
            // 
            // nOME_MEDICOLabel
            // 
            nOME_MEDICOLabel.AutoSize = true;
            nOME_MEDICOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_MEDICOLabel.Location = new System.Drawing.Point(28, 144);
            nOME_MEDICOLabel.Name = "nOME_MEDICOLabel";
            nOME_MEDICOLabel.Size = new System.Drawing.Size(85, 24);
            nOME_MEDICOLabel.TabIndex = 5;
            nOME_MEDICOLabel.Text = "Médico:";
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATALabel.Location = new System.Drawing.Point(53, 191);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(60, 24);
            dATALabel.TabIndex = 7;
            dATALabel.Text = "Data:";
            // 
            // hORARIOLabel
            // 
            hORARIOLabel.AutoSize = true;
            hORARIOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hORARIOLabel.Location = new System.Drawing.Point(26, 237);
            hORARIOLabel.Name = "hORARIOLabel";
            hORARIOLabel.Size = new System.Drawing.Size(87, 24);
            hORARIOLabel.TabIndex = 9;
            hORARIOLabel.Text = "Horário:";
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
            this.consultasBindingNavigator.Size = new System.Drawing.Size(572, 31);
            this.consultasBindingNavigator.TabIndex = 0;
            this.consultasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // consultasBindingNavigatorSaveItem
            // 
            this.consultasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasBindingNavigatorSaveItem.Image")));
            this.consultasBindingNavigatorSaveItem.Name = "consultasBindingNavigatorSaveItem";
            this.consultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.consultasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click);
            // 
            // iD_CONSULTATextBox
            // 
            this.iD_CONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "ID_CONSULTA", true));
            this.iD_CONSULTATextBox.Enabled = false;
            this.iD_CONSULTATextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CONSULTATextBox.Location = new System.Drawing.Point(119, 52);
            this.iD_CONSULTATextBox.Name = "iD_CONSULTATextBox";
            this.iD_CONSULTATextBox.Size = new System.Drawing.Size(146, 30);
            this.iD_CONSULTATextBox.TabIndex = 2;
            // 
            // nOME_PACIENTETextBox
            // 
            this.nOME_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "NOME_PACIENTE", true));
            this.nOME_PACIENTETextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_PACIENTETextBox.Location = new System.Drawing.Point(119, 97);
            this.nOME_PACIENTETextBox.Name = "nOME_PACIENTETextBox";
            this.nOME_PACIENTETextBox.Size = new System.Drawing.Size(422, 30);
            this.nOME_PACIENTETextBox.TabIndex = 4;
            // 
            // nOME_MEDICOTextBox
            // 
            this.nOME_MEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "NOME_MEDICO", true));
            this.nOME_MEDICOTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_MEDICOTextBox.Location = new System.Drawing.Point(119, 144);
            this.nOME_MEDICOTextBox.Name = "nOME_MEDICOTextBox";
            this.nOME_MEDICOTextBox.Size = new System.Drawing.Size(422, 30);
            this.nOME_MEDICOTextBox.TabIndex = 6;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "DATA", true));
            this.dATADateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(119, 191);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(146, 30);
            this.dATADateTimePicker.TabIndex = 8;
            // 
            // hORARIODateTimePicker
            // 
            this.hORARIODateTimePicker.CustomFormat = "HH:mm";
            this.hORARIODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "HORARIO", true));
            this.hORARIODateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hORARIODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hORARIODateTimePicker.Location = new System.Drawing.Point(119, 234);
            this.hORARIODateTimePicker.Name = "hORARIODateTimePicker";
            this.hORARIODateTimePicker.ShowUpDown = true;
            this.hORARIODateTimePicker.Size = new System.Drawing.Size(146, 30);
            this.hORARIODateTimePicker.TabIndex = 10;
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AllowUserToAddRows = false;
            this.consultasDataGridView.AllowUserToDeleteRows = false;
            this.consultasDataGridView.AutoGenerateColumns = false;
            this.consultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.consultasDataGridView.DataSource = this.consultasBindingSource;
            this.consultasDataGridView.Location = new System.Drawing.Point(17, 279);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.ReadOnly = true;
            this.consultasDataGridView.RowHeadersVisible = false;
            this.consultasDataGridView.RowHeadersWidth = 51;
            this.consultasDataGridView.RowTemplate.Height = 24;
            this.consultasDataGridView.Size = new System.Drawing.Size(535, 331);
            this.consultasDataGridView.TabIndex = 11;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.consultasDataSet;
            // 
            // consultasDataSet
            // 
            this.consultasDataSet.DataSetName = "ConsultasDataSet";
            this.consultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = this.consultasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Consultorio.ConsultasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CONSULTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_CONSULTA";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PACIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME_MEDICO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Médico";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 135;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Data";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HORARIO";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Horário";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(572, 622);
            this.Controls.Add(this.consultasDataGridView);
            this.Controls.Add(iD_CONSULTALabel);
            this.Controls.Add(this.iD_CONSULTATextBox);
            this.Controls.Add(nOME_PACIENTELabel);
            this.Controls.Add(this.nOME_PACIENTETextBox);
            this.Controls.Add(nOME_MEDICOLabel);
            this.Controls.Add(this.nOME_MEDICOTextBox);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dATADateTimePicker);
            this.Controls.Add(hORARIOLabel);
            this.Controls.Add(this.hORARIODateTimePicker);
            this.Controls.Add(this.consultasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).EndInit();
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
        private System.Windows.Forms.TextBox nOME_PACIENTETextBox;
        private System.Windows.Forms.TextBox nOME_MEDICOTextBox;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.DateTimePicker hORARIODateTimePicker;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

