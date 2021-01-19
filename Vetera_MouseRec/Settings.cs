using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class Settings : MetroForm
    {

        Keys rec;
        Keys playback;
        Keys pause;

        int maxLoopTimeValue = 60000;
        int loopTime;

        int[] smoothVar = new int[2];
        int maxSmoothVarValue = 1000;
        public Settings()
        {
            InitializeComponent();
            Cash.NOHOTKEYS = true;
            SetColor();
            Load();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cash.NOHOTKEYS = false;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void SetColor()
        {
            this.Height = 400;
            this.Width = 800;

            this.Theme = Cash.color_theme[Cash.theame];
            this.Style = Cash.color_style[Cash.theame];

            button_Save.BackColor = Cash.color_button[Cash.theame];
            button_Save.ForeColor = Cash.color_text[Cash.theame];

            richTextBox1.BackColor = Cash.color_backgrund[Cash.theame];
            richTextBox1.ForeColor = Cash.color_text[Cash.theame];

            richTextBox2.BackColor = Cash.color_backgrund[Cash.theame];
            richTextBox2.ForeColor = Cash.color_text[Cash.theame];

            text_smooth.BackColor = Cash.color_backgrund[Cash.theame];
            text_smooth.TextColor = Cash.color_text[Cash.theame];

            smooth_min.BackColor = Cash.color_backgrund[Cash.theame];
            smooth_min.ForeColor = Cash.color_text[Cash.theame];

            smooth_max.BackColor = Cash.color_backgrund[Cash.theame];
            smooth_max.ForeColor = Cash.color_text[Cash.theame];

            comboBox_Mode.BackColor = Cash.color_backgrund[Cash.theame];
            comboBox_Mode.ForeColor = Cash.color_text[Cash.theame];

            checkBox_Loop.BackColor = Cash.color_backgrund[Cash.theame];
            checkBox_Loop.ForeColor = Cash.color_text[Cash.theame];

            richText_Pause.BackColor = Cash.color_backgrund[Cash.theame];
            richText_Pause.ForeColor = Cash.color_text[Cash.theame];

            richText_Playback.BackColor = Cash.color_backgrund[Cash.theame];
            richText_Playback.ForeColor = Cash.color_text[Cash.theame];

            richText_Rec.BackColor = Cash.color_backgrund[Cash.theame];
            richText_Rec.ForeColor = Cash.color_text[Cash.theame];

            richText_LoopWaitTime.BackColor = Cash.color_backgrund[Cash.theame];
            richText_LoopWaitTime.ForeColor = Cash.color_text[Cash.theame];



        }

#pragma warning disable CS0108 // 'Settings.Load()' hides inherited member 'Form.Load'. Use the new keyword if hiding was intended.
        private void Load()
#pragma warning restore CS0108 // 'Settings.Load()' hides inherited member 'Form.Load'. Use the new keyword if hiding was intended.
        {
            smoothVar[0] = Properties.Settings.Default.SMOOTHMIN;
            smoothVar[1] = Properties.Settings.Default.SMOOTHMAX;
            smooth_min.Text = smoothVar[0].ToString();
            smooth_max.Text = smoothVar[1].ToString();

            richText_Rec.Text = Cash.key_rec.ToString();
            richText_Playback.Text = Cash.key_playback.ToString();
            richText_Pause.Text = Cash.key_pause.ToString();

            rec = (Keys)System.Windows.Input.KeyInterop.VirtualKeyFromKey(Cash.key_rec);
            playback = (Keys)System.Windows.Input.KeyInterop.VirtualKeyFromKey(Cash.key_playback);
            pause = (Keys)System.Windows.Input.KeyInterop.VirtualKeyFromKey(Cash.key_pause);

            richText_LoopWaitTime.Text = (Cash.loop_time / 1000).ToString();
            loopTime = Cash.loop_time / 1000;

            CenterText(smooth_min);
            CenterText(smooth_max);

            CenterText(richText_Rec);
            CenterText(richText_Playback);
            CenterText(richText_Pause);

            CenterText(richTextBox1);
            CenterText(richTextBox2);


            checkBox_Loop.Checked = Properties.Settings.Default.LOOP;

            if (Properties.Settings.Default.DARKMODE)
            {
                comboBox_Mode.SelectedIndex = 0;
            }
            else comboBox_Mode.SelectedIndex = 1;

        }

        private void Save()
        {
            Properties.Settings.Default.SMOOTHMIN = smoothVar[0];
            Properties.Settings.Default.SMOOTHMAX = smoothVar[1];
            Cash.smooth_mouse_time_min = smoothVar[0];
            Cash.smooth_mouse_time_max = smoothVar[1];

            Properties.Settings.Default.LOOPTIME = loopTime * 1000;

            Properties.Settings.Default.KEYREC = (int)System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)rec);
            Properties.Settings.Default.KEYPLAYBACK = (int)System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)playback);
            Properties.Settings.Default.KEYPAUSE = (int)System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)pause);

            Cash.loop_time = loopTime * 1000;
            Cash.key_rec = System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)rec);
            Cash.key_playback = System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)playback);
            Cash.key_pause = System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)pause);


            bool modePre = Properties.Settings.Default.DARKMODE;
            if (comboBox_Mode.SelectedIndex == 0)
            {
                Properties.Settings.Default.DARKMODE = true;
            }
            else Properties.Settings.Default.DARKMODE = false;

            Properties.Settings.Default.LOOP = checkBox_Loop.Checked;
            Cash.loopMode = checkBox_Loop.Checked;


            Properties.Settings.Default.Save();

            if (modePre != Properties.Settings.Default.DARKMODE)
            {
                Form1.infoBox.Text = Cash.infoBoxTheamChange;
                CenterText(Form1.infoBox);
            }
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

        private void ShowToolTip(string message)
        {
            toolTipMessage.Show(message, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2000);
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


        //Smooth min

        private void smooth_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }
        private void smooth_min_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) smoothVar[0] = Out;
            CheckValueValidty(0, smoothVar[0], maxSmoothVarValue);

            CenterText(sender);
        }



        private void smooth_min_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(0, smoothVar[0], maxSmoothVarValue);
            if (-1 != check)
            {
                smooth_min.Text = check.ToString();
                smoothVar[0] = check;
            }


            int max_check = CheckValueValidty(smoothVar[0], smoothVar[1], maxSmoothVarValue);    //max Check
            if (-1 != max_check)
            {
                smooth_max.Text = max_check.ToString();
                smoothVar[1] = max_check;
            }
        }
        //End Smooth min

        //Smooth max

        private void smooth_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }

        private void smooth_max_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) smoothVar[1] = Out;
            CheckValueValidty(smoothVar[0], smoothVar[1], maxSmoothVarValue);

            CenterText(sender);
        }


        private void smooth_max_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(smoothVar[0], smoothVar[1], maxSmoothVarValue);
            if (-1 != check)
            {
                smooth_max.Text = check.ToString();
                smoothVar[1] = check;
            }
        }

        //End Smooth max

        //LoopTime
        private void richText_LoopWaitTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckValidity(sender, e);
        }

        private void richText_LoopWaitTime_TextChanged(object sender, EventArgs e)
        {
            CleanText(sender);
            int Out = SenderValue(sender);
            if (Out != -1) loopTime = Out;
            CheckValueValidty(0, loopTime, maxLoopTimeValue);

            CenterText(sender);
        }

        private void richText_LoopWaitTime_Leave(object sender, EventArgs e)
        {
            int check = CheckValueValidty(0, loopTime, maxLoopTimeValue);
            if (-1 != check)
            {
                richText_LoopWaitTime.Text = check.ToString();
                loopTime = check;
            }
        }

        //End LoopTime

        private void NewKey(object sender, KeyEventArgs e)
        {
            RichTextBox r = (RichTextBox)sender;
            r.Text = e.KeyCode.ToString();
            CenterText(r);
        }



        private void richText_Rec_KeyDown(object sender, KeyEventArgs e)
        {
            NewKey(sender, e);
            rec = e.KeyCode;

        }


        private void richText_Playback_KeyDown(object sender, KeyEventArgs e)
        {
            NewKey(sender, e);
            playback = e.KeyCode;
        }

        private void richText_Pause_KeyDown(object sender, KeyEventArgs e)
        {
            NewKey(sender, e);
            pause = e.KeyCode;
        }

        private void Refuse(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }
    }
}
