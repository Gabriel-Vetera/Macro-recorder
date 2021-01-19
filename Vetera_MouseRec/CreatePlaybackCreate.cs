using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class CreatePlaybackCreate : Form
    {
        List<DataCollection> add_data = new List<DataCollection>();

        int gap = 40;
        public static FlowLayoutPanel panel;

        Random random = new Random();

        private void SetColor()
        {
            this.BackColor = Cash.color_backgrund[Cash.theame];

            cpc_flowLayoutPanel_collection.BackColor = Cash.color_backgrund[Cash.theame];
            cpc_tableLayoutPanel_pbButtons.BackColor = Cash.color_backgrund[Cash.theame];

            cpc_panel1.BackColor = Cash.color_backgrund[Cash.theame];
            panel1.BackColor = Cash.color_backgrund[Cash.theame];


            cpc_button_load.BackColor = Cash.color_button[Cash.theame];
            cpc_button_load.ForeColor = Cash.color_text[Cash.theame];

            cpc_button_save.BackColor = Cash.color_button[Cash.theame];
            cpc_button_save.ForeColor = Cash.color_text[Cash.theame];

            cpc_button_cancel.BackColor = Cash.color_button[Cash.theame];
            cpc_button_cancel.ForeColor = Cash.color_text[Cash.theame];

            cpc_button_generalSettings.BackColor = Cash.color_button[Cash.theame];
            cpc_button_generalSettings.ForeColor = Cash.color_text[Cash.theame];


        }

        public CreatePlaybackCreate()
        {
            this.Size = (Size)new Point(0, 50);

            InitializeComponent();

            panel = cpc_flowLayoutPanel_collection;

            SetColor();

            update.Start();
        }

        private bool CheckName(String itemName)
        {
            bool isUnique = true;

            for (int i = 0; i < cpc_flowLayoutPanel_collection.Controls.Count; i++)
            {
                if (cpc_flowLayoutPanel_collection.Controls[i].Name == itemName)
                {
                    isUnique = false;
                    break;
                }

            }

            return isUnique;
        }

        private void CreateItem(DataCollection d)
        {
            CustomDataCollectionItem customDataCollectionItem = new CustomDataCollectionItem(d);

            String _Name;
            do
            {
                _Name = d.Title + "_INDEX_" + random.Next(0, 1000);

            } while (!CheckName(_Name));

            customDataCollectionItem.Name = _Name;
            customDataCollectionItem.Text = d.Title;
            customDataCollectionItem.Width = cpc_flowLayoutPanel_collection.Size.Width - gap; ;
            customDataCollectionItem.Description = d.Description;
            customDataCollectionItem.Data = d.Data;
            //int size = cpc_flowLayoutPanel_collection.Controls.Count;
            //customDataCollectionItem.PanelOrderNumber = size + 1;
            cpc_flowLayoutPanel_collection.Controls.Add(customDataCollectionItem);


        }



        private void cpc_flowLayoutPanel_collection_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                LoadData(fileList);
            }).Start();
            /*
            
            foreach (String path in fileList)
            {
                int postfixStart = path.IndexOf('.');
                String postfix = path.Substring(postfixStart);
                if (File.Exists(path) && postfix==".macro")
                {
                    Load load = new Load();
                    List<DataCollection> data; // = load.GetData(path);

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        LoadData(path);
                    }).Start();

                  
                    
                    
                }

            }*/


        }

        private void cpc_button_load_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.InitialDirectory = Properties.Settings.Default.ROOTPATH;
            openFileDialog.Filter = "Macro Rec |*.macro";
            openFileDialog.ShowDialog();


            String path = openFileDialog.FileName;
            if (File.Exists(path))
            {
                new Thread(() =>
                {
                    String[] st = new String[1] { path };
                    Thread.CurrentThread.IsBackground = true;
                    LoadData(st);
                }).Start();

                /*
                                Load load = new Load();
                                List<DataCollection> data = new List<DataCollection>();

                                new Thread(() =>
                                {
                                    Thread.CurrentThread.IsBackground = true;
                                    data = load.GetData(path);
                                }).Start();


                                //data = load.GetData(path);
                                Task responseTask = Task.Run(() => {

                                });
                                Task newTask = responseTask.ContinueWith(t => Form1.infoBox.Text = "Load data..");
                                newTask.Wait();

                                if (data.Count == 0)
                                {
                                    CreateItem(data[0]);
                                }
                                else
                                {
                                    for(int i = 0; i< data.Count; i++)
                                    {
                                        CreateItem(data[i]);
                                    }
                                }*/
            }



        }


        private void update_Tick(object sender, EventArgs e)
        {
            if (!Cash.load && Cash.load_waiting_list == 0 && Cash.load_cash.Count > 0) AddAll();
            //if (add_data.Count > 1) AddAll();
        }

        private String[] FileFilter(String[] FilePaths)
        {
            List<String> OutPut = new List<String>();
            foreach (String path in FilePaths)
            {
                int postfixStart = path.IndexOf('.');
                String postfix = path.Substring(postfixStart);
                if (File.Exists(path) && postfix == ".macro")
                {
                    OutPut.Add(path);
                }
            }
            return OutPut.ToArray();
        }

        private void LoadData(String[] FilePaths)
        {
            Cash.load = true;
            FilePaths = FileFilter(FilePaths);

            Cash.load_waiting_list = FilePaths.Length;
            Cash.load_start_time = DateTime.Now;
            List<DataCollection> cashData = new List<DataCollection>();



            for (int i = 0; i < FilePaths.Length; i++)
            {
                if (i < FilePaths.Length)
                {
                    LoadTest(i, FilePaths[i]);
                    /*new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        Load load = new Load();
                        Cash.load_cash.Add(new LoadedData(load.GetData(FilePaths[i]), i));
                        Cash.load_waiting_list--;

                    }).Start();*/
                }

            }
            Cash.load = false;
            add_data = cashData;


        }

        private void LoadTest(int i, String path)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Load load = new Load();
                Cash.load_cash.Add(new LoadedData(load.GetData(path), i));
                Cash.load_waiting_list--;

            }).Start();
        }


        private void AddAll()
        {
            int pos = 0;
            for (int i = 0; i < Cash.load_cash.Count; i++)
            {
                for (int sort = 0; sort < Cash.load_cash.Count; sort++)
                {
                    if (Cash.load_cash[sort].Position == i) pos = sort;
                }

                for (int z = 0; z < Cash.load_cash[pos].Data.Count; z++)
                {
                    CreateItem(Cash.load_cash[pos].Data[z]);
                }

            }

            DateTime stop = DateTime.Now;
            TimeSpan t;
            t = (stop - Cash.load_start_time);
            String passtTime = t.TotalSeconds.ToString();
            Form1.infoBox.Text = "Done(Load data). Finished in " + passtTime + " s." + DateTime.Now.ToString(); ;
            Form1.infoBox.SelectionAlignment = HorizontalAlignment.Center;

            Cash.load_cash.Clear();


            panel = cpc_flowLayoutPanel_collection;

        }


        private void cpc_flowLayoutPanel_collection_Resize(object sender, EventArgs e)
        {
            int width;
            if (cpc_flowLayoutPanel_collection.Controls.Count > 0)
            {


                for (int i = 0; i < cpc_flowLayoutPanel_collection.Controls.Count; i++)
                {

                    if (cpc_flowLayoutPanel_collection.Controls[i].Name == "Show")
                    {
                        width = cpc_flowLayoutPanel_collection.Size.Width - (gap + 7);
                        ShowDataItems d = (ShowDataItems)cpc_flowLayoutPanel_collection.Controls[i];
                        d.ItemWidth = width;
                    }

                    width = cpc_flowLayoutPanel_collection.Size.Width - gap;
                    Size s = cpc_flowLayoutPanel_collection.Controls[i].Size;
                    s.Width = width;
                    cpc_flowLayoutPanel_collection.Controls[i].Size = s;
                    Thread.Sleep(1);
                }

            }

        }

        private void cpc_flowLayoutPanel_collection_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void cpc_button_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {


            Cash.save_playback.dataCollections = GetDataCollections();
            Form dialog = new SaveDialog(true, "File name*");
            dialog.ShowDialog();


        }

        private List<DataCollection> GetDataCollections()
        {
            List<DataCollection> OutPut = new List<DataCollection>();
            for (int i = 0; i < cpc_flowLayoutPanel_collection.Controls.Count; i++)
            {
                if (cpc_flowLayoutPanel_collection.Controls[i].Name != "Show")
                {
                    CustomDataCollectionItem item = (CustomDataCollectionItem)cpc_flowLayoutPanel_collection.Controls[i];

                    OutPut.Add(item.dataCollection);
                }
            }

            return OutPut;

        }

        private void cpc_button_cancel_Click(object sender, EventArgs e)
        {
            cpc_flowLayoutPanel_collection.Controls.Clear();
        }
    }
}
