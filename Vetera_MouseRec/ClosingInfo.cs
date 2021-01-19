using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class ClosingInfo : MetroForm
    {
        private bool _close = false;
        public bool CloseNow
        {
            get
            {
                return _close;
            }
        }
        public ClosingInfo(String Info)
        {
            InitializeComponent();
            SetColor();
            closingText_info.Text = Info;
            closingText_info.SelectAll();
            closingText_info.SelectionAlignment = HorizontalAlignment.Center;
            closingText_info.Select(0, 0);
        }

        private void SetColor()
        {
            this.Height = 200;
            this.Width = 400;

            this.Theme = Cash.color_theme[Cash.theame];
            this.Style = Cash.color_style[Cash.theame];

            closingText_info.BackColor = Cash.color_backgrund[Cash.theame];
            closingText_info.ForeColor = Cash.color_text[Cash.theame];

            closingButton_yes.BackColor = Cash.color_button[Cash.theame];
            closingButton_yes.ForeColor = Cash.color_text[Cash.theame];

            closingButton_cancel.BackColor = Cash.color_button[Cash.theame];
            closingButton_cancel.ForeColor = Cash.color_text[Cash.theame];


        }

        private void Return()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void closingButton_cancel_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void closingButton_yes_Click(object sender, EventArgs e)
        {
            _close = true;
            Return();
        }
    }
}
