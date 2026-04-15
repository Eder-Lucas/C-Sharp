using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Academia
{
    // Código completamente gerado por IA
    // Personaliza um controle para parecer um switch
    public class ToggleSwitch : Control
    {
        private float togglePosition = 0f;
        private Timer animationTimer;

        private bool suppressEvents = false;

        private bool isChecked = false;
        private bool enableAnimation = true;
        private int animationSpeed = 15;

        private Color onColor = Color.MediumSeaGreen;
        private Color offColor = Color.Gray;
        private Color toggleColor = Color.White;

        public event EventHandler CheckedChanged;

        [Category("Behavior")]
        [Description("Define se o switch está ligado ou desligado")]
        public bool Checked
        {
            get => isChecked;
            set
            {
                if (isChecked == value)
                    return;

                isChecked = value;

                if (enableAnimation)
                {
                    animationTimer.Start();
                }
                else
                {
                    togglePosition = isChecked ? 1f : 0f;
                    animationTimer.Stop();
                    Invalidate();
                }

                if (!suppressEvents)
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public bool ShouldSerializeChecked() => isChecked != false;
        public void ResetChecked() => isChecked = false;

        [Category("Behavior")]
        public bool EnableAnimation
        {
            get => enableAnimation;
            set => enableAnimation = value;
        }

        public bool ShouldSerializeEnableAnimation() => enableAnimation != true;
        public void ResetEnableAnimation() => enableAnimation = true;

        [Category("Behavior")]
        public int AnimationSpeed
        {
            get => animationSpeed;
            set
            {
                animationSpeed = value;
                if (animationTimer != null)
                    animationTimer.Interval = value;
            }
        }

        public bool ShouldSerializeAnimationSpeed() => animationSpeed != 15;
        public void ResetAnimationSpeed() => animationSpeed = 15;

        [Category("Appearance")]
        public Color OnColor
        {
            get => onColor;
            set { onColor = value; Invalidate(); }
        }

        public bool ShouldSerializeOnColor() => onColor != Color.MediumSeaGreen;
        public void ResetOnColor() => onColor = Color.MediumSeaGreen;

        [Category("Appearance")]
        public Color OffColor
        {
            get => offColor;
            set { offColor = value; Invalidate(); }
        }

        public bool ShouldSerializeOffColor() => offColor != Color.Gray;
        public void ResetOffColor() => offColor = Color.Gray;

        [Category("Appearance")]
        public Color ToggleColor
        {
            get => toggleColor;
            set { toggleColor = value; Invalidate(); }
        }

        public bool ShouldSerializeToggleColor() => toggleColor != Color.White;
        public void ResetToggleColor() => toggleColor = Color.White;

        public ToggleSwitch()
        {
            DoubleBuffered = true;
            Size = new Size(60, 30);
            Cursor = Cursors.Hand;

            animationTimer = new Timer();
            animationTimer.Interval = animationSpeed;
            animationTimer.Tick += AnimationTick;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button != MouseButtons.Left)
                return;

            Checked = !Checked;
        }

        private void AnimationTick(object sender, EventArgs e)
        {
            float target = isChecked ? 1f : 0f;
            float speed = 0.2f;

            togglePosition += (target - togglePosition) * speed;

            if (Math.Abs(togglePosition - target) < 0.01f)
            {
                togglePosition = target;
                animationTimer.Stop();
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(BackColor);

            int radius = Height;
            Rectangle rect = new Rectangle(0, 0, Width, Height);

            using (GraphicsPath path = GetRoundedPath(rect, radius))
            {
                using (Brush bg = new SolidBrush(isChecked ? OnColor : OffColor))
                    e.Graphics.FillPath(bg, path);

                e.Graphics.DrawPath(Pens.LightGray, path);
            }

            int padding = 3;
            int size = Height - padding * 2;

            int x = (int)(padding + togglePosition * (Width - size - padding * 2));

            using (Brush b = new SolidBrush(ToggleColor))
            {
                e.Graphics.FillEllipse(b, new Rectangle(x, padding, size, size));
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        public void SetCheckedSilently(bool value)
        {
            suppressEvents = true;

            EnableAnimation = false;

            isChecked = value;
            togglePosition = value ? 1f : 0f;

            Invalidate();

            EnableAnimation = true;
            suppressEvents = false;
        }
    }
}