namespace conversorDeTemperatura
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            txtValor = new TextBox();
            rbCelsius1 = new RadioButton();
            rbKelvin1 = new RadioButton();
            rbFahrenheit1 = new RadioButton();
            gbEntrada = new GroupBox();
            btnLimpar = new Button();
            btnConverter = new Button();
            gbSaida = new GroupBox();
            rbFahrenheit2 = new RadioButton();
            rbCelsius2 = new RadioButton();
            rbKelvin2 = new RadioButton();
            label2 = new Label();
            txtResultado = new TextBox();
            gbEntrada.SuspendLayout();
            gbSaida.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValor.Location = new Point(98, 37);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(478, 30);
            txtValor.TabIndex = 0;
            // 
            // rbCelsius1
            // 
            rbCelsius1.AutoSize = true;
            rbCelsius1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCelsius1.Location = new Point(25, 32);
            rbCelsius1.Name = "rbCelsius1";
            rbCelsius1.Size = new Size(94, 27);
            rbCelsius1.TabIndex = 0;
            rbCelsius1.TabStop = true;
            rbCelsius1.Text = "Celsius";
            rbCelsius1.UseVisualStyleBackColor = true;
            // 
            // rbKelvin1
            // 
            rbKelvin1.AutoSize = true;
            rbKelvin1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbKelvin1.Location = new Point(25, 65);
            rbKelvin1.Name = "rbKelvin1";
            rbKelvin1.Size = new Size(82, 27);
            rbKelvin1.TabIndex = 1;
            rbKelvin1.TabStop = true;
            rbKelvin1.Text = "Kelvin";
            rbKelvin1.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit1
            // 
            rbFahrenheit1.AutoSize = true;
            rbFahrenheit1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFahrenheit1.Location = new Point(25, 98);
            rbFahrenheit1.Name = "rbFahrenheit1";
            rbFahrenheit1.Size = new Size(123, 27);
            rbFahrenheit1.TabIndex = 2;
            rbFahrenheit1.TabStop = true;
            rbFahrenheit1.Text = "Fahrenheit";
            rbFahrenheit1.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            gbEntrada.Controls.Add(rbFahrenheit1);
            gbEntrada.Controls.Add(rbKelvin1);
            gbEntrada.Controls.Add(rbCelsius1);
            gbEntrada.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbEntrada.Location = new Point(31, 90);
            gbEntrada.Name = "gbEntrada";
            gbEntrada.Size = new Size(250, 143);
            gbEntrada.TabIndex = 1;
            gbEntrada.TabStop = false;
            gbEntrada.Text = "Entrada";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Image = Properties.Resources.limpar;
            btnLimpar.ImageAlign = ContentAlignment.TopCenter;
            btnLimpar.Location = new Point(326, 325);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(148, 68);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.BottomCenter;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnConverter
            // 
            btnConverter.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConverter.Image = Properties.Resources.converter;
            btnConverter.ImageAlign = ContentAlignment.TopCenter;
            btnConverter.Location = new Point(110, 325);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(148, 68);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.TextAlign = ContentAlignment.BottomCenter;
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += button2_Click;
            // 
            // gbSaida
            // 
            gbSaida.Controls.Add(rbFahrenheit2);
            gbSaida.Controls.Add(rbCelsius2);
            gbSaida.Controls.Add(rbKelvin2);
            gbSaida.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSaida.Location = new Point(326, 90);
            gbSaida.Name = "gbSaida";
            gbSaida.Size = new Size(250, 143);
            gbSaida.TabIndex = 2;
            gbSaida.TabStop = false;
            gbSaida.Text = "Saída";
            // 
            // rbFahrenheit2
            // 
            rbFahrenheit2.AutoSize = true;
            rbFahrenheit2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbFahrenheit2.Location = new Point(25, 98);
            rbFahrenheit2.Name = "rbFahrenheit2";
            rbFahrenheit2.Size = new Size(123, 27);
            rbFahrenheit2.TabIndex = 2;
            rbFahrenheit2.TabStop = true;
            rbFahrenheit2.Text = "Fahrenheit";
            rbFahrenheit2.UseVisualStyleBackColor = true;
            // 
            // rbCelsius2
            // 
            rbCelsius2.AutoSize = true;
            rbCelsius2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbCelsius2.Location = new Point(25, 32);
            rbCelsius2.Name = "rbCelsius2";
            rbCelsius2.Size = new Size(94, 27);
            rbCelsius2.TabIndex = 0;
            rbCelsius2.TabStop = true;
            rbCelsius2.Text = "Celsius";
            rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbKelvin2
            // 
            rbKelvin2.AutoSize = true;
            rbKelvin2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbKelvin2.Location = new Point(25, 65);
            rbKelvin2.Name = "rbKelvin2";
            rbKelvin2.Size = new Size(82, 27);
            rbKelvin2.TabIndex = 1;
            rbKelvin2.TabStop = true;
            rbKelvin2.Text = "Kelvin";
            rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 263);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 0;
            label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(141, 260);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(435, 30);
            txtResultado.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 424);
            Controls.Add(gbSaida);
            Controls.Add(btnConverter);
            Controls.Add(btnLimpar);
            Controls.Add(txtResultado);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gbEntrada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de Temperatura";
            gbEntrada.ResumeLayout(false);
            gbEntrada.PerformLayout();
            gbSaida.ResumeLayout(false);
            gbSaida.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValor;
        private RadioButton rbCelsius1;
        private RadioButton rbKelvin1;
        private RadioButton rbFahrenheit1;
        private GroupBox gbEntrada;
        private Button btnLimpar;
        private Button btnConverter;
        private GroupBox gbSaida;
        private RadioButton rbCelsius2;
        private RadioButton rbKelvin2;
        private RadioButton rbFahrenheit2;
        private Label label2;
        private TextBox txtResultado;
    }
}
