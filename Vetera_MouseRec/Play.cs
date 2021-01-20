using System;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    public partial class Play : Form
    {

        static String update_text = "";
        public static String SmoothText
        {
            set { update_text = Storage.infoSmooth + value + " ms"; }
        }

        static long _time = 0;
        public static long[] Time
        {
            set
            {

                long max_size = 0;
                foreach (long i in value)
                {
                    max_size += i;
                }

                _time = max_size;
            }
        }



        public static long KeyboardItems { get; set; } = 1;
        public static long MouseItems { get; set; } = 1;

        static long _items = 0;

        public static long Items
        {
            get { return _items; }
            set { _items = value; }
        }

        static DateTime _startTime = DateTime.Now;
        public static DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        static long time_passed = 0;
        TimeSpan ts;
        static CustomTextBox titleBox;
        static CustomTextBox nameBox;

        static String _itemTitle = "null";
        public static String ItemTitle
        {
            get { return _itemTitle; }
            set { titleBox.Text = value; }
        }

        static String _itemName = "null";
        public static String ItemName
        {
            get { return _itemName; }
            set { nameBox.Text = value; }
        }

        bool new_pause = false;
        public static bool SmoothMode { get; set; } = false;

        public static int Countdown { get; set; } = 0;


        long saved_progress = 0;

        public static void Reset()
        {
            KeyboardItems = 1;
            MouseItems = 1;
        }

        public Play()
        {
            InitializeComponent();
            ProgressBar.MaxValue = 10000;
            SetColor();

            titleBox = play_text_title;
            nameBox = play_text_name;
        }

        private void SetColor()
        {
            this.BackColor = Storage.colorBackgrund[Storage.themePointer];

            play_text_name.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            play_text_name.TextColor = Storage.colorText[Storage.themePointer];

            play_text_title.BackColor = Storage.colorItemBackgrund[Storage.themePointer];
            play_text_title.TextColor = Storage.colorText[Storage.themePointer];

            ProgressBar.ProgressBackgrund = Storage.colorItemBackgrund[Storage.themePointer];
            ProgressBar.ProgressForeground = Storage.colorContrast[Storage.themePointer];
            ProgressBar.TextColor = Storage.colorText[Storage.themePointer];
        }

        private void Play_Load(object sender, EventArgs e)
        {
            update.Start();
        }

        private void update_Tick(object sender, EventArgs e)
        {

            if (update_text.Length > 0)
            {
                ProgressBar.text = update_text;
                //update_text = "";

            }

            if (!SmoothMode)
            {
                if (!Storage.isPause())
                {

                    ts = (DateTime.Now - _startTime);
                    time_passed = (long)ts.TotalMilliseconds + saved_progress;
                    update_progress();
                }
                else
                {
                    if (!new_pause)
                    {
                        new_pause = true;
                        // mouse_items--;
                    }
                    saved_progress = time_passed;
                    _startTime = DateTime.Now;

                    long count_now = KeyboardItems + MouseItems;
                    String text = Storage.infoPause + count_now.ToString() + "/" + _items.ToString();
                    ProgressBar.text = text;
                    ProgressBar.Value = Remap(time_passed, 0, _time, 0, 10000);
                }

                if (Countdown > 5)
                {
                    ProgressBar.Value = 0;
                    String text = Storage.infoNextLoopStartIn + ((int)(Countdown / 10)).ToString();
                    ProgressBar.text = text;
                }
            }
        }



        private void update_progress()
        {

            if (!Storage.playback_finish)
            {
                if (!Storage.isPause())
                {
                    long count_now = KeyboardItems + MouseItems;
                    ProgressBar.text = count_now.ToString() + "/" + _items.ToString();

                    ProgressBar.Value = Remap(time_passed, 0, _time, 0, 10000);
                }
                if (Storage.paus_request && !Storage.isPause())
                {
                    long count_now = KeyboardItems + MouseItems;
                    ProgressBar.text = Storage.infoWaitForPause + "\n" + count_now.ToString() + "/" + _items.ToString();
                    ProgressBar.Value = Remap(time_passed, 0, _time, 0, 10000);
                }

            }
            else
            {
                if (Countdown < 1) ProgressBar.Value = ProgressBar.MaxValue;
            }
        }


        public int Remap(float value, float from1, float to1, float from2, float to2)
        {
            float OutPut = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
            return (int)OutPut;
        }
    }
}
