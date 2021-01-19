using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class CustomAutoSizeText : PictureBox
    {
        private StringFormat sf = new StringFormat();

        public StringAlignment LineAlignment { get; set; } = StringAlignment.Center;
        public StringAlignment Alignment { get; set; } = StringAlignment.Center;

        public Font font { get; set; } = new Font("Arial", 12);

        private String _text = "null";
#pragma warning disable CS0114 // 'CustomAutoSizeText.Text' hides inherited member 'PictureBox.Text'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public String Text
#pragma warning restore CS0114 // 'CustomAutoSizeText.Text' hides inherited member 'PictureBox.Text'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        {
            get { return _text; }
            set
            {
                _text = value;
                Invalidate();
            }

        }

        public String Text_String
        {
            get { return _text; }
            set
            {
                _text = value;
                Invalidate();
            }

        }

        SolidBrush brush_text;

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

        public CustomAutoSizeText()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            brush_text = new SolidBrush(text_color);

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
            sf.LineAlignment = LineAlignment;
            sf.Alignment = Alignment;

            //g.DrawString(_text, font, brush_text, rect, sf);

            // Set up string. 
#pragma warning disable CS0219 // The variable 'measureString' is assigned but its value is never used
            string measureString = "Measure String";
#pragma warning restore CS0219 // The variable 'measureString' is assigned but its value is never used

            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = pe.Graphics.MeasureString(_text, font);

            // Draw rectangle representing size of string.
            pe.Graphics.DrawRectangle(new Pen(Color.Red, 1), 0.0F, 0.0F, stringSize.Width, stringSize.Height);

            // Draw string to screen.
            pe.Graphics.DrawString(_text, font, Brushes.Black, new PointF(0, 0));

            base.OnPaint(pe);




        }
    }
}
