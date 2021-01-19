using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class Item_ShowDataItems : UserControl
    {

        //##############################################################
        int _pointer = -1;
        int Pointer
        {
            get { return _pointer; }
            set
            {
                _pointer = value;
            }
        }

        FlowLayoutPanel itemPanel;

        ShowDataItems childItem;
        CustomDataCollectionItem rootItem;


        //#############################################################


        FlowLayoutPanel fl;



        int _Order = -1;

        public Data ItemData;

        public int Order
        {
            get { return _Order; }
            set
            {

                _Order = value;
                oderField.Text = _Order.ToString();
                oderField.SelectAll();
                oderField.SelectionAlignment = HorizontalAlignment.Center;
                rootItem.dataCollection.Order[_pointer] = value;

            }
        }

        public int MaxOrder { get; set; } = -1;

        bool _OrderVisible = false;
        public bool OrderVisible
        {
            get { return _OrderVisible; }
            set
            {
                if (Order != -1)
                {
                    _OrderVisible = value;
                    SetHeight();
                    Invalidate();
                }
            }
        }

        int border = 1;

        int _width = 70;

        public void UpdateItem()
        {
            _width = childItem.Width - 23;
            if (_width > 100)
            {
                this.Width = _width;
                SetHeight();
                Invalidate();
            }
        }

        private void SetColor()
        {
            this.BackColor = Cash.color_item_backgrund[Cash.theame];
            this.ForeColor = Cash.color_item_backgrund[Cash.theame];
            TextField.BackColor = Cash.color_item_backgrund[Cash.theame];
            TextField.ForeColor = Cash.color_text[Cash.theame];
            oderField.BackColor = Cash.color_backgrund[Cash.theame];
            oderField.ForeColor = Cash.color_text[Cash.theame];

            contextMenuStrip1.ForeColor = Cash.color_text[Cash.theame];
            contextMenuStrip1.Renderer = new MyRenderer();
        }


        public Item_ShowDataItems(Data data, int _order, int Width, ShowDataItems child, CustomDataCollectionItem root)
        {
            InitializeComponent();
            //ItemWidth = 50;
            _width = child.panel.Width;
            Order = _order;
            ItemData = data;

            childItem = child;
            rootItem = root;

            SetColor();

            TextField.Text = data.Name;
            SetHeight();

            oderField.Text = Order.ToString();

            fl = child.panel;
            oderField.SelectAll();
            oderField.SelectionAlignment = HorizontalAlignment.Center;
        }

        public Item_ShowDataItems(CustomDataCollectionItem root, ShowDataItems child, int pointer, int Width)
        {
            InitializeComponent();

            this.Pointer = pointer;

            //ItemWidth = Width;   
            _width = child.panel.Width;
            rootItem = root;
            childItem = child;

            SetColor();

            _Order = root.dataCollection.Order[pointer];
            TextField.Text = root.dataCollection.Data[pointer].Name;
            SetHeight();

            oderField.Text = Order.ToString();

            itemPanel = child.panel;
            oderField.SelectAll();
            oderField.SelectionAlignment = HorizontalAlignment.Center;
        }

        public Item_ShowDataItems(CustomDataCollectionItem root, ShowDataItems child, String description, int Width)
        {
            InitializeComponent();

            this.Pointer = -1;

            //ItemWidth = Width;
            _width = child.panel.Width;
            rootItem = root;
            childItem = child;

            SetColor();

            _Order = -1;
            TextField.Text = description;
            SetHeight();

            oderField.Text = Order.ToString();

            itemPanel = child.panel;
            oderField.SelectAll();
            oderField.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void MoveTextBox()
        {
            if (!OrderVisible)
            {
                oderField.Width = 0;
                oderField.Height = 0;
                order_Backgrund.Width = 0;
                order_Backgrund.Height = 0;
            }

            if (OrderVisible)
            {
                if (this.Height < 99)
                {
                    oderField.Height = this.Height - (border * 2);
                    oderField.Width = this.Height - (border * 2);

                }
                oderField.Location = new Point((_width - oderField.Width) - border, border);    //Move RichBox to new Location

                order_Backgrund.Height = (this.Height - oderField.Height) - (border * 2);
                order_Backgrund.Width = oderField.Width;
                order_Backgrund.Location = new Point((_width - oderField.Width) - border, oderField.Height + border);    //Move RichBox to new Location
                order_Backgrund.Invalidate();
            }

            TextField.Width = _width - (border * 2) - oderField.Width;     //Resize RichBox
            TextField.Height = this.Height - (border * 2);
            TextField.Location = new Point(border, border);    //Move RichBox to new Location
        }

        private void SizeTextBox()
        {
            if (!OrderVisible)
            {
                oderField.Width = 0;
                oderField.Height = 0;
                order_Backgrund.Width = 0;
                order_Backgrund.Height = 0;
            }

            if (OrderVisible)
            {
                if (this.Height < 99)
                {
                    oderField.Height = this.Height - (border * 2);
                    oderField.Width = this.Height - (border * 2);

                }
            }

            TextField.Width = _width - (border * 2) - oderField.Width;     //Resize RichBox
            TextField.Height = 1000;
        }

        private void SetHeight()
        {
            SizeTextBox();
            int Rows = GetWarpRows(TextField);
            int hight = TextField.Font.Height;
            int newHight = Rows * hight + 10;
            this.Height = newHight;
            MoveTextBox();
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

        private void pictureBox_Border_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Cash.color_text[Cash.theame]);  // Paint the whole PictureBox in the background color
        }

        private void order_Backgrund_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Cash.color_item_backgrund[Cash.theame]);  // Paint the whole PictureBox in the background color
        }

        private void oder_MouseClick(object sender, MouseEventArgs e)
        {
            oderField.SelectionStart = oderField.Text.Length;
        }

        private void oder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }


            string newNumber = oderField.Text + e.KeyChar.ToString();

            if (oderField.SelectedText.Length == oderField.Text.Length)
            {
                newNumber = e.KeyChar.ToString();

            }


            int number;
            if (Int32.TryParse(newNumber, out number))
            {
                if (number > rootItem.dataCollection.Data.Count)
                {
                    e.Handled = true;
                    return;
                }

                foreach (Item_ShowDataItems d in itemPanel.Controls)
                {
                    if (d.Order == number)
                    {
                        d.Order = Order;
                        break;
                    }
                }

                _Order = number;
                oderField.SelectAll();
                oderField.SelectionAlignment = HorizontalAlignment.Center;
                rootItem.dataCollection.Order[_pointer] = _Order;
            }
        }


        private void customTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _Order != -1)
            {
                var relativeClickedPosition = e.Location;
                Point screenClickedPosition = (sender as Control).PointToScreen(relativeClickedPosition);
                screenClickedPosition.X -= 5;
                screenClickedPosition.Y -= 5;
                contextMenuStrip1.Show(screenClickedPosition);
                contextMenuStrip1.Items[0].Select();
            }
        }

        private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
        {
            contextMenuStrip1.Close();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Cash.color_backgrund[Cash.theame]; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Cash.color_item_backgrund[Cash.theame]; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Cash.color_backgrund[Cash.theame]; }
            }
        }


        private void RemoveItem2()
        {

            int itemLength = itemPanel.Controls.Count;

            for (int i = 0; i < itemLength; i++)
            {
                Item_ShowDataItems data = (Item_ShowDataItems)itemPanel.Controls[i];

                if (data.Pointer > _pointer)
                {
                    data.Pointer--;
                }

            }

            itemPanel.Controls.RemoveAt(_pointer + 1);
            rootItem.dataCollection.Data.RemoveAt(_pointer);
            ReOrder();
            childItem.ReDrawBoders();
        }


        private void ReOrder()
        {
            int itemLength = itemPanel.Controls.Count;

            for (int i = 0; i < itemLength; i++)
            {
                Item_ShowDataItems data = (Item_ShowDataItems)itemPanel.Controls[i];

                if (data.Order > _Order)
                {
                    data.Order--;
                }

            }

        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RemoveItem2();
            }
        }

        private void Item_ShowDataItems_Resize(object sender, EventArgs e)
        {

        }
    }
}
