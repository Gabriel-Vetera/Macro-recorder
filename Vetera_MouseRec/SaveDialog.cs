using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class SaveDialog : Form
    {
        bool playBackMode;
        String hint_title = "Title.. *";
        String hint_description = "Description.. (optional)";
        String path;
#pragma warning disable CS0169 // The field 'SaveDialog.data' is never used
        DataPlayback data;
#pragma warning restore CS0169 // The field 'SaveDialog.data' is never used

        public SaveDialog(bool PlayBackMode, String HintText)
        {
            InitializeComponent();
            SetColor();

            hint_title = HintText;
            playBackMode = PlayBackMode;


            if (PlayBackMode) savedialog_textBox_description.Visible = false;
        }

        private void SetColor()
        {
            this.BackColor = Cash.color_backgrund[Cash.theame];

            savedialog_button_cancel.BackColor = Cash.color_button[Cash.theame];
            savedialog_button_cancel.ForeColor = Cash.color_text[Cash.theame];

            showdialog_textBox_path.BackColor = Cash.color_item_backgrund[Cash.theame];
            showdialog_textBox_path.ForeColor = Cash.color_text[Cash.theame];

            savedialog_button_selectpath.BackColor = Cash.color_button[Cash.theame];
            savedialog_button_selectpath.ForeColor = Cash.color_text[Cash.theame];

            savedialog_textBox_description.BackColor = Cash.color_item_backgrund[Cash.theame];
            savedialog_textBox_description.ForeColor = Cash.color_text[Cash.theame];

            savedialog_textBox_tilte.BackColor = Cash.color_item_backgrund[Cash.theame];
            savedialog_textBox_tilte.ForeColor = Cash.color_text[Cash.theame];

            savedialog_button_save.BackColor = Cash.color_button[Cash.theame];
            savedialog_button_save.ForeColor = Cash.color_text[Cash.theame];


        }

        private void SetHint(object sender, String hint)
        {
            TextBox t = (TextBox)sender;
            String text = t.Text;
            if (text.Length < 1)
            {
                t.Text = hint;
                t.ForeColor = Cash.color_hint[Cash.theame];
            }
            else
            {
                t.ForeColor = Cash.color_text[Cash.theame];
            }
        }

        private void SaveDialog_Load(object sender, EventArgs e)
        {
            path = Properties.Settings.Default.ROOTPATH;
            showdialog_textBox_path.Text = path;
            SetHint((object)savedialog_textBox_tilte, hint_title);
            SetHint((object)savedialog_textBox_description, hint_description);
        }

        //###########################################################################################
        //################################### Buttons ##################################################
        //###########################################################################################

        private void savedialog_button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savedialog_button_selectpath_Click(object sender, EventArgs e)
        {

            folderBrowserDialog.SelectedPath = Properties.Settings.Default.ROOTPATH;
            folderBrowserDialog.ShowDialog();
            String path = folderBrowserDialog.SelectedPath;

            Properties.Settings.Default.ROOTPATH = path;
            Properties.Settings.Default.Save();

            showdialog_textBox_path.Text = Properties.Settings.Default.ROOTPATH;
        }

        private void savedialog_button_save_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (savedialog_textBox_tilte.Text == hint_title && (Properties.Settings.Default.ROOTPATH.Length > 0))
            {
                //b.Text = "You have to choos a title!";
                Task.Run(() => ChangeColor(sender));
                //Thread.Sleep(1000);
                //savedialog_button_save.Text = "Save";
            }
            else
            {
                String title = savedialog_textBox_tilte.Text;
                path = Properties.Settings.Default.ROOTPATH;
                String main_path = path;
                path = main_path + "\\" + title + ".macro";

                int count = 0;
                while (File.Exists(path))
                {
                    count++;
                    path = main_path + "\\" + title + "(" + count + ")" + ".macro";
                }
                if (!playBackMode)
                {
                    SaveDataCollection(path);
                }
                else
                {
                    SaveDataPlayback(path);
                }


            }

        }

        private void SaveDataPlayback(String Path)
        {
            Save save = new Save(Cash.save_playback, Path);
            Task.Run(() => save.Start());
            this.Close();
        }

        private void SaveDataCollection(String Path)
        {
            String description = savedialog_textBox_description.Text;
            String title = savedialog_textBox_tilte.Text;

            DataCollection savedData = new DataCollection(Cash.data_list, title, description, 1);
            Save save = new Save(savedData, Path);
            Task.Run(() => save.Start());
            this.Close();
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            savedialog_button_save.Text = value;
        }

        private void ChangeColor(object sender)
        {
            Button b = (Button)sender;


            AppendTextBox("You have to choos a title!");
            b.BackColor = System.Drawing.Color.DarkRed;

            Thread.Sleep(300);
            b.BackColor = Cash.color_button[Cash.theame];
            Thread.Sleep(300);
            b.BackColor = System.Drawing.Color.DarkRed;
            Thread.Sleep(300);

            AppendTextBox("Save");
            //b.Text = "Save";
            b.BackColor = Cash.color_button[Cash.theame];
        }

        //###########################################################################################
        //################################### Hint ##################################################
        //###########################################################################################
        private void savedialog_textBox_tilte_Click(object sender, EventArgs e)
        {
            if (savedialog_textBox_tilte.Text == hint_title)
            {
                savedialog_textBox_tilte.Text = null;
                savedialog_textBox_tilte.Refresh();
            }
        }

        private void savedialog_textBox_tilte_Leave(object sender, EventArgs e)
        {
            if (savedialog_textBox_tilte.Text.Length < 1)
            {
                SetHint(sender, hint_title);
            }
        }

        private void savedialog_textBox_description_MouseClick(object sender, MouseEventArgs e)
        {

            if (savedialog_textBox_description.Text == hint_description)
            {
                savedialog_textBox_description.Text = null;
                savedialog_textBox_description.Refresh();
            }
        }

        private void savedialog_textBox_description_Leave(object sender, EventArgs e)
        {
            if (savedialog_textBox_description.Text.Length < 1)
            {
                SetHint(sender, hint_description);
            }
        }

        private void savedialog_textBox_description_TextChanged(object sender, EventArgs e)
        {
            if (savedialog_textBox_description.Text.Length > 0)
            {
                SetHint(sender, hint_description);
            }
        }

        private void savedialog_textBox_tilte_TextChanged(object sender, EventArgs e)
        {
            if (savedialog_textBox_tilte.Text.Length > 0)
            {
                SetHint(sender, hint_description);
            }
        }


    }
}
