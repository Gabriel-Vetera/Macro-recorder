using System.Drawing;
using System.Drawing.Imaging;

namespace Vetera_MouseRec
{
    class ChangeImageColor
    {
        private Bitmap bmp;
        public ChangeImageColor(Bitmap bmp)
        {
            this.bmp = bmp;
        }
        public Bitmap Start()
        {
            Graphics g = Graphics.FromImage(bmp);
            // Set the image attribute's color mappings
            ColorMap[] colorMap = new ColorMap[1];
            colorMap[0] = new ColorMap();
            colorMap[0].OldColor = Color.FromArgb(255, 0, 0, 0);
            colorMap[0].NewColor = Cash.color_text[Cash.theame];
            ImageAttributes attr = new ImageAttributes();
            attr.SetRemapTable(colorMap);
            // Draw using the color map
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            return bmp;

        }

    }
}
