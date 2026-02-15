namespace Pizzaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.chkEspera = new System.Windows.Forms.CheckBox();
            this.chkEntregue = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPizzas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnpedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dtgPedido = new System.Windows.Forms.DataGridView();
            this.SITUACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_SABOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_SABOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_TAMANHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENTREGUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidoTableAdapter1 = new Pizzaria.PizzariaDataSetTableAdapters.PedidoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.chkEspera);
            this.groupBox1.Controls.Add(this.chkEntregue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::Pizzaria.Properties.Resources.pequena_lupa;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(307, 101);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(111, 37);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(448, 62);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(316, 27);
            this.txtNomeCliente.TabIndex = 2;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // chkEspera
            // 
            this.chkEspera.AutoSize = true;
            this.chkEspera.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspera.Location = new System.Drawing.Point(193, 65);
            this.chkEspera.Name = "chkEspera";
            this.chkEspera.Size = new System.Drawing.Size(90, 21);
            this.chkEspera.TabIndex = 1;
            this.chkEspera.Text = "À Espera";
            this.chkEspera.UseVisualStyleBackColor = true;
            this.chkEspera.CheckedChanged += new System.EventHandler(this.chkEspera_CheckedChanged);
            // 
            // chkEntregue
            // 
            this.chkEntregue.AutoSize = true;
            this.chkEntregue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEntregue.Location = new System.Drawing.Point(193, 34);
            this.chkEntregue.Name = "chkEntregue";
            this.chkEntregue.Size = new System.Drawing.Size(89, 21);
            this.chkEntregue.TabIndex = 1;
            this.chkEntregue.Text = "Entregue";
            this.chkEntregue.UseVisualStyleBackColor = true;
            this.chkEntregue.CheckedChanged += new System.EventHandler(this.chkEntregue_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busque o pedido pelo nome do cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Situação do pedido:";
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Pizzaria.Properties.Resources.cliente;
            this.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(65, 56);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // btnPizzas
            // 
            this.btnPizzas.Image = global::Pizzaria.Properties.Resources.pizza;
            this.btnPizzas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPizzas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPizzas.Name = "btnPizzas";
            this.btnPizzas.Size = new System.Drawing.Size(53, 56);
            this.btnPizzas.Text = "Pizzas";
            this.btnPizzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPizzas.Click += new System.EventHandler(this.btnPizzas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // btnpedidos
            // 
            this.btnpedidos.Image = global::Pizzaria.Properties.Resources.pedido;
            this.btnpedidos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnpedidos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnpedidos.Name = "btnpedidos";
            this.btnpedidos.Size = new System.Drawing.Size(65, 56);
            this.btnpedidos.Text = "Pedidos";
            this.btnpedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnpedidos.Click += new System.EventHandler(this.btnpedidos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.toolStripSeparator1,
            this.btnPizzas,
            this.toolStripSeparator2,
            this.btnpedidos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dtgPedido
            // 
            this.dtgPedido.AllowUserToAddRows = false;
            this.dtgPedido.AllowUserToDeleteRows = false;
            this.dtgPedido.AllowUserToResizeColumns = false;
            this.dtgPedido.AllowUserToResizeRows = false;
            this.dtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SITUACAO,
            this.ID_PEDIDO,
            this.ID_CLIENTE,
            this.ID_TAMANHO,
            this.ID_SABOR,
            this.NOME_CLIENTE,
            this.NOME_SABOR,
            this.NOME_TAMANHO,
            this.ENTREGUE,
            this.TOTAL});
            this.dtgPedido.Location = new System.Drawing.Point(12, 222);
            this.dtgPedido.Name = "dtgPedido";
            this.dtgPedido.ReadOnly = true;
            this.dtgPedido.RowHeadersVisible = false;
            this.dtgPedido.RowHeadersWidth = 51;
            this.dtgPedido.RowTemplate.Height = 24;
            this.dtgPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPedido.Size = new System.Drawing.Size(786, 331);
            this.dtgPedido.TabIndex = 2;
            // 
            // SITUACAO
            // 
            this.SITUACAO.HeaderText = "SITUAÇÃO";
            this.SITUACAO.MinimumWidth = 6;
            this.SITUACAO.Name = "SITUACAO";
            this.SITUACAO.ReadOnly = true;
            this.SITUACAO.Width = 125;
            // 
            // ID_PEDIDO
            // 
            this.ID_PEDIDO.DataPropertyName = "ID_PEDIDO";
            this.ID_PEDIDO.HeaderText = "CÓDIGO";
            this.ID_PEDIDO.MinimumWidth = 6;
            this.ID_PEDIDO.Name = "ID_PEDIDO";
            this.ID_PEDIDO.ReadOnly = true;
            this.ID_PEDIDO.Width = 69;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "Cod_nome";
            this.ID_CLIENTE.MinimumWidth = 6;
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            this.ID_CLIENTE.Width = 125;
            // 
            // ID_TAMANHO
            // 
            this.ID_TAMANHO.DataPropertyName = "ID_TAMANHO";
            this.ID_TAMANHO.HeaderText = "Cod_tamanho";
            this.ID_TAMANHO.MinimumWidth = 6;
            this.ID_TAMANHO.Name = "ID_TAMANHO";
            this.ID_TAMANHO.ReadOnly = true;
            this.ID_TAMANHO.Visible = false;
            this.ID_TAMANHO.Width = 125;
            // 
            // ID_SABOR
            // 
            this.ID_SABOR.DataPropertyName = "ID_SABOR";
            this.ID_SABOR.HeaderText = "Cod_sabor";
            this.ID_SABOR.MinimumWidth = 6;
            this.ID_SABOR.Name = "ID_SABOR";
            this.ID_SABOR.ReadOnly = true;
            this.ID_SABOR.Visible = false;
            this.ID_SABOR.Width = 125;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "CLIENTE";
            this.NOME_CLIENTE.MinimumWidth = 6;
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            this.NOME_CLIENTE.Width = 230;
            // 
            // NOME_SABOR
            // 
            this.NOME_SABOR.DataPropertyName = "NOME_SABOR";
            this.NOME_SABOR.HeaderText = "SABOR";
            this.NOME_SABOR.MinimumWidth = 6;
            this.NOME_SABOR.Name = "NOME_SABOR";
            this.NOME_SABOR.ReadOnly = true;
            this.NOME_SABOR.Width = 200;
            // 
            // NOME_TAMANHO
            // 
            this.NOME_TAMANHO.DataPropertyName = "NOME_TAMANHO";
            this.NOME_TAMANHO.HeaderText = "TAMANHO";
            this.NOME_TAMANHO.MinimumWidth = 6;
            this.NOME_TAMANHO.Name = "NOME_TAMANHO";
            this.NOME_TAMANHO.ReadOnly = true;
            this.NOME_TAMANHO.Width = 125;
            // 
            // ENTREGUE
            // 
            this.ENTREGUE.DataPropertyName = "ENTREGUE";
            this.ENTREGUE.HeaderText = "ENTREGUE";
            this.ENTREGUE.MinimumWidth = 6;
            this.ENTREGUE.Name = "ENTREGUE";
            this.ENTREGUE.ReadOnly = true;
            this.ENTREGUE.Visible = false;
            this.ENTREGUE.Width = 125;
            // 
            // TOTAL
            // 
            this.TOTAL.DataPropertyName = "TOTAL";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 59;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 565);
            this.Controls.Add(this.dtgPedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de Pizzaria";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.CheckBox chkEspera;
        private System.Windows.Forms.CheckBox chkEntregue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPizzas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnpedidos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgPedido;
        private PizzariaDataSetTableAdapters.PedidoTableAdapter pedidoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SITUACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SABOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_SABOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_TAMANHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENTREGUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}

