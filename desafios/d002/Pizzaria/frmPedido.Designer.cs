namespace Pizzaria
{
    partial class frmPedido
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
            System.Windows.Forms.Label iD_PEDIDOLabel;
            System.Windows.Forms.Label iD_CLIENTELabel;
            System.Windows.Forms.Label iD_TAMANHOLabel;
            System.Windows.Forms.Label iD_SABORLabel;
            System.Windows.Forms.Label tOTALLabel;
            System.Windows.Forms.Label eNTREGUELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tOTALTextBox = new System.Windows.Forms.TextBox();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzariaDataSet = new Pizzaria.PizzariaDataSet();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.tamanhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboSabor = new System.Windows.Forms.ComboBox();
            this.saborBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PEDIDOTextBox = new System.Windows.Forms.TextBox();
            this.chkEntregue = new System.Windows.Forms.CheckBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.pedidoTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.PedidoTableAdapter();
            this.tableAdapterManager = new Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.ClienteTableAdapter();
            this.saborTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.SaborTableAdapter();
            this.tamanhoTableAdapter = new Pizzaria.PizzariaDataSetTableAdapters.TamanhoTableAdapter();
            iD_PEDIDOLabel = new System.Windows.Forms.Label();
            iD_CLIENTELabel = new System.Windows.Forms.Label();
            iD_TAMANHOLabel = new System.Windows.Forms.Label();
            iD_SABORLabel = new System.Windows.Forms.Label();
            tOTALLabel = new System.Windows.Forms.Label();
            eNTREGUELabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saborBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_PEDIDOLabel
            // 
            iD_PEDIDOLabel.AutoSize = true;
            iD_PEDIDOLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PEDIDOLabel.Location = new System.Drawing.Point(32, 43);
            iD_PEDIDOLabel.Name = "iD_PEDIDOLabel";
            iD_PEDIDOLabel.Size = new System.Drawing.Size(79, 21);
            iD_PEDIDOLabel.TabIndex = 0;
            iD_PEDIDOLabel.Text = "Código:";
            // 
            // iD_CLIENTELabel
            // 
            iD_CLIENTELabel.AutoSize = true;
            iD_CLIENTELabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CLIENTELabel.Location = new System.Drawing.Point(32, 81);
            iD_CLIENTELabel.Name = "iD_CLIENTELabel";
            iD_CLIENTELabel.Size = new System.Drawing.Size(79, 21);
            iD_CLIENTELabel.TabIndex = 2;
            iD_CLIENTELabel.Text = "Cliente:";
            // 
            // iD_TAMANHOLabel
            // 
            iD_TAMANHOLabel.AutoSize = true;
            iD_TAMANHOLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_TAMANHOLabel.Location = new System.Drawing.Point(14, 119);
            iD_TAMANHOLabel.Name = "iD_TAMANHOLabel";
            iD_TAMANHOLabel.Size = new System.Drawing.Size(97, 21);
            iD_TAMANHOLabel.TabIndex = 4;
            iD_TAMANHOLabel.Text = "Tamanho:";
            // 
            // iD_SABORLabel
            // 
            iD_SABORLabel.AutoSize = true;
            iD_SABORLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_SABORLabel.Location = new System.Drawing.Point(43, 157);
            iD_SABORLabel.Name = "iD_SABORLabel";
            iD_SABORLabel.Size = new System.Drawing.Size(68, 21);
            iD_SABORLabel.TabIndex = 6;
            iD_SABORLabel.Text = "Sabor:";
            // 
            // tOTALLabel
            // 
            tOTALLabel.AutoSize = true;
            tOTALLabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tOTALLabel.Location = new System.Drawing.Point(52, 195);
            tOTALLabel.Name = "tOTALLabel";
            tOTALLabel.Size = new System.Drawing.Size(59, 21);
            tOTALLabel.TabIndex = 8;
            tOTALLabel.Text = "Total:";
            // 
            // eNTREGUELabel
            // 
            eNTREGUELabel.AutoSize = true;
            eNTREGUELabel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eNTREGUELabel.Location = new System.Drawing.Point(19, 233);
            eNTREGUELabel.Name = "eNTREGUELabel";
            eNTREGUELabel.Size = new System.Drawing.Size(92, 21);
            eNTREGUELabel.TabIndex = 10;
            eNTREGUELabel.Text = "Situação:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Pedidos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboTamanho);
            this.panel2.Controls.Add(this.cboSabor);
            this.panel2.Controls.Add(this.cboCliente);
            this.panel2.Controls.Add(this.pedidoBindingNavigator);
            this.panel2.Controls.Add(iD_PEDIDOLabel);
            this.panel2.Controls.Add(this.iD_PEDIDOTextBox);
            this.panel2.Controls.Add(iD_CLIENTELabel);
            this.panel2.Controls.Add(iD_TAMANHOLabel);
            this.panel2.Controls.Add(iD_SABORLabel);
            this.panel2.Controls.Add(tOTALLabel);
            this.panel2.Controls.Add(eNTREGUELabel);
            this.panel2.Controls.Add(this.chkEntregue);
            this.panel2.Controls.Add(this.vALORTextBox);
            this.panel2.Controls.Add(this.tOTALTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 320);
            this.panel2.TabIndex = 1;
            // 
            // tOTALTextBox
            // 
            this.tOTALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "TOTAL", true));
            this.tOTALTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOTALTextBox.Location = new System.Drawing.Point(117, 192);
            this.tOTALTextBox.Name = "tOTALTextBox";
            this.tOTALTextBox.Size = new System.Drawing.Size(104, 27);
            this.tOTALTextBox.TabIndex = 9;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "Pedido";
            this.pedidoBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // pizzariaDataSet
            // 
            this.pizzariaDataSet.DataSetName = "PizzariaDataSet";
            this.pizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTamanho
            // 
            this.cboTamanho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoBindingSource, "ID_TAMANHO", true));
            this.cboTamanho.DataSource = this.tamanhoBindingSource;
            this.cboTamanho.DisplayMember = "NOME_TAMANHO";
            this.cboTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamanho.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Location = new System.Drawing.Point(117, 116);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(228, 27);
            this.cboTamanho.TabIndex = 12;
            this.cboTamanho.ValueMember = "ID_TAMANHO";
            // 
            // tamanhoBindingSource
            // 
            this.tamanhoBindingSource.DataMember = "Tamanho";
            this.tamanhoBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // cboSabor
            // 
            this.cboSabor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoBindingSource, "ID_SABOR", true));
            this.cboSabor.DataSource = this.saborBindingSource;
            this.cboSabor.DisplayMember = "NOME_SABOR";
            this.cboSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSabor.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSabor.FormattingEnabled = true;
            this.cboSabor.Location = new System.Drawing.Point(117, 154);
            this.cboSabor.Name = "cboSabor";
            this.cboSabor.Size = new System.Drawing.Size(228, 27);
            this.cboSabor.TabIndex = 12;
            this.cboSabor.ValueMember = "ID_SABOR";
            // 
            // saborBindingSource
            // 
            this.saborBindingSource.DataMember = "Sabor";
            this.saborBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // cboCliente
            // 
            this.cboCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pedidoBindingSource, "ID_CLIENTE", true));
            this.cboCliente.DataSource = this.clienteBindingSource;
            this.cboCliente.DisplayMember = "NOME_CLIENTE";
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(117, 78);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(330, 27);
            this.cboCliente.TabIndex = 12;
            this.cboCliente.ValueMember = "ID_CLIENTE";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.pizzariaDataSet;
            // 
            // pedidoBindingNavigator
            // 
            this.pedidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pedidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pedidoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pedidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pedidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pedidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(466, 31);
            this.pedidoBindingNavigator.TabIndex = 2;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.pedidoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click);
            // 
            // iD_PEDIDOTextBox
            // 
            this.iD_PEDIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "ID_PEDIDO", true));
            this.iD_PEDIDOTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PEDIDOTextBox.Location = new System.Drawing.Point(117, 40);
            this.iD_PEDIDOTextBox.Name = "iD_PEDIDOTextBox";
            this.iD_PEDIDOTextBox.ReadOnly = true;
            this.iD_PEDIDOTextBox.Size = new System.Drawing.Size(104, 27);
            this.iD_PEDIDOTextBox.TabIndex = 1;
            // 
            // chkEntregue
            // 
            this.chkEntregue.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pedidoBindingSource, "ENTREGUE", true));
            this.chkEntregue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntregue.Location = new System.Drawing.Point(117, 231);
            this.chkEntregue.Name = "chkEntregue";
            this.chkEntregue.Size = new System.Drawing.Size(104, 24);
            this.chkEntregue.TabIndex = 11;
            this.chkEntregue.Text = "Entregue";
            this.chkEntregue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkEntregue.UseVisualStyleBackColor = true;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tamanhoBindingSource, "VALOR", true));
            this.vALORTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vALORTextBox.Location = new System.Drawing.Point(117, 192);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.ReadOnly = true;
            this.vALORTextBox.Size = new System.Drawing.Size(104, 27);
            this.vALORTextBox.TabIndex = 14;
            this.vALORTextBox.TextChanged += new System.EventHandler(this.vALORTextBox_TextChanged);
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.PedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager.SaborTableAdapter = this.saborTableAdapter;
            this.tableAdapterManager.TamanhoTableAdapter = this.tamanhoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pizzaria.PizzariaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // saborTableAdapter
            // 
            this.saborTableAdapter.ClearBeforeFill = true;
            // 
            // tamanhoTableAdapter
            // 
            this.tamanhoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Pedidos";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamanhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saborBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).EndInit();
            this.pedidoBindingNavigator.ResumeLayout(false);
            this.pedidoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private PizzariaDataSet pizzariaDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private PizzariaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter;
        private PizzariaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PEDIDOTextBox;
        private System.Windows.Forms.TextBox tOTALTextBox;
        private System.Windows.Forms.CheckBox chkEntregue;
        private System.Windows.Forms.ComboBox cboTamanho;
        private System.Windows.Forms.ComboBox cboSabor;
        private System.Windows.Forms.ComboBox cboCliente;
        private PizzariaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private PizzariaDataSetTableAdapters.TamanhoTableAdapter tamanhoTableAdapter;
        private System.Windows.Forms.BindingSource tamanhoBindingSource;
        private PizzariaDataSetTableAdapters.SaborTableAdapter saborTableAdapter;
        private System.Windows.Forms.BindingSource saborBindingSource;
        private System.Windows.Forms.TextBox vALORTextBox;
    }
}