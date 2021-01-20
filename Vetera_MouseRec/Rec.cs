using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class Rec : Form
    {
        public static long count = 0;

        bool move_up = true;

        float speed_max = 2.5f;
        float speed_min = 1.5f;

        int p_max = 100;
        int p_min = 0;
        int p;


        public static void Clear_Count()
        {
            count = 0;
        }
        public static void changeCount(long x)
        {
            count = x;
        }

        public Rec()
        {
            InitializeComponent();

            this.BackColor = Storage.colorBackgrund[Storage.themePointer];

            rec_spinner.BackColor = Storage.colorBackgrund[Storage.themePointer];

            rec_text_count.BackColor = Storage.colorBackgrund[Storage.themePointer];
            rec_text_count.ForeColor = Storage.colorText[Storage.themePointer];

        }

        private void Rec_Load(object sender, EventArgs e)
        {
            p = p_min;
            rec_spinner.Speed = 1.2f;
            timer_spinner.Start();

        }


        private void IncreaseProgress()
        {
            if (move_up)
            {
                p++;
                if (p_max <= p) move_up = false;

            }
            else
            {
                p--;
                if (p_min >= p) move_up = true;
            }

            rec_spinner.Value = p;



        }
        private void timer_spinner_Tick(object sender, EventArgs e)
        {



            rec_spinner.Speed = Remap(p, p_min, p_max, speed_min, speed_max);
            IncreaseProgress();
            rec_text_count.Text = count.ToString();

        }

        private void Rec_SizeChanged(object sender, EventArgs e)
        {
            int formHeight = this.Height;
            int formWidth = this.Width;



            rec_text_count.Location = new Point(formWidth / 2 - 50, formHeight / 2 - 20);

            rec_spinner.Location = new Point(formWidth / 2 - 100, formHeight / 2 - 100);

        }

        public float Remap(float value, float from1, float to1, float from2, float to2)
        {
            float OutPut = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
            return OutPut;
        }

    }
}
