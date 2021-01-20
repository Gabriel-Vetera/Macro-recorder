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
            this.BackColor = Storage.colorItemBackgrund[Storage.themePointer];

            text_PlaybackDataLable.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            text_PlaybackDataLable.TextColor = Storage.colorText[Storage.themePointer];

            text_NameLable.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            text_NameLable.TextColor = Storage.colorText[Storage.themePointer];

            text_Name.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            text_Name.ForeColor = Storage.colorText[Storage.themePointer];

            text_Size.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            text_Size.ForeColor = Storage.colorText[Storage.themePointer];
        }
    }
}
