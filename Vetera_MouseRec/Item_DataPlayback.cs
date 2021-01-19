using System;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class Item_DataPlayback : UserControl
    {
        public Item_DataPlayback(String Name, int ItemSize)
        {
            InitializeComponent();
            SetColor();

            text_Name.Text = Name;
            Center(text_Name);

            text_Size.Text = "Item Size: " + ItemSize.ToString();
        }

        private void Center(RichTextBox r)
        {
            r.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void SetColor()
        {
            this.BackColor = Cash.color_item_backgrund[Cash.theame];

            text_PlaybackDataLable.BackColor = Cash.color_item_backgrund[Cash.theame];
            text_PlaybackDataLable.TextColor = Cash.color_text[Cash.theame];

            text_NameLable.BackColor = Cash.color_item_backgrund[Cash.theame];
            text_NameLable.TextColor = Cash.color_text[Cash.theame];

            text_Name.BackColor = Cash.color_item_backgrund[Cash.theame];
            text_Name.ForeColor = Cash.color_text[Cash.theame];

            text_Size.BackColor = Cash.color_item_backgrund[Cash.theame];
            text_Size.ForeColor = Cash.color_text[Cash.theame];
        }
    }
}
