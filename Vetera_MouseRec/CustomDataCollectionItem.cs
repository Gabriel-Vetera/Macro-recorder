using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class CustomDataCollectionItem : UserControl
    {


        public FlowLayoutPanel panel = CreatePlaybackCreate.panel;
        public ShowDataItems childItem;

        private int _panelOrderNumber = 0;
        public int PanelOrderNumber
        {
            get { return _panelOrderNumber; }
            set
            {
                _panelOrderNumber = value;
                Text_playbackOrder.Text = value.ToString();
                Invalidate();
            }
        }

        public bool OrderVisible = false;

        private bool showData = false;

        private String _text = "null";
#pragma warning disable CS0114 // 'CustomDataCollectionItem.Text' hides inherited member 'UserControl.Text'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        public String Text
#pragma warning restore CS0114 // 'CustomDataCollectionItem.Text' hides inherited member 'UserControl.Text'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.
        {
            get { return _text; }
            set
            {
                _text = value;
                text_title.Text = _text;
                Invalidate();
            }

        }

        private String _description = "null";
        public String Description
        {
            get { return _description; }
            set
            {
                _description = "Description: " + value;
                Invalidate();
            }

        }

        private List<Data> _data = new List<Data>();

        public List<Data> Data
        {
            get { return _data; }
            set
            {
                _data = value;
            }

        }

        public DataCollection dataCollection;


        private void ChangeOrderNumberForAll()
        {
            int ownIndex = panel.Controls.IndexOfKey(Name);
            Type OwnType = panel.Controls[ownIndex].GetType();

            for (int i = ownIndex; i < panel.Controls.Count; i++)
            {
                if (panel.Controls[i].GetType() == OwnType)
                {
                    CustomDataCollectionItem item = (CustomDataCollectionItem)panel.Controls[i];
                    item.PanelOrderNumber = item.PanelOrderNumber - 1;
                }
            }


        }

        private int GetOrderNumber()
        {
            int OutPut = 1;
            int ownIndex = panel.Controls.IndexOfKey(Name);
            Type OwnType = panel.Controls[ownIndex].GetType();

            for (int i = 0; i < ownIndex; i++)
            {

                if (panel.Controls[i].GetType() == OwnType) OutPut++;


            }

            return OutPut;


        }


        public void MoveUp(bool ShowActive)
        {
            int ownIndex = panel.Controls.IndexOfKey(Name);

            if (showData)
            {
                if (ShowActive)
                {
                    panel.Controls.SetChildIndex(panel.Controls[ownIndex], ownIndex - 2);        //move this
                }
                else panel.Controls.SetChildIndex(panel.Controls[ownIndex], ownIndex - 1);        //move this

                MoveChild();

                PanelOrderNumber = GetOrderNumber();    //change order number

            }
            else
            {
                if (ShowActive)
                {
                    panel.Controls.SetChildIndex(panel.Controls[ownIndex], ownIndex - 2);        //move this
                }
                else panel.Controls.SetChildIndex(panel.Controls[ownIndex], ownIndex - 1);        //move this

                PanelOrderNumber = GetOrderNumber();    //change order number
            }
        }

        public void MoveDown()
        {
            int ownIndex = panel.Controls.IndexOfKey(Name);

            if (showData)
            {

                panel.Controls.SetChildIndex(panel.Controls[ownIndex], ownIndex + 2);        //move this

                MoveChild();

                PanelOrderNumber = GetOrderNumber();    //change order number
            }
            else
            {
                panel.Controls.SetChildIndex(panel.Controls[ownIndex], ownIndex + 1);        //move this
                PanelOrderNumber = GetOrderNumber();    //change order number
            }
        }

        private void SetColor()
        {
            this.BackColor = Cash.color_backgrund[Cash.theame];

            text_title.BackColor = Cash.color_backgrund[Cash.theame];
            text_title.ForeColor = Cash.color_text[Cash.theame];

            //toolTip.BackColor = Cash.color_item_backgrund[Cash.theame];
            //toolTip.ForeColor = Cash.color_text[Cash.theame];

            Text_playbackOrder.BackColor = Cash.color_backgrund[Cash.theame];
            Text_playbackOrder.TextColor = Cash.color_text[Cash.theame];

            text_label.BackColor = Cash.color_backgrund[Cash.theame];
            text_label.TextColor = Cash.color_text[Cash.theame];

            button_delete.BackColor = Cash.color_backgrund[Cash.theame];

            pictureBox_DropDown.BackColor = Cash.color_backgrund[Cash.theame];
            pictureBox_DropDown.Image = Cash.ArrwoDown;

            button_up.BackColor = Cash.color_backgrund[Cash.theame];
            button_up.Image = Cash.A_up;

            button_down.BackColor = Cash.color_backgrund[Cash.theame];
            button_down.Image = Cash.A_down;

            button_options.BackColor = Cash.color_backgrund[Cash.theame];
            button_options.Image = Cash.Options;

        }
        public CustomDataCollectionItem(DataCollection d)
        {
            dataCollection = d;
            InitializeComponent();
            SetColor();
            if (dataCollection.Schedule == 0) OrderVisible = true;


            int OutPut = 1;

            Type OwnType = this.GetType();

            for (int i = 0; i < panel.Controls.Count; i++)
            {
                if (panel.Controls[i].GetType() == OwnType) OutPut++;
            }


            PanelOrderNumber = OutPut;
            // if (2 < text_title.Text.Length) Task.Run(() => SetFont());

        }


        public void DeleteItem()
        {
            ChangeOrderNumberForAll();
            if (!showData)
            {
                int index = panel.Controls.IndexOfKey(Name);
                panel.Controls.RemoveAt(index);
            }
            else
            {
                int index = panel.Controls.IndexOfKey(Name);
                panel.Controls.RemoveAt(index + 1);
                panel.Controls.RemoveAt(index);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }



        private void CustomDataCollectionItem_Load(object sender, EventArgs e)
        {
            /*  toolTip.SetToolTip(this, _tooltip);
              toolTip.SetToolTip(text_label, _tooltip);
              toolTip.SetToolTip(text_title, _tooltip);

              toolTip.ShowAlways = true;*/
        }

        private void toolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }



        private void SetFont()
        {
            // Running on the worker thread

            this.text_title.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                text_title.Font = new Font("Arial", 30f, FontStyle.Bold);

                int totalHeight;
                do
                {
                    float textSize = text_title.Font.Size;
                    int rows = GetWarpRows(text_title);
                    int fontHeight = text_title.Font.Height;
                    totalHeight = rows * fontHeight;

                    if (text_title.Height < totalHeight)
                    {

                        text_title.Font = new Font("Arial", (textSize * 0.85f), FontStyle.Bold);
                        Thread.Sleep(1);
                    }


                } while (text_title.Height < totalHeight);
            });



        }

        public int GetWarpRows(RichTextBox r)     // Found on: https://stackoverflow.com/questions/9606818/getting-the-number-of-text-lines-in-a-textbox/9607253 , from User: dCake
        {
            int count = r.GetLineFromCharIndex(int.MaxValue) + 1;
            // Now count is the number of lines that are displayed, if the textBox is empty count will be 1
            // And to get the line number without the empty lines:
            if (r.Lines.Length == 0)
                --count;
            foreach (string line in r.Lines)
            {
                if (line == "") --count;
            }

            return count;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (showData)
            {


                int ownIndex = panel.Controls.IndexOfKey(Name);
                ShowDataItems d = (ShowDataItems)panel.Controls[ownIndex + 1];
                if (OrderVisible)
                {
                    //toolStripMenuItem1.Text = "In order";
                    d.OrderVisible = false;
                    OrderVisible = false;
                    dataCollection.Schedule = 1;
                }
                else
                {
                    //toolStripMenuItem1.Text = "Choose random item";
                    d.OrderVisible = true;
                    OrderVisible = true;
                    dataCollection.Schedule = 0;
                }

            }
            else
            {

                if (OrderVisible)
                {
                    // toolStripMenuItem1.Text = "In order";
                    OrderVisible = false;
                    dataCollection.Schedule = 1;
                }
                else
                {
                    //toolStripMenuItem1.Text = "Choose random item";
                    OrderVisible = true;
                    dataCollection.Schedule = 0;
                }
            }


        }

        private void ChangeVisibilityOrder()
        {
            int mode = dataCollection.Schedule;

            if (showData)
            {
                int ownIndex = panel.Controls.IndexOfKey(Name);
                ShowDataItems d = (ShowDataItems)panel.Controls[ownIndex + 1];

                switch (mode)
                {
                    case 0:
                        OrderVisible = true;
                        d.OrderVisible = true;
                        break;

                    case 1:
                        OrderVisible = false;
                        d.OrderVisible = false;
                        break;

                    case 2:
                        OrderVisible = false;
                        d.OrderVisible = false;
                        break;

                }
            }
            else
            {
                switch (mode)
                {
                    case 0:
                        OrderVisible = true;
                        break;

                    case 1:
                        OrderVisible = false;
                        break;

                    case 2:
                        OrderVisible = false;
                        break;

                }
            }
        }

        private void tableLayoutPanel2_Resize(object sender, EventArgs e)
        {
            // if (2 < text_title.Text.Length) Task.Run(() => SetFont());

        }


        private async void ShowItems2()
        {
            Bitmap b = new Bitmap(pictureBox_DropDown.Image);
            b.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox_DropDown.Image = b;

            if (!showData)
            {




                int ownIndex = panel.Controls.IndexOfKey(Name);
                int childIndex = panel.Controls.GetChildIndex(panel.Controls[ownIndex]);

                childItem = new ShowDataItems(_data, _description, this.Size, this);

                var progress = new Progress<string>(s => panel.Controls.Add(childItem));
                await Task.Factory.StartNew(() => SecondThreadConcern.LongWork(progress),
                                            TaskCreationOptions.LongRunning);

                var progress2 = new Progress<string>(s => panel.Controls.SetChildIndex(panel.Controls[panel.Controls.Count - 1], childIndex + 1));
                await Task.Factory.StartNew(() => SecondThreadConcern.LongWork(progress2),
                                            TaskCreationOptions.LongRunning);


                // panel.Controls.Add(childItem);
                // panel.Controls.SetChildIndex(panel.Controls[panel.Controls.Count - 1], childIndex + 1);

                showData = true;



            }
            else
            {
                int ownIndex = panel.Controls.IndexOfKey(Name);
                panel.Controls.RemoveAt(ownIndex + 1);

                showData = false;
            }

        }

        private void ShowItems()
        {
            Bitmap b = new Bitmap(pictureBox_DropDown.Image);
            b.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox_DropDown.Image = b;

            if (!showData)
            {



                int ownIndex = panel.Controls.IndexOfKey(Name);
                int childIndex = panel.Controls.GetChildIndex(panel.Controls[ownIndex]);

                childItem = new ShowDataItems(_data, _description, this.Size, this);


                panel.Controls.Add(childItem);
                panel.Controls.SetChildIndex(panel.Controls[panel.Controls.Count - 1], childIndex + 1);

                childItem.UpdateItems();


                showData = true;



            }
            else
            {
                int ownIndex = panel.Controls.IndexOfKey(Name);
                panel.Controls.RemoveAt(ownIndex + 1);

                showData = false;
            }
        }





        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List<DataCollection> data = new List<DataCollection>();
            //data.Add(dataCollection);

            using (var form = new PlaybackSettings(dataCollection))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dataCollection = form.data;

                }
            }
            ChangeVisibilityOrder();

        }

        private void button_options_Click(object sender, EventArgs e)
        {
            using (var form = new PlaybackSettings(dataCollection))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dataCollection = form.data;

                }
            }
            ChangeVisibilityOrder();
        }

        private void pictureBox_DropDown_Click(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void button_up_Click(object sender, EventArgs e)
        {

            int ownIndex = panel.Controls.IndexOfKey(Name);
            if (ownIndex != 0)
            {
                String itemTypeNameUp = panel.Controls[ownIndex - 1].GetType().ToString();
                String itemTypeName = panel.Controls[ownIndex].GetType().ToString();
                if (itemTypeNameUp == itemTypeName)
                {
                    CustomDataCollectionItem item = (CustomDataCollectionItem)panel.Controls[ownIndex - 1];
                    item.MoveDown();

                    if (showData)
                    {
                        MoveChild();
                    }

                    PanelOrderNumber = GetOrderNumber();    //change order number

                }
                else
                {
                    CustomDataCollectionItem item = (CustomDataCollectionItem)panel.Controls[ownIndex - 2];
                    item.MoveDown();
                    ownIndex = panel.Controls.IndexOfKey(Name);

                    if (showData)
                    {
                        MoveChild();
                    }

                    PanelOrderNumber = GetOrderNumber();    //change order number
                }
            }

        }

        private void MoveChild()
        {
            int ownIndex = panel.Controls.IndexOfKey(Name);

            childItem.Name = "MOVE";
            int childIndex = panel.Controls.IndexOfKey("MOVE");
            panel.Controls.SetChildIndex(panel.Controls[childIndex], ownIndex + 1);   //move child
            childItem.Name = "Show";
        }

        private void button_down_Click(object sender, EventArgs e)
        {

            int ownIndex = panel.Controls.IndexOfKey(Name);



            if (showData)
            {
                if (ownIndex != panel.Controls.Count - 2)
                {

                    CustomDataCollectionItem item = (CustomDataCollectionItem)panel.Controls[ownIndex + 2];

                    item.MoveUp(true);
                    MoveChild();

                    PanelOrderNumber = GetOrderNumber();    //change order number
                }

            }
            else
            {
                if (ownIndex != panel.Controls.Count - 1)
                {
                    CustomDataCollectionItem item = (CustomDataCollectionItem)panel.Controls[ownIndex + 1];
                    item.MoveUp(false);
                    PanelOrderNumber = GetOrderNumber();    //change order number
                }
            }
        }

    }

    class SecondThreadConcern
    {
        public static void LongWork(IProgress<string> progress)
        {
            // Perform a long running work...
            for (var i = 0; i < 1; i++)
            {
                Task.Delay(0).Wait();
                progress.Report(i.ToString());
            }
        }
    }
}
