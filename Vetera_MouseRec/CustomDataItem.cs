using System;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class CustomDataItem : UserControl
    {

        public FlowLayoutPanel panel = Main.panel;

        private bool first_text = false;
        private String _text = "null";
#pragma warning disable CS0114 // 'CustomDataItem.Text' hides inherited member 'UserControl.Text'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public String Text
#pragma warning restore CS0114 // 'CustomDataItem.Text' hides inherited member 'UserControl.Text'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        {
            get { return _text; }
            set
            {
                _text = value;
                text_name.Text = _text;
                Invalidate();
            }

        }

        private int _mouseData = 0;
        public int MouseData
        {
            get { return _mouseData; }
            set
            {
                _mouseData = value;
                text_mouse.Text = "Mouse items: " + _mouseData.ToString();
                Invalidate();
            }

        }

        private int _keyboardData = 0;
        public int KeyboardData
        {
            get { return _keyboardData; }
            set
            {
                _keyboardData = value;
                text_keyboard.Text = "Keyboard items: " + _keyboardData.ToString();
                Invalidate();
            }

        }




        public CustomDataItem()
        {
            InitializeComponent();
            this.BackColor = Storage.colorBackgrund[Storage.themePointer];

            text_name.BackColor = Storage.colorBackgrund[Storage.themePointer];
            text_name.ForeColor = Storage.colorText[Storage.themePointer];

            text_label.BackColor = Storage.colorBackgrund[Storage.themePointer];
            text_label.TextColor = Storage.colorText[Storage.themePointer];

            text_keyboard.BackColor = Storage.colorBackgrund[Storage.themePointer];
            text_keyboard.TextColor = Storage.colorText[Storage.themePointer];

            text_mouse.BackColor = Storage.colorBackgrund[Storage.themePointer];
            text_mouse.TextColor = Storage.colorText[Storage.themePointer];

            button_delete.BackColor = Storage.colorBackgrund[Storage.themePointer];

        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            int index = panel.Controls.IndexOfKey(Name);
            Storage.data_list.RemoveAt(index);
            panel.Controls.RemoveAt(index);
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;

            if (!first_text)
            {
                first_text = true;
            }
            else
            {
                if (t.Text.Length > 0)
                {
                    int index = panel.Controls.IndexOfKey(Name);
                    Storage.data_list[index].Name = t.Text;
                }
            }


        }
    }


}
