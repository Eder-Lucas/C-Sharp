using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Academia
{
    // Código completamente gerado por IA
    // Personaliza um controle para parecer um switch

    public class ToggleSwitch : Control
    {
        // 🔹 Estado do toggle
        private bool isChecked = false;

        // 🔹 Posição da bolinha (0 = desligado, 1 = ligado)
        private float togglePosition = 0f;

        // 🔹 Timer da animação
        private Timer animationTimer;

        // 🔹 Cores internas
        private Color onColor = Color.MediumSeaGreen;
        private Color offColor = Color.Gray;
        private Color toggleColor = Color.White;

        // 🔹 Velocidade da animação (milissegundos do Timer)
        private int animationInterval = 15;

        // 🔹 Propriedades visíveis no Designer
        [Category("Appearance")]
        [Description("Cor quando o toggle está ligado")]
        public Color OnColor
        {
            get => onColor;
            set { onColor = value; Invalidate(); }
        }
        public bool ShouldSerializeOnColor() => OnColor != Color.MediumSeaGreen;
        public void ResetOnColor() => OnColor = Color.MediumSeaGreen;

        [Category("Appearance")]
        [Description("Cor quando o toggle está desligado")]
        public Color OffColor
        {
            get => offColor;
            set { offColor = value; Invalidate(); }
        }
        public bool ShouldSerializeOffColor() => OffColor != Color.Gray;
        public void ResetOffColor() => OffColor = Color.Gray;

        [Category("Appearance")]
        [Description("Cor da bolinha do toggle")]
        public Color ToggleColor
        {
            get => toggleColor;
            set { toggleColor = value; Invalidate(); }
        }
        public bool ShouldSerializeToggleColor() => ToggleColor != Color.White;
        public void ResetToggleColor() => ToggleColor = Color.White;

        [Category("Behavior")]
        [Description("Intervalo da animação em milissegundos (quanto menor, mais rápido)")]
        public int AnimationSpeed
        {
            get => animationInterval;
            set
            {
                animationInterval = value;
                if (animationTimer != null)
                    animationTimer.Interval = animationInterval;
            }
        }
        public bool ShouldSerializeAnimationSpeed() => AnimationSpeed != 15;
        public void ResetAnimationSpeed() => AnimationSpeed = 15;

        [Category("Behavior")]
        [Description("Define se o toggle está ligado ou desligado")]
        public bool Checked
        {
            get => isChecked;
            set
            {
                if (isChecked != value)
                {
                    isChecked = value;
                    StartAnimation();
                    OnCheckedChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }
        public bool ShouldSerializeChecked() => Checked != false;
        public void ResetChecked() => Checked = false;

        // 🔹 Evento
        public event EventHandler OnCheckedChanged;

        // 🔹 Construtor
        public ToggleSwitch()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(60, 30);
            this.Cursor = Cursors.Hand;

            animationTimer = new Timer();
            animationTimer.Interval = animationInterval;
            animationTimer.Tick += AnimationTick;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                this.Checked = !this.Checked;

                // 🔥 dá resposta imediata parcial
                togglePosition += isChecked ? 0.15f : -0.15f;

                // mantém dentro do limite
                togglePosition = Math.Max(0f, Math.Min(1f, togglePosition));

                animationTimer.Start();
            }
        }

        // 🔹 Inicia a animação
        private void StartAnimation()
        {
            animationTimer.Start();
        }

        // 🔹 Move a bolinha suavemente
        private void AnimationTick(object sender, EventArgs e)
        {
            float target = isChecked ? 1f : 0f;
            float speed = 0.2f; // maior = mais rápido

            togglePosition += (target - togglePosition) * speed;

            // aproximação final
            if (Math.Abs(togglePosition - target) < 0.01f)
            {
                togglePosition = target;
                animationTimer.Stop();
            }

            Invalidate();
        }

        // 🔹 Desenho do toggle
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);

            int radius = this.Height;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            using (GraphicsPath path = GetRoundedPath(rect, radius))
            {
                using (Brush bgBrush = new SolidBrush(this.Checked ? OnColor : OffColor))
                    e.Graphics.FillPath(bgBrush, path);

                using (Pen pen = new Pen(Color.LightGray, 1))
                    e.Graphics.DrawPath(pen, path);
            }

            int padding = 3;
            int toggleSize = this.Height - padding * 2;
            int x = (int)(padding + togglePosition * (this.Width - toggleSize - padding * 2));

            using (Brush toggleBrush = new SolidBrush(ToggleColor))
            {
                e.Graphics.FillEllipse(toggleBrush, new Rectangle(x, padding, toggleSize, toggleSize));
            }
        }

        // 🔹 Cantos arredondados
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}