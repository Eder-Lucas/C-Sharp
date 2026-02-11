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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPizzas = new System.Windows.Forms.ToolStripButton();
            this.btnpedidos = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.toolStripSeparator1,
            this.btnPizzas,
            this.btnpedidos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 59);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controle de Pizzaria";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnpedidos;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnPizzas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

