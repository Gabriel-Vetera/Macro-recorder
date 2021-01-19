using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class Main : Form
    {
        public static FlowLayoutPanel panel;
        private int data_size = 0;
        public Main()
        {
            InitializeComponent();
            panel = panel_data_items;
            EmtyLable();
            SetColor();



        }

        private void SetColor()
        {
            this.BackColor = Cash.color_backgrund[Cash.theame];

            main_text_emty.BackColor = Cash.color_backgrund[Cash.theame];
            main_text_emty.ForeColor = Cash.color_text[Cash.theame];

            panel_data_items.BackColor = Cash.color_backgrund[Cash.theame];

            main_button_save.BackColor = Cash.color_button[Cash.theame];
            main_button_save.ForeColor = Cash.color_text[Cash.theame];
        }

        private void UpdateItems()
        {
            if (data_size != Cash.data_list.Count)
            {
                Cash.PLAYBACK.Clear();
                panel_data_items.Controls.Clear();
                List<Data> data = Cash.data_list;
                data_size = data.Count;
                for (int i = 0; i < data_size; i++)
                {
                    panel_data_items.Controls.Add(CreateItem(i));
                }

            }
        }


        private CustomDataItem CreateItem(int index)
        {
            CustomDataItem customDataItem = new CustomDataItem();
            customDataItem.Name = Cash.data_list[index].Name + "_INDEX_" + index;
            customDataItem.Text = Cash.data_list[index].Name;
            customDataItem.MouseData = Cash.data_list[index].MouseData.getX().Length;
            customDataItem.KeyboardData = Cash.data_list[index].KeyboardData.getKeyboarData().Count;
            return customDataItem;
        }

        private void isEmty()
        {
            if (Cash.data_list.Count > 0 || Cash.PLAYBACK.dataCollections.Count != 0)
            {
                if (Cash.PLAYBACK.dataCollections.Count == 0 || Cash.data_list.Count > 0) main_button_save.Visible = true;
                main_text_emty.Visible = false;
            }
            else
            {
                main_button_save.Visible = false;
                main_text_emty.Visible = true;
            }

        }

        private void EmtyLable()
        {
            int x = this.Width / 2 - 100;
            int y = this.Height / 2 - 50;
            main_text_emty.Location = new Point(x, y);
            main_text_emty.Text = "To Start/Stop a Recoard Press " + Cash.key_rec.ToString();

        }

        private void update_Tick(object sender, EventArgs e)
        {
            UpdateItems();
            isEmty();
            if (main_text_emty.Text != "To Start/Stop a Recoard Press " + Cash.key_rec.ToString()) main_text_emty.Text = "To Start/Stop a Recoard Press " + Cash.key_rec.ToString();



        }

        private void Main_Load(object sender, EventArgs e)
        {
            update.Start();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            EmtyLable();
        }

        private void main_button_save_Click(object sender, EventArgs e)
        {
            Form dialog = new SaveDialog(false, "Title... *");
            dialog.ShowDialog();
        }

        private void panel_data_items_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void panel_data_items_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (filePaths.Length == 1)
            {
                ReadData(filePaths[0]);
            }
            else
            {
                Form1.infoBox.Text = "ONLY ONE FILE!";
            }

        }



        private void ReadData(string path)
        {
            ClearAll();


            int postfixStart = path.LastIndexOf('.');
            String postfix = path.Substring(postfixStart);
            if (File.Exists(path) && postfix == ".macro")
            {
                Load load = new Load();
                Cash.PLAYBACK.dataCollections = load.GetData(path);

                String name;
                int indexStart = path.LastIndexOf('\\') + 1;
                name = path.Substring(indexStart, postfixStart - indexStart);

                panel_data_items.Controls.Add(new Item_DataPlayback(name, Cash.PLAYBACK.dataCollections.Count));
                main_text_emty.Visible = false;
            }

        }

        private void ClearAll()
        {
            panel_data_items.Controls.Clear();
            Cash.data_list.Clear();
            Cash.PLAYBACK.Clear();
        }
    }
}
