using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class ShowDataItems : UserControl
    {

        public CustomDataCollectionItem rootItem;
        public FlowLayoutPanel panel;
        int itemSpace = 6;
        private String description;

        bool _OrderVisible = false;
        public bool OrderVisible
        {
            get { return _OrderVisible; }
            set
            {
                _OrderVisible = value;

                foreach (Item_ShowDataItems d in flowLayoutPanel.Controls)
                {
                    d.OrderVisible = _OrderVisible;
                }
            }
        }


        private List<Data> _data = new List<Data>();
        public List<Data> ItemDatas
        {
            get { return _data; }
            set
            {
                _data = value;
            }
        }

        int _width = 0;
        public int ItemWidth
        {
            get { return _width; }
            set
            {
                _width = value;
                this.Width = _width;

                int panelHeight = 0;
                foreach (Item_ShowDataItems d in flowLayoutPanel.Controls)
                {
                    d.UpdateItem();
                    panelHeight += d.Height + itemSpace;
                }

                this.Height = panelHeight;
                Invalidate();
            }

        }

        public void UpdateItems()
        {

            int panelHeight = 0;
            foreach (Item_ShowDataItems d in flowLayoutPanel.Controls)
            {
                d.UpdateItem();
                panelHeight += d.Height + itemSpace;
            }

        }

        public void ReDrawBoders()
        {
            if (flowLayoutPanel.Controls.Count == 1)
            {
                rootItem.DeleteItem();
            }

            int panelHeight = 0;
            foreach (Item_ShowDataItems d in flowLayoutPanel.Controls)
            {
                d.UpdateItem();
                panelHeight += d.Height + itemSpace;
            }

            this.Height = panelHeight;
            Invalidate();
        }

        public ShowDataItems(List<Data> data, String description, Size s, CustomDataCollectionItem root)
        {
            InitializeComponent();
            this._data = data;
            this.description = description;
            this.rootItem = root;
            ItemWidth = s.Width - 7;

            SetColor();



            //AddNewItems();
            AddNewItems2();


        }
        private void AddNewItems()
        {
            panel = flowLayoutPanel;
            int panelHeight = 0;

            flowLayoutPanel.Controls.Clear();
            this.Name = "Show";

            Data description_item = new Data(new MouseData(), new KeyboardData());
            description_item.Name = description;
            Item_ShowDataItems Beschreibung = new Item_ShowDataItems(description_item, -1, ItemWidth, this, rootItem);
            panelHeight += Beschreibung.Height + itemSpace;
            flowLayoutPanel.Controls.Add(Beschreibung);

            int count = 1;
            foreach (Data d in _data)
            {
                Item_ShowDataItems NewItem = new Item_ShowDataItems(d, count, ItemWidth, this, rootItem);
                NewItem.OrderVisible = rootItem.OrderVisible;
                panelHeight += NewItem.Height + itemSpace;
                flowLayoutPanel.Controls.Add(NewItem);
                count++;
            }


            this.Height = panelHeight;
        }



        private void AddNewItems2()
        {
            panel = flowLayoutPanel;
            int panelHeight = 0;

            flowLayoutPanel.Controls.Clear();
            this.Name = "Show";


            Item_ShowDataItems Beschreibung = new Item_ShowDataItems(rootItem, this, description, ItemWidth);
            panelHeight += Beschreibung.Height + itemSpace;
            flowLayoutPanel.Controls.Add(Beschreibung);

            int count = 1;
            for (int i = 0; i < rootItem.dataCollection.Data.Count; i++)
            {
                Item_ShowDataItems NewItem = new Item_ShowDataItems(rootItem, this, i, ItemWidth);
                NewItem.OrderVisible = rootItem.OrderVisible;
                panelHeight += NewItem.Height + itemSpace;
                flowLayoutPanel.Controls.Add(NewItem);
                count++;
            }



            this.Height = panelHeight;
        }


        private void SetColor()
        {
            this.BackColor = Cash.color_backgrund[Cash.theame];
            flowLayoutPanel.BackColor = Cash.color_item_backgrund[Cash.theame];
        }


    }
}
