namespace ControleConsultorio
{
    partial class frmPacientes
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
            System.Windows.Forms.Label iD_PACIENTELabel;
            System.Windows.Forms.Label nOME_PACIENTELabel;
            System.Windows.Forms.Label rUALabel;
            System.Windows.Forms.Label nUMEROLabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label sEXOLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.consultasDataSet = new ControleConsultorio.ConsultasDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new ControleConsultorio.ConsultasDataSetTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new ControleConsultorio.ConsultasDataSetTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.nOME_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.rUATextBox = new System.Windows.Forms.TextBox();
            this.nUMEROTextBox = new System.Windows.Forms.TextBox();
            this.bAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cIDADETextBox = new System.Windows.Forms.TextBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sEXOComboBox = new System.Windows.Forms.ComboBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PACIENTELabel = new System.Windows.Forms.Label();
            nOME_PACIENTELabel = new System.Windows.Forms.Label();
            rUALabel = new System.Windows.Forms.Label();
            nUMEROLabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            sEXOLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PACIENTELabel
            // 
            iD_PACIENTELabel.AutoSize = true;
            iD_PACIENTELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PACIENTELabel.Location = new System.Drawing.Point(28, 49);
            iD_PACIENTELabel.Name = "iD_PACIENTELabel";
            iD_PACIENTELabel.Size = new System.Drawing.Size(84, 24);
            iD_PACIENTELabel.TabIndex = 1;
            iD_PACIENTELabel.Text = "Código:";
            // 
            // nOME_PACIENTELabel
            // 
            nOME_PACIENTELabel.AutoSize = true;
            nOME_PACIENTELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_PACIENTELabel.Location = new System.Drawing.Point(41, 86);
            nOME_PACIENTELabel.Name = "nOME_PACIENTELabel";
            nOME_PACIENTELabel.Size = new System.Drawing.Size(71, 24);
            nOME_PACIENTELabel.TabIndex = 3;
            nOME_PACIENTELabel.Text = "Nome:";
            // 
            // rUALabel
            // 
            rUALabel.AutoSize = true;
            rUALabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rUALabel.Location = new System.Drawing.Point(58, 123);
            rUALabel.Name = "rUALabel";
            rUALabel.Size = new System.Drawing.Size(54, 24);
            rUALabel.TabIndex = 5;
            rUALabel.Text = "Rua:";
            // 
            // nUMEROLabel
            // 
            nUMEROLabel.AutoSize = true;
            nUMEROLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nUMEROLabel.Location = new System.Drawing.Point(21, 159);
            nUMEROLabel.Name = "nUMEROLabel";
            nUMEROLabel.Size = new System.Drawing.Size(91, 24);
            nUMEROLabel.TabIndex = 7;
            nUMEROLabel.Text = "Número:";
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bAIRROLabel.Location = new System.Drawing.Point(299, 161);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(75, 24);
            bAIRROLabel.TabIndex = 9;
            bAIRROLabel.Text = "Bairro:";
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cIDADELabel.Location = new System.Drawing.Point(28, 199);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(82, 24);
            cIDADELabel.TabIndex = 11;
            cIDADELabel.Text = "Cidade:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cEPLabel.Location = new System.Drawing.Point(265, 236);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(57, 24);
            cEPLabel.TabIndex = 13;
            cEPLabel.Text = "CEP:";
            // 
            // sEXOLabel
            // 
            sEXOLabel.AutoSize = true;
            sEXOLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sEXOLabel.Location = new System.Drawing.Point(46, 236);
            sEXOLabel.Name = "sEXOLabel";
            sEXOLabel.Size = new System.Drawing.Size(64, 24);
            sEXOLabel.TabIndex = 15;
            sEXOLabel.Text = "Sexo:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(446, 199);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(98, 24);
            tELEFONELabel.TabIndex = 17;
            tELEFONELabel.Text = "Telefone:";
            // 
            // consultasDataSet
            // 
            this.consultasDataSet.DataSetName = "ConsultasDataSet";
            this.consultasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultasDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ControleConsultorio.ConsultasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = null;
            this.pacienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacienteBindingNavigatorSaveItem});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(700, 27);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pacienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteBindingNavigatorSaveItem_Click);
            // 
            // iD_PACIENTETextBox
            // 
            this.iD_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ID_PACIENTE", true));
            this.iD_PACIENTETextBox.Enabled = false;
            this.iD_PACIENTETextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PACIENTETextBox.Location = new System.Drawing.Point(118, 48);
            this.iD_PACIENTETextBox.Name = "iD_PACIENTETextBox";
            this.iD_PACIENTETextBox.ReadOnly = true;
            this.iD_PACIENTETextBox.Size = new System.Drawing.Size(95, 27);
            this.iD_PACIENTETextBox.TabIndex = 2;
            // 
            // nOME_PACIENTETextBox
            // 
            this.nOME_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NOME_PACIENTE", true));
            this.nOME_PACIENTETextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_PACIENTETextBox.Location = new System.Drawing.Point(118, 85);
            this.nOME_PACIENTETextBox.Name = "nOME_PACIENTETextBox";
            this.nOME_PACIENTETextBox.Size = new System.Drawing.Size(562, 27);
            this.nOME_PACIENTETextBox.TabIndex = 4;
            // 
            // rUATextBox
            // 
            this.rUATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "RUA", true));
            this.rUATextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rUATextBox.Location = new System.Drawing.Point(118, 122);
            this.rUATextBox.Name = "rUATextBox";
            this.rUATextBox.Size = new System.Drawing.Size(562, 27);
            this.rUATextBox.TabIndex = 6;
            // 
            // nUMEROTextBox
            // 
            this.nUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NUMERO", true));
            this.nUMEROTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUMEROTextBox.Location = new System.Drawing.Point(118, 158);
            this.nUMEROTextBox.Name = "nUMEROTextBox";
            this.nUMEROTextBox.Size = new System.Drawing.Size(146, 27);
            this.nUMEROTextBox.TabIndex = 8;
            // 
            // bAIRROTextBox
            // 
            this.bAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "BAIRRO", true));
            this.bAIRROTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAIRROTextBox.Location = new System.Drawing.Point(380, 161);
            this.bAIRROTextBox.Name = "bAIRROTextBox";
            this.bAIRROTextBox.Size = new System.Drawing.Size(300, 27);
            this.bAIRROTextBox.TabIndex = 10;
            // 
            // cIDADETextBox
            // 
            this.cIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CIDADE", true));
            this.cIDADETextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDADETextBox.Location = new System.Drawing.Point(118, 198);
            this.cIDADETextBox.Name = "cIDADETextBox";
            this.cIDADETextBox.Size = new System.Drawing.Size(295, 27);
            this.cIDADETextBox.TabIndex = 12;
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(328, 235);
            this.cEPMaskedTextBox.Mask = "00000-000";
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(85, 27);
            this.cEPMaskedTextBox.TabIndex = 14;
            // 
            // sEXOComboBox
            // 
            this.sEXOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "SEXO", true));
            this.sEXOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sEXOComboBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEXOComboBox.FormattingEnabled = true;
            this.sEXOComboBox.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino",
            "Intersexo"});
            this.sEXOComboBox.Location = new System.Drawing.Point(118, 235);
            this.sEXOComboBox.Name = "sEXOComboBox";
            this.sEXOComboBox.Size = new System.Drawing.Size(118, 27);
            this.sEXOComboBox.TabIndex = 16;
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(550, 198);
            this.tELEFONEMaskedTextBox.Mask = "(00) 00000-0000";
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(130, 27);
            this.tELEFONEMaskedTextBox.TabIndex = 18;
            // 
            // pacienteDataGridView
            // 
            this.pacienteDataGridView.AllowUserToAddRows = false;
            this.pacienteDataGridView.AllowUserToDeleteRows = false;
            this.pacienteDataGridView.AllowUserToResizeColumns = false;
            this.pacienteDataGridView.AllowUserToResizeRows = false;
            this.pacienteDataGridView.AutoGenerateColumns = false;
            this.pacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pacienteDataGridView.DataSource = this.pacienteBindingSource;
            this.pacienteDataGridView.Location = new System.Drawing.Point(12, 285);
            this.pacienteDataGridView.Name = "pacienteDataGridView";
            this.pacienteDataGridView.ReadOnly = true;
            this.pacienteDataGridView.RowHeadersVisible = false;
            this.pacienteDataGridView.RowHeadersWidth = 51;
            this.pacienteDataGridView.RowTemplate.Height = 24;
            this.pacienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacienteDataGridView.Size = new System.Drawing.Size(676, 282);
            this.pacienteDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PACIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "CÓDIGO";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PACIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 403;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RUA";
            this.dataGridViewTextBoxColumn3.HeaderText = "RUA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NUMERO";
            this.dataGridViewTextBoxColumn4.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BAIRRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn6.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SEXO";
            this.dataGridViewTextBoxColumn8.HeaderText = "SEXO";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn9.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 579);
            this.Controls.Add(this.pacienteDataGridView);
            this.Controls.Add(iD_PACIENTELabel);
            this.Controls.Add(this.iD_PACIENTETextBox);
            this.Controls.Add(nOME_PACIENTELabel);
            this.Controls.Add(this.nOME_PACIENTETextBox);
            this.Controls.Add(rUALabel);
            this.Controls.Add(this.rUATextBox);
            this.Controls.Add(nUMEROLabel);
            this.Controls.Add(this.nUMEROTextBox);
            this.Controls.Add(bAIRROLabel);
            this.Controls.Add(this.bAIRROTextBox);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.cIDADETextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(sEXOLabel);
            this.Controls.Add(this.sEXOComboBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONEMaskedTextBox);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultasDataSet consultasDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ConsultasDataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private ConsultasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PACIENTETextBox;
        private System.Windows.Forms.TextBox nOME_PACIENTETextBox;
        private System.Windows.Forms.TextBox rUATextBox;
        private System.Windows.Forms.TextBox nUMEROTextBox;
        private System.Windows.Forms.TextBox bAIRROTextBox;
        private System.Windows.Forms.TextBox cIDADETextBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.ComboBox sEXOComboBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.DataGridView pacienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}