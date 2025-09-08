namespace ControleFrota
{
    partial class ControleDeFrota
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCarros = new Button();
            btnCaminhao = new Button();
            btnSalvar = new Button();
            panel1 = new Panel();
            pbCar = new PictureBox();
            pbTruck = new PictureBox();
            txtPlaca = new TextBox();
            txtEixo = new TextBox();
            txtCaminhao = new TextBox();
            txtCarros = new TextBox();
            txtKm = new TextBox();
            txtModelo = new TextBox();
            lblEixo = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTruck).BeginInit();
            SuspendLayout();
            // 
            // btnCarros
            // 
            btnCarros.BackColor = Color.White;
            btnCarros.FlatAppearance.BorderColor = Color.Black;
            btnCarros.FlatAppearance.BorderSize = 2;
            btnCarros.FlatStyle = FlatStyle.Flat;
            btnCarros.Font = new Font("Arial", 10.8F);
            btnCarros.Image = Properties.Resources.carroIcon;
            btnCarros.ImageAlign = ContentAlignment.MiddleLeft;
            btnCarros.Location = new Point(446, 12);
            btnCarros.Name = "btnCarros";
            btnCarros.Size = new Size(105, 46);
            btnCarros.TabIndex = 0;
            btnCarros.Text = "Carros";
            btnCarros.TextAlign = ContentAlignment.MiddleRight;
            btnCarros.UseVisualStyleBackColor = false;
            // 
            // btnCaminhao
            // 
            btnCaminhao.BackColor = Color.White;
            btnCaminhao.FlatAppearance.BorderColor = Color.Black;
            btnCaminhao.FlatAppearance.BorderSize = 2;
            btnCaminhao.FlatStyle = FlatStyle.Flat;
            btnCaminhao.Font = new Font("Arial", 10.8F);
            btnCaminhao.Image = Properties.Resources.truckIcon;
            btnCaminhao.ImageAlign = ContentAlignment.MiddleLeft;
            btnCaminhao.Location = new Point(569, 12);
            btnCaminhao.Name = "btnCaminhao";
            btnCaminhao.Size = new Size(141, 46);
            btnCaminhao.TabIndex = 0;
            btnCaminhao.Text = "Caminhôes";
            btnCaminhao.TextAlign = ContentAlignment.MiddleRight;
            btnCaminhao.UseVisualStyleBackColor = false;
            btnCaminhao.Click += btnCaminhao_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.White;
            btnSalvar.FlatAppearance.BorderColor = Color.Black;
            btnSalvar.FlatAppearance.BorderSize = 2;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Arial", 10.8F);
            btnSalvar.Image = Properties.Resources.saveIcon;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(728, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(101, 46);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbCar);
            panel1.Controls.Add(pbTruck);
            panel1.Controls.Add(txtPlaca);
            panel1.Controls.Add(txtEixo);
            panel1.Controls.Add(txtCaminhao);
            panel1.Controls.Add(txtCarros);
            panel1.Controls.Add(txtKm);
            panel1.Controls.Add(txtModelo);
            panel1.Controls.Add(lblEixo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 702);
            panel1.TabIndex = 0;
            // 
            // pbCar
            // 
            pbCar.Image = Properties.Resources._3d_car;
            pbCar.Location = new Point(15, 157);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(130, 117);
            pbCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCar.TabIndex = 2;
            pbCar.TabStop = false;
            // 
            // pbTruck
            // 
            pbTruck.Image = Properties.Resources._3d_truck;
            pbTruck.Location = new Point(602, 157);
            pbTruck.Name = "pbTruck";
            pbTruck.Size = new Size(131, 117);
            pbTruck.SizeMode = PictureBoxSizeMode.Zoom;
            pbTruck.TabIndex = 2;
            pbTruck.TabStop = false;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(151, 60);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(582, 27);
            txtPlaca.TabIndex = 1;
            // 
            // txtEixo
            // 
            txtEixo.Location = new Point(386, 102);
            txtEixo.Name = "txtEixo";
            txtEixo.Size = new Size(178, 27);
            txtEixo.TabIndex = 3;
            txtEixo.Visible = false;
            // 
            // txtCaminhao
            // 
            txtCaminhao.Location = new Point(602, 275);
            txtCaminhao.Multiline = true;
            txtCaminhao.Name = "txtCaminhao";
            txtCaminhao.Size = new Size(549, 406);
            txtCaminhao.TabIndex = 5;
            // 
            // txtCarros
            // 
            txtCarros.Location = new Point(15, 275);
            txtCarros.Multiline = true;
            txtCarros.Name = "txtCarros";
            txtCarros.Size = new Size(549, 406);
            txtCarros.TabIndex = 4;
            // 
            // txtKm
            // 
            txtKm.Location = new Point(151, 102);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(149, 27);
            txtKm.TabIndex = 2;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(151, 15);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(582, 27);
            txtModelo.TabIndex = 0;
            // 
            // lblEixo
            // 
            lblEixo.AutoSize = true;
            lblEixo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEixo.Location = new Point(311, 105);
            lblEixo.Name = "lblEixo";
            lblEixo.Size = new Size(69, 24);
            lblEixo.TabIndex = 0;
            lblEixo.Text = "Eixos:";
            lblEixo.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 105);
            label3.Name = "label3";
            label3.Size = new Size(48, 24);
            label3.TabIndex = 0;
            label3.Text = "Km:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 60);
            label2.Name = "label2";
            label2.Size = new Size(68, 24);
            label2.TabIndex = 0;
            label2.Text = "Placa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 24);
            label1.TabIndex = 0;
            label1.Text = "Modelo:";
            // 
            // ControleDeFrota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 788);
            Controls.Add(panel1);
            Controls.Add(btnSalvar);
            Controls.Add(btnCaminhao);
            Controls.Add(btnCarros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ControleDeFrota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de frota";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTruck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCarros;
        private Button btnCaminhao;
        private Button btnSalvar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblEixo;
        private TextBox txtKm;
        private TextBox txtModelo;
        private TextBox txtPlaca;
        private TextBox txtEixo;
        private PictureBox pbTruck;
        private PictureBox pbCar;
        private TextBox txtCarros;
        private TextBox txtCaminhao;
    }
}
