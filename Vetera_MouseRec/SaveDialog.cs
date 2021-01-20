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
            this.BackColor = Storage.colorBackgrund[Storage.themePointer];

            savedialog_button_cancel.BackColor = Storage.colorButton[Storage.themePointer];
            savedialog_button_cancel.ForeColor = Storage.colorText[Storage.themePointer];

            showdialog_textBox_path.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            showdialog_textBox_path.ForeColor = Storage.colorText[Storage.themePointer];

            savedialog_button_selectpath.BackColor = Storage.colorButton[Storage.themePointer];
            savedialog_button_selectpath.ForeColor = Storage.colorText[Storage.themePointer];

            savedialog_textBox_description.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            savedialog_textBox_description.ForeColor = Storage.colorText[Storage.themePointer];

            savedialog_textBox_tilte.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            savedialog_textBox_tilte.ForeColor = Storage.colorText[Storage.themePointer];

            savedialog_button_save.BackColor = Storage.colorButton[Storage.themePointer];
            savedialog_button_save.ForeColor = Storage.colorText[Storage.themePointer];


        }

        private void SetHint(object sender, String hint)
        {
            TextBox t = (TextBox)sender;
            String text = t.Text;
            if (text.Length < 1)
            {
                t.Text = hint;
                t.ForeColor = Storage.colorHint[Storage.themePointer];
            }
            else
            {
                t.ForeColor = Storage.colorText[Storage.themePointer];
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
            Save save = new Save(Storage.save_playback, Path);
            Task.Run(() => save.Start());
            this.Close();
        }

        private void SaveDataCollection(String Path)
        {
            String description = savedialog_textBox_description.Text;
            String title = savedialog_textBox_tilte.Text;

            DataCollection savedData = new DataCollection(Storage.data_list, title, description, 1);
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
            b.BackColor = Storage.colorButton[Storage.themePointer];
            Thread.Sleep(300);
            b.BackColor = System.Drawing.Color.DarkRed;
            Thread.Sleep(300);

            AppendTextBox("Save");
            //b.Text = "Save";
            b.BackColor = Storage.colorButton[Storage.themePointer];
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
