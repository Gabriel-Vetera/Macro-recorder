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

            this.Theme = Storage.colorTheme[Storage.themePointer];
            this.Style = Storage.colorStyle[Storage.themePointer];

            closingText_info.BackColor = Storage.colorBackgrund[Storage.themePointer];
            closingText_info.ForeColor = Storage.colorText[Storage.themePointer];

            closingButton_yes.BackColor = Storage.colorButton[Storage.themePointer];
            closingButton_yes.ForeColor = Storage.colorText[Storage.themePointer];

            closingButton_cancel.BackColor = Storage.colorButton[Storage.themePointer];
            closingButton_cancel.ForeColor = Storage.colorText[Storage.themePointer];
        }

        private void Return()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //###################################################################################################################################
        //#########################################                 Buttons                    ##############################################
        //###################################################################################################################################

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
