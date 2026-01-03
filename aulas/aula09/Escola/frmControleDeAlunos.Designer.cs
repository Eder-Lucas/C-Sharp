namespace Escola
{
    partial class frmControleDeAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeAlunos));
            System.Windows.Forms.Label iD_ALUNOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label cURSOLabel;
            System.Windows.Forms.Label nASCIMENTOLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.escolaDataSet = new Escola.EscolaDataSet();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new Escola.EscolaDataSetTableAdapters.AlunosTableAdapter();
            this.tableAdapterManager = new Escola.EscolaDataSetTableAdapters.TableAdapterManager();
            this.alunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.alunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ALUNOTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.cURSOTextBox = new System.Windows.Forms.TextBox();
            this.nASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_ALUNOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            cURSOLabel = new System.Windows.Forms.Label();
            nASCIMENTOLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).BeginInit();
            this.alunosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.alunosBindingNavigator);
            this.tabPage1.Controls.Add(iD_ALUNOLabel);
            this.tabPage1.Controls.Add(this.iD_ALUNOTextBox);
            this.tabPage1.Controls.Add(nOMELabel);
            this.tabPage1.Controls.Add(this.nOMETextBox);
            this.tabPage1.Controls.Add(tELEFONELabel);
            this.tabPage1.Controls.Add(this.tELEFONEMaskedTextBox);
            this.tabPage1.Controls.Add(eMAILLabel);
            this.tabPage1.Controls.Add(this.eMAILTextBox);
            this.tabPage1.Controls.Add(cURSOLabel);
            this.tabPage1.Controls.Add(this.cURSOTextBox);
            this.tabPage1.Controls.Add(nASCIMENTOLabel);
            this.tabPage1.Controls.Add(this.nASCIMENTODateTimePicker);
            this.tabPage1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // escolaDataSet
            // 
            this.escolaDataSet.DataSetName = "EscolaDataSet";
            this.escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.escolaDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Escola.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // alunosBindingNavigator
            // 
            this.alunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunosBindingNavigator.BindingSource = this.alunosBindingSource;
            this.alunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.alunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.alunosBindingNavigatorSaveItem});
            this.alunosBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.alunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunosBindingNavigator.Name = "alunosBindingNavigator";
            this.alunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunosBindingNavigator.Size = new System.Drawing.Size(786, 27);
            this.alunosBindingNavigator.TabIndex = 1;
            this.alunosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // alunosBindingNavigatorSaveItem
            // 
            this.alunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosBindingNavigatorSaveItem.Image")));
            this.alunosBindingNavigatorSaveItem.Name = "alunosBindingNavigatorSaveItem";
            this.alunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.alunosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunosBindingNavigatorSaveItem_Click);
            // 
            // iD_ALUNOLabel
            // 
            iD_ALUNOLabel.AutoSize = true;
            iD_ALUNOLabel.Location = new System.Drawing.Point(37, 87);
            iD_ALUNOLabel.Name = "iD_ALUNOLabel";
            iD_ALUNOLabel.Size = new System.Drawing.Size(72, 21);
            iD_ALUNOLabel.TabIndex = 0;
            iD_ALUNOLabel.Text = "Código:";
            // 
            // iD_ALUNOTextBox
            // 
            this.iD_ALUNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "ID_ALUNO", true));
            this.iD_ALUNOTextBox.Enabled = false;
            this.iD_ALUNOTextBox.Location = new System.Drawing.Point(177, 84);
            this.iD_ALUNOTextBox.Name = "iD_ALUNOTextBox";
            this.iD_ALUNOTextBox.Size = new System.Drawing.Size(200, 28);
            this.iD_ALUNOTextBox.TabIndex = 1;
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(37, 121);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(62, 21);
            nOMELabel.TabIndex = 2;
            nOMELabel.Text = "Nome:";
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(177, 118);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(200, 28);
            this.nOMETextBox.TabIndex = 3;
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(37, 155);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(84, 21);
            tELEFONELabel.TabIndex = 4;
            tELEFONELabel.Text = "Telefone:";
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(177, 152);
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(200, 28);
            this.tELEFONEMaskedTextBox.TabIndex = 5;
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(37, 189);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(59, 21);
            eMAILLabel.TabIndex = 6;
            eMAILLabel.Text = "Email:";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(177, 186);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(200, 28);
            this.eMAILTextBox.TabIndex = 7;
            // 
            // cURSOLabel
            // 
            cURSOLabel.AutoSize = true;
            cURSOLabel.Location = new System.Drawing.Point(37, 223);
            cURSOLabel.Name = "cURSOLabel";
            cURSOLabel.Size = new System.Drawing.Size(63, 21);
            cURSOLabel.TabIndex = 8;
            cURSOLabel.Text = "Curso:";
            // 
            // cURSOTextBox
            // 
            this.cURSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "CURSO", true));
            this.cURSOTextBox.Location = new System.Drawing.Point(177, 220);
            this.cURSOTextBox.Name = "cURSOTextBox";
            this.cURSOTextBox.Size = new System.Drawing.Size(200, 28);
            this.cURSOTextBox.TabIndex = 9;
            // 
            // nASCIMENTOLabel
            // 
            nASCIMENTOLabel.AutoSize = true;
            nASCIMENTOLabel.Location = new System.Drawing.Point(37, 258);
            nASCIMENTOLabel.Name = "nASCIMENTOLabel";
            nASCIMENTOLabel.Size = new System.Drawing.Size(109, 21);
            nASCIMENTOLabel.TabIndex = 10;
            nASCIMENTOLabel.Text = "Nascimento:";
            // 
            // nASCIMENTODateTimePicker
            // 
            this.nASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosBindingSource, "NASCIMENTO", true));
            this.nASCIMENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nASCIMENTODateTimePicker.Location = new System.Drawing.Point(177, 254);
            this.nASCIMENTODateTimePicker.Name = "nASCIMENTODateTimePicker";
            this.nASCIMENTODateTimePicker.Size = new System.Drawing.Size(138, 28);
            this.nASCIMENTODateTimePicker.TabIndex = 11;
            // 
            // frmControleDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmControleDeAlunos";
            this.Text = "Controle de Alunos";
            this.Load += new System.EventHandler(this.frmControleDeAlunos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).EndInit();
            this.alunosBindingNavigator.ResumeLayout(false);
            this.alunosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private EscolaDataSet escolaDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private EscolaDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private EscolaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton alunosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ALUNOTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox cURSOTextBox;
        private System.Windows.Forms.DateTimePicker nASCIMENTODateTimePicker;
    }
}

