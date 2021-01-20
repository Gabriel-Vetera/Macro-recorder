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
            this.BackColor = Storage.colorBackgrund[Storage.themePointer];

            main_text_emty.BackColor = Storage.colorBackgrund[Storage.themePointer];
            main_text_emty.ForeColor = Storage.colorText[Storage.themePointer];

            panel_data_items.BackColor = Storage.colorBackgrund[Storage.themePointer];

            main_button_save.BackColor = Storage.colorButton[Storage.themePointer];
            main_button_save.ForeColor = Storage.colorText[Storage.themePointer];

            main_button_load.BackColor = Storage.colorButton[Storage.themePointer];
            main_button_load.ForeColor = Storage.colorText[Storage.themePointer];            
        }

        private void UpdateItems()      //Looking for new Items to add in FlowLayoutPanel
        {
            if (data_size != Storage.data_list.Count && Storage.PLAYBACK.dataCollections.Count == 0)
            {
                Storage.PLAYBACK.Clear();
                panel_data_items.Controls.Clear();
                List<Data> data = Storage.data_list;
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
            customDataItem.Name = Storage.data_list[index].Name + "_INDEX_" + index;
            customDataItem.Text = Storage.data_list[index].Name;
            customDataItem.MouseData = Storage.data_list[index].MouseData.getX().Length;
            customDataItem.KeyboardData = Storage.data_list[index].KeyboardData.getKeyboarData().Count;
            return customDataItem;
        }

        private void IsEmty()
        {
            if (Storage.data_list.Count > 0 || Storage.PLAYBACK.dataCollections.Count != 0)
            {
                if (Storage.PLAYBACK.dataCollections.Count == 0 || Storage.data_list.Count > 0) main_button_save.Visible = true;
                main_text_emty.Visible = false;
            }
            else
            {
                main_button_save.Visible = false;
                main_text_emty.Visible = true;
            }

        }

        private void EmtyLable()    //Center main_text_emty & Write Text
        {
            int x = this.Width / 2 - 100;
            int y = this.Height / 2 - 50;
            main_text_emty.Location = new Point(x, y);
            main_text_emty.Text = "To Start/Stop a Record Press " + Storage.key_rec.ToString();

        }

        private void update_Tick(object sender, EventArgs e)
        {
            UpdateItems();
            IsEmty();
            if (main_text_emty.Text != "To Start/Stop a Record Press " + Storage.key_rec.ToString()) main_text_emty.Text = "To Start/Stop a Record Press " + Storage.key_rec.ToString();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            update.Start();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            EmtyLable();
        }

        //###########################################################################################################################
        //#########################################                 Load                    #########################################
        //###########################################################################################################################

        private void ReadData(string path)
        {
            ClearAll();

            int postfixStart = path.LastIndexOf('.');
            String postfix = path.Substring(postfixStart);
            if (File.Exists(path) && postfix == ".macro")
            {
                Load load = new Load();
                Storage.PLAYBACK.dataCollections = load.GetData(path);

                String name;
                int indexStart = path.LastIndexOf('\\') + 1;
                name = path.Substring(indexStart, postfixStart - indexStart);

                panel_data_items.Controls.Add(new Item_DataPlayback(name, Storage.PLAYBACK.dataCollections.Count));
                main_text_emty.Visible = false;
            }
        }

        private void ClearAll()
        {
            panel_data_items.Controls.Clear();
            Storage.data_list.Clear();
            Storage.PLAYBACK.Clear();
        }

        //################################################################################################################################
        //#########################################                 Drag&drop                    #########################################
        //################################################################################################################################

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
                Form1.infoBox.SelectionAlignment = HorizontalAlignment.Center;
            }

        }

        //##############################################################################################################################
        //#########################################                 Buttons                    #########################################
        //##############################################################################################################################

        private void main_button_load_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = Properties.Settings.Default.ROOTPATH;
            openFileDialog.Filter = "Macro Rec |*.macro";
            openFileDialog.ShowDialog();

            String path = openFileDialog.FileName;
            ReadData(path);            
        }

        private void main_button_save_Click(object sender, EventArgs e)
        {
            Form dialog = new SaveDialog(false, "Title... *");
            dialog.ShowDialog();
        }
    }
}
