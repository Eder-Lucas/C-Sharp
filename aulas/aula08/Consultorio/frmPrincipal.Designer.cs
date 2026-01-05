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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultasDataSet = new Consultorio.ConsultasDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CONSULTATextBox = new System.Windows.Forms.TextBox();
            this.nOME_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.nOME_MEDICOTextBox = new System.Windows.Forms.TextBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORARIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbPaciente = new System.Windows.Forms.RadioButton();
            this.rbMedico = new System.Windows.Forms.RadioButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.consultasTableAdapter = new Consultorio.ConsultasDataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new Consultorio.ConsultasDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CONSULTALabel = new System.Windows.Forms.Label();
            nOME_PACIENTELabel = new System.Windows.Forms.Label();
            nOME_MEDICOLabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            hORARIOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONSULTALabel
            // 
            iD_CONSULTALabel.AutoSize = true;
            iD_CONSULTALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CONSULTALabel.Location = new System.Drawing.Point(32, 58);
            iD_CONSULTALabel.Name = "iD_CONSULTALabel";
            iD_CONSULTALabel.Size = new System.Drawing.Size(84, 24);
            iD_CONSULTALabel.TabIndex = 1;
            iD_CONSULTALabel.Text = "Código:";
            // 
            // nOME_PACIENTELabel
            // 
            nOME_PACIENTELabel.AutoSize = true;
            nOME_PACIENTELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_PACIENTELabel.Location = new System.Drawing.Point(18, 103);
            nOME_PACIENTELabel.Name = "nOME_PACIENTELabel";
            nOME_PACIENTELabel.Size = new System.Drawing.Size(98, 24);
            nOME_PACIENTELabel.TabIndex = 3;
            nOME_PACIENTELabel.Text = "Paciente:";
            // 
            // nOME_MEDICOLabel
            // 
            nOME_MEDICOLabel.AutoSize = true;
            nOME_MEDICOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_MEDICOLabel.Location = new System.Drawing.Point(31, 147);
            nOME_MEDICOLabel.Name = "nOME_MEDICOLabel";
            nOME_MEDICOLabel.Size = new System.Drawing.Size(85, 24);
            nOME_MEDICOLabel.TabIndex = 5;
            nOME_MEDICOLabel.Text = "Médico:";
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATALabel.Location = new System.Drawing.Point(56, 194);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(60, 24);
            dATALabel.TabIndex = 7;
            dATALabel.Text = "Data:";
            // 
            // hORARIOLabel
            // 
            hORARIOLabel.AutoSize = true;
            hORARIOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hORARIOLabel.Location = new System.Drawing.Point(29, 240);
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
            this.consultasBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.consultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultasBindingNavigator.Name = "consultasBindingNavigator";
            this.consultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultasBindingNavigator.Size = new System.Drawing.Size(565, 27);
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
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
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
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click);
            // 
            // iD_CONSULTATextBox
            // 
            this.iD_CONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "ID_CONSULTA", true));
            this.iD_CONSULTATextBox.Enabled = false;
            this.iD_CONSULTATextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CONSULTATextBox.Location = new System.Drawing.Point(122, 55);
            this.iD_CONSULTATextBox.Name = "iD_CONSULTATextBox";
            this.iD_CONSULTATextBox.Size = new System.Drawing.Size(146, 30);
            this.iD_CONSULTATextBox.TabIndex = 2;
            // 
            // nOME_PACIENTETextBox
            // 
            this.nOME_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "NOME_PACIENTE", true));
            this.nOME_PACIENTETextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_PACIENTETextBox.Location = new System.Drawing.Point(122, 100);
            this.nOME_PACIENTETextBox.Name = "nOME_PACIENTETextBox";
            this.nOME_PACIENTETextBox.Size = new System.Drawing.Size(422, 30);
            this.nOME_PACIENTETextBox.TabIndex = 4;
            // 
            // nOME_MEDICOTextBox
            // 
            this.nOME_MEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "NOME_MEDICO", true));
            this.nOME_MEDICOTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_MEDICOTextBox.Location = new System.Drawing.Point(122, 147);
            this.nOME_MEDICOTextBox.Name = "nOME_MEDICOTextBox";
            this.nOME_MEDICOTextBox.Size = new System.Drawing.Size(422, 30);
            this.nOME_MEDICOTextBox.TabIndex = 6;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "DATA", true));
            this.dATADateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(122, 194);
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
            this.hORARIODateTimePicker.Location = new System.Drawing.Point(122, 237);
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
            this.consultasDataGridView.Location = new System.Drawing.Point(0, 282);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.ReadOnly = true;
            this.consultasDataGridView.RowHeadersVisible = false;
            this.consultasDataGridView.RowHeadersWidth = 51;
            this.consultasDataGridView.RowTemplate.Height = 24;
            this.consultasDataGridView.Size = new System.Drawing.Size(571, 352);
            this.consultasDataGridView.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(579, 663);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.consultasBindingNavigator);
            this.tabPage1.Controls.Add(this.consultasDataGridView);
            this.tabPage1.Controls.Add(this.hORARIODateTimePicker);
            this.tabPage1.Controls.Add(iD_CONSULTALabel);
            this.tabPage1.Controls.Add(hORARIOLabel);
            this.tabPage1.Controls.Add(this.iD_CONSULTATextBox);
            this.tabPage1.Controls.Add(this.dATADateTimePicker);
            this.tabPage1.Controls.Add(nOME_PACIENTELabel);
            this.tabPage1.Controls.Add(dATALabel);
            this.tabPage1.Controls.Add(this.nOME_PACIENTETextBox);
            this.tabPage1.Controls.Add(this.nOME_MEDICOTextBox);
            this.tabPage1.Controls.Add(nOME_MEDICOLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgPesquisa);
            this.tabPage2.Controls.Add(this.btnPesquisar);
            this.tabPage2.Controls.Add(this.rbPaciente);
            this.tabPage2.Controls.Add(this.rbMedico);
            this.tabPage2.Controls.Add(this.txtPesquisa);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.AllowUserToAddRows = false;
            this.dtgPesquisa.AllowUserToDeleteRows = false;
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PACIENTE,
            this.MEDICO,
            this.DATA,
            this.HORARIO});
            this.dtgPesquisa.Location = new System.Drawing.Point(0, 118);
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.ReadOnly = true;
            this.dtgPesquisa.RowHeadersVisible = false;
            this.dtgPesquisa.RowHeadersWidth = 51;
            this.dtgPesquisa.RowTemplate.Height = 24;
            this.dtgPesquisa.Size = new System.Drawing.Size(571, 516);
            this.dtgPesquisa.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::Consultorio.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(479, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 61);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbPaciente
            // 
            this.rbPaciente.AutoSize = true;
            this.rbPaciente.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPaciente.Location = new System.Drawing.Point(116, 55);
            this.rbPaciente.Name = "rbPaciente";
            this.rbPaciente.Size = new System.Drawing.Size(101, 25);
            this.rbPaciente.TabIndex = 2;
            this.rbPaciente.Text = "Paciente";
            this.rbPaciente.UseVisualStyleBackColor = true;
            // 
            // rbMedico
            // 
            this.rbMedico.AutoSize = true;
            this.rbMedico.Checked = true;
            this.rbMedico.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedico.Location = new System.Drawing.Point(21, 55);
            this.rbMedico.Name = "rbMedico";
            this.rbMedico.Size = new System.Drawing.Size(89, 25);
            this.rbMedico.TabIndex = 1;
            this.rbMedico.TabStop = true;
            this.rbMedico.Text = "Médico";
            this.rbMedico.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(8, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(453, 30);
            this.txtPesquisa.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME_MEDICO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Médico";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
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
            this.dataGridViewTextBoxColumn4.Width = 82;
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
            this.dataGridViewTextBoxColumn5.Width = 76;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_CONSULTA";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.MinimumWidth = 6;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 125;
            // 
            // PACIENTE
            // 
            this.PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.PACIENTE.HeaderText = "Paciente";
            this.PACIENTE.MinimumWidth = 6;
            this.PACIENTE.Name = "PACIENTE";
            this.PACIENTE.ReadOnly = true;
            this.PACIENTE.Width = 210;
            // 
            // MEDICO
            // 
            this.MEDICO.DataPropertyName = "NOME_MEDICO";
            this.MEDICO.HeaderText = "Médico";
            this.MEDICO.MinimumWidth = 6;
            this.MEDICO.Name = "MEDICO";
            this.MEDICO.ReadOnly = true;
            this.MEDICO.Width = 200;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DATA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATA.HeaderText = "Data";
            this.DATA.MinimumWidth = 6;
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 82;
            // 
            // HORARIO
            // 
            this.HORARIO.DataPropertyName = "HORARIO";
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.HORARIO.DefaultCellStyle = dataGridViewCellStyle4;
            this.HORARIO.HeaderText = "Horário";
            this.HORARIO.MinimumWidth = 6;
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            this.HORARIO.Width = 76;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(579, 663);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.RadioButton rbMedico;
        private System.Windows.Forms.RadioButton rbPaciente;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
    }
}

