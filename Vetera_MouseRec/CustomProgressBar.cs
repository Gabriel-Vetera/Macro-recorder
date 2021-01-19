using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class CustomProgressBar : PictureBox
    {

        double pbUnit;


        public Color DefaultBackgroundColor = Color.FromArgb(38, 38, 38);
        public Color DefaultForegroundgroundColor = Color.FromArgb(124, 65, 153);

        Color back_ground_color = Color.FromArgb(38, 38, 38);
        Color f_ground_color = Color.FromArgb(124, 65, 153);
        SolidBrush brush, brush_text;
        public Color ProgressForeground
        {
            get { return f_ground_color; }
            set
            {
                f_ground_color = value;
                brush = new SolidBrush(f_ground_color);
                Invalidate();
            }
        }
        public Color ProgressBackgrund
        {
            get { return back_ground_color; }
            set
            {
                back_ground_color = value;
                Invalidate();
            }
        }

        Color text_color = Color.FromArgb(188, 188, 188);
        public Color TextColor
        {
            get { return text_color; }
            set
            {
                text_color = value;
                brush_text = new SolidBrush(text_color);
                Invalidate();
            }
        }

        int maxvalue = 100;
        private string _text = "null";
        public string text
        {
            get { return _text; }
            set
            {
                _text = value;
                Invalidate();
            }
        }
        public int MaxValue
        {
            get { return maxvalue; }
            set
            {
                if (value >= 1)
                {
                    Rectangle rect = this.ClientRectangle;
                    pbUnit = rect.Width / (double)value;
                    maxvalue = value;

                }
            }
        }

        int text_size = 16;

        public int TextSize
        {
            get { return text_size; }
            set
            {
                if (value >= 1)
                {
                    text_size = value;
                }
            }
        }

        int _value = 0;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value >= 0)
                {
                    _value = value;
                }
                if (value > maxvalue)
                {
                    _value = maxvalue;
                }
                Invalidate(); //Redraw
            }
        }

        public CustomProgressBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            load_progressbar();

        }


        private void load_progressbar()
        {
            brush = new SolidBrush(f_ground_color);
            if (text == null) text = "";

        }
        protected override void OnResize(EventArgs e)
        {
            // Invalidate the control to get a repaint.
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = pe.Graphics;
            pbUnit = rect.Width / (double)maxvalue;
            g.Clear(back_ground_color);
            g.FillRectangle(brush, new Rectangle(0, 0, (int)(_value * pbUnit), rect.Height));

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            g.DrawString(_text, new Font("Arial", text_size), brush_text, rect, sf);

            base.OnPaint(pe);
        }
    }
}
