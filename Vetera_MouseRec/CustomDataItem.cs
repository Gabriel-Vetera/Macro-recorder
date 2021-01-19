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
            this.BackColor = Cash.color_backgrund[Cash.theame];

            text_name.BackColor = Cash.color_backgrund[Cash.theame];
            text_name.ForeColor = Cash.color_text[Cash.theame];

            text_label.BackColor = Cash.color_backgrund[Cash.theame];
            text_label.TextColor = Cash.color_text[Cash.theame];

            text_keyboard.BackColor = Cash.color_backgrund[Cash.theame];
            text_keyboard.TextColor = Cash.color_text[Cash.theame];

            text_mouse.BackColor = Cash.color_backgrund[Cash.theame];
            text_mouse.TextColor = Cash.color_text[Cash.theame];

            button_delete.BackColor = Cash.color_backgrund[Cash.theame];

        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            int index = panel.Controls.IndexOfKey(Name);
            Cash.data_list.RemoveAt(index);
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
                    Cash.data_list[index].Name = t.Text;
                }
            }


        }
    }


}
