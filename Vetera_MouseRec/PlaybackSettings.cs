using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class PlaybackSettings : MetroForm
    {


        public DataCollection data { get; set; } = new DataCollection();
        private int[] timeVar = new int[2];
        private int[] pixelVar = new int[2];
        private int random_number;

        private int maxTimeVarValue = 100;
        private int maxPixelVarValue = 2;

        public PlaybackSettings(DataCollection data)
        {
            InitializeComponent();
            this.data = data;

            this.Text = data.Title;
            timeVar = data.TimeVar;
            pixelVar = data.PixelVar;



        }

        private void SetColor()
        {
            this.Height = 400;
            this.Width = 600;

            this.Theme = Cash.color_theme[Cash.theame];
            this.Style = Cash.color_style[Cash.theame];

            toolTipMessage.BackColor = Cash.color_item_backgrund[Cash.theame];
            toolTipMessage.ForeColor = Cash.color_text[Cash.theame];

            playbackSettings_button_save.BackColor = Cash.color_button[Cash.theame];
            playbackSettings_button_save.ForeColor = Cash.color_text[Cash.theame];

            customTextBox1.BackColor = Cash.color_backgrund[Cash.theame];
            customTextBox1.TextColor = Cash.color_text[Cash.theame];

            customTextBox2.BackColor = Cash.color_backgrund[Cash.theame];
            customTextBox2.TextColor = Cash.color_text[Cash.theame];

            customTextBox3.BackColor = Cash.color_backgrund[Cash.theame];
            customTextBox3.TextColor = Cash.color_text[Cash.theame];

            timeVar_min.BackColor = Cash.color_item_backgrund[Cash.theame];
            timeVar_min.ForeColor = Cash.color_text[Cash.theame];

            timeVar_max.BackColor = Cash.color_item_backgrund[Cash.theame];
            timeVar_max.ForeColor = Cash.color_text[Cash.theame];

            pixelVar_max.BackColor = Cash.color_item_backgrund[Cash.theame];
            pixelVar_max.ForeColor = Cash.color_text[Cash.theame];

            pixelVar_min.BackColor = Cash.color_item_backgrund[Cash.theame];
            pixelVar_min.ForeColor = Cash.color_text[Cash.theame];

            richTextBox1.BackColor = Cash.color_backgrund[Cash.theame];
            richTextBox1.ForeColor = Cash.color_text[Cash.theame];
            CenterText(richTextBox1);
            richTextBox2.BackColor = Cash.color_backgrund[Cash.theame];
            richTextBox2.ForeColor = Cash.color_text[Cash.theame];
            CenterText(richTextBox2);


            randomNumber.BackColor = Cash.color_item_backgrund[Cash.theame];
            randomNumber.ForeColor = Cash.color_text[Cash.theame];

            comboBox_PlaybackMode.BackColor = Cash.color_backgrund[Cash.theame];
            comboBox_PlaybackMode.ForeColor = Cash.color_text[Cash.theame];

        }

        private void PlaybackSettings_Load(object sender, EventArgs e)
        {
            SetColor();
            comboBox_PlaybackMode.SelectedIndex = data.Schedule;

            random_number = data.Random;
            ChangeVisibility();

            timeVar_min.Text = timeVar[0].ToString();
            timeVar_max.Text = timeVar[1].ToString();
            pixelVar_min.Text = pixelVar[0].ToString();
            pixelVar_max.Text = pixelVar[1].ToString();
            CenterText((object)timeVar_min);
            CenterText((object)timeVar_max);
            CenterText((object)pixelVar_min);
            CenterText((object)pixelVar_max);


        }

        private void Return()
        {
            int selection = comboBox_PlaybackMode.SelectedIndex;
            data.Random = random_number;
            data.Schedule = selection;
            data.PixelVar = pixelVar;
            data.TimeVar = timeVar;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void playbackSettings_button_save_Click(object sender, EventArgs e)
        {
            Return();

        }

        private void CheckValidity(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)    //Check if 'Enter' key is pressed
            {
                e.Handled = true;   //dont use this input
                ProcessTabKey(true);
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //Check if key is a number
            {
                e.Handled = true;
                return;
            }

            RichTextBox r = (RichTextBox)sender;
            if (e.KeyChar == '0' && r.Text == "") //Check whether the first number would be a zero
            {
                e.Handled = true;
            }

            if (r.Text == "0")
            {
                r.Text = "";

            }



        }

        private void CleanText(object sender)
        {
            RichTextBox r = (RichTextBox)sender;
            String value = r.Text;
            int removed = 0;
            int selection = r.SelectionStart;
            if (value.Length > 1)
            {
                while (value[0] == '0')
                {
                    if (value.Length == 1) break;
                    value = value.Substring(1, value.Length - 1);
                    removed++;

                }

                r.Text = value;
                int startAt = selection - removed;
                if (startAt < 0) startAt = 0;
                r.SelectionStart = startAt;
            }
        }
        private void CenterText(object sender)
        {
            RichTextBox r = (RichTextBox)sender;

            r.SelectionAlignment = HorizontalAlignment.Center;
        }

        private int CheckValueValidty(int min, int value, int max)
        {
            if (min > value) { ShowToolTip("Value(" + value.ToString() + ") is too low range(" + min.ToString() + "-" + max.ToString() + ")"); return min; }
            if (max < value) { ShowToolTip("Value(" + value.ToString() + ") is too high range(" + min.ToString() + "-" + max.ToString() + ")"); return max; }
            if (0 > value) { ShowToolTip("Value too low"); return 0; }
            return -1;

        }

        private int SenderValue(object sender)
        {
            RichTextBox r = (RichTextBox)sender;
            int OutPut;


            if (Int32.TryParse(r.Text, out OutPut))
            {
                return OutPut;

            }
            return -1;
        }

        private void ShowToolTip(string message)
        {
            toolTipMessage.Show(message, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2000);
        }



        // PixelMin

        private void pixelVar_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }

        private void pixelVar_min_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) pixelVar[0] = Out;
            CheckValueValidty(0, pixelVar[0], maxPixelVarValue);

            CenterText(sender);

        }

        private void pixelVar_min_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(0, pixelVar[0], maxPixelVarValue);
            if (-1 != check)
            {
                pixelVar_min.Text = check.ToString();
                pixelVar[0] = check;
            }


            int max_check = CheckValueValidty(pixelVar[0], pixelVar[1], maxPixelVarValue);    //max Check
            if (-1 != max_check)
            {
                pixelVar_max.Text = max_check.ToString();
                pixelVar[1] = max_check;
            }

        }

        // PixelMin END

        // PixelMax

        private void pixelVar_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);

        }

        private void pixelVar_max_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) pixelVar[1] = Out;
            CheckValueValidty(pixelVar[0], pixelVar[1], maxPixelVarValue);

            CenterText(sender);

        }
        private void pixelVar_max_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(pixelVar[0], pixelVar[1], maxPixelVarValue);
            if (-1 != check)
            {
                pixelVar_max.Text = check.ToString();
                pixelVar[1] = check;
            }


        }

        // PixelMax END

        // TimeMin

        private void timeVar_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }

        private void timeVar_min_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) timeVar[0] = Out;
            CheckValueValidty(0, timeVar[0], maxTimeVarValue);

            CenterText(sender);
        }

        private void timeVar_min_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(0, timeVar[0], maxTimeVarValue);
            if (-1 != check)
            {
                timeVar_min.Text = check.ToString();
                timeVar[0] = check;
            }



            int max_check = CheckValueValidty(timeVar[0], timeVar[1], maxTimeVarValue);  //Check max
            if (-1 != max_check)
            {
                timeVar_max.Text = max_check.ToString();
                timeVar[1] = max_check;
            }
        }

        // TimeMin END

        // TimeMax 

        private void timeVar_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }
        private void timeVar_max_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) timeVar[1] = Out;
            CheckValueValidty(timeVar[0], timeVar[1], maxTimeVarValue);

            CenterText(sender);

        }

        private void timeVar_max_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(timeVar[0], timeVar[1], maxTimeVarValue);
            if (-1 != check)
            {
                timeVar_max.Text = check.ToString();
                timeVar[1] = check;
            }
        }

        private void comboBox_PlaybackMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            ChangeVisibility();
        }

        private void ChangeVisibility()
        {
            int mode = comboBox_PlaybackMode.SelectedIndex;
            if (mode == 2)
            {
                if (!tableLayoutPanel2.Visible)
                {
                    tableLayoutPanel2.Visible = true;
                    randomNumber.Text = random_number.ToString();
                }
                else randomNumber.Text = random_number.ToString();
            }
            else
            {
                if (tableLayoutPanel2.Visible) tableLayoutPanel2.Visible = false;
            }
        }

        private void randomNumber_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            random_number = Out;
            CheckValueValidty(0, random_number, 500);

            CenterText(sender);
        }

        private void randomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }

        private void randomNumber_Leave(object sender, EventArgs e)
        {
            random_number = SenderValue(sender);
            int check = CheckValueValidty(0, random_number, 500);
            if (-1 != check)
            {
                randomNumber.Text = check.ToString();
                random_number = check;
            }
        }


        // TimeMax END
    }
}
