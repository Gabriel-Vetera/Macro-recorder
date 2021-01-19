using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

using Cursor = System.Windows.Forms.Cursor;


namespace Vetera_MouseRec
{
    public partial class Form1 : MetroForm
    {
        Main main_var = new Main() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Rec rec_var = new Rec() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Play play_var = new Play() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        readonly CreatePlaybackCreate cpc_var = new CreatePlaybackCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public static PictureBox options;

        public static RichTextBox infoBox;



        bool hotkey_playback = false, hotkey_rec = false, hotkey_pause = false;


        int metro_tab_fix = -1;

        Keys1 keys = new Keys1();

        int pause_now = 0;
        bool queue_loop = false;

        List<KeyboardData> keyboard_data = new List<KeyboardData>();
        List<MouseData> mouse_data = new List<MouseData>();
        int rec_pointer = 0;

        DateTime start = DateTime.Now;
        DateTime stop = DateTime.Now;
        TimeSpan ts;


        int x, y, mc;
        int qual = 1;

        bool record = false, playback_b = false;



        public Form1()
        {
            InitializeComponent();
            ChangeMetroTabMain();
            infoBox = infoTextBox;
            infoBox.Text = "Done(Start). Finished at " + DateTime.Now.ToString();
            infoBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 400;
            this.Width = 800;
            SetColor();

            timer_add_events.Interval = qual;
            timer_hotkey_options.Interval = qual;
            timer_rec_events.Interval = qual;
            timer_hotkey_options.Interval = 2;

            timer_add_events.Start();
            timer_rec_events.Start();
            timer_hotkey_press.Start();

            timer_hotkey_options.Start();

        }

        private void SetColor()
        {
            this.Theme = Cash.color_theme[Cash.theame];
            this.Style = Cash.color_style[Cash.theame];

            metroTabControl_min.Theme = Cash.color_theme[Cash.theame];
            metroTabControl_min.Style = Cash.color_style[Cash.theame];

            infoTextBox.BackColor = Cash.color_backgrund[Cash.theame];
            infoTextBox.ForeColor = Cash.color_text[Cash.theame];

            button_option.Image = Cash.Options;
            button_option.BackColor = Cash.color_backgrund[Cash.theame];
            options = button_option;

        }



        private void isLoopFinish()
        {
            if (playback_b && !record && Cash.loop && !queue_loop && Cash.IsPlaybackLoopFinish() && Cash.isLoopFinish())
            {
                queue_loop = true;
                Task.Run(() => NextLoop());
            }
        }

        private void NextLoop()
        {
            int timeout = Cash.loop_time; //in ms
            timeout = timeout / 100;
            for (int i = timeout; i > 1; i--)
            {
                if (Cash.STOP_PLAYBACK) return;
                Play.Countdown = i;
                Thread.Sleep(100);
            }
            if (Cash.STOP_PLAYBACK) return;

            queue_loop = false;
            Task.Run(() => StartPlayback());


        }



        //#########################################################################################################
        //#####################################     Rec functions    ####################################################
        //#########################################################################################################

        private List<Key> getKeys()
        {
            return keys.GetDownKeys().ToList();
        }

        private long getDelta()
        {
            stop = DateTime.Now;
            ts = (stop - start);
            start = DateTime.Now;
            return (long)ts.TotalMilliseconds;

        }

        private void addMouseEvent()
        {
            //d_keys = getKeys();
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            mc = 0;

            if (MouseButtons == MouseButtons.Left)
            {
                mc = 1;
            }
            else if (MouseButtons == MouseButtons.Right)
            {
                mc = 2;

            }

            if (mouse_data[rec_pointer].get_pre_mouseClick() != mc || mouse_data[rec_pointer].get_pre_x() != x || mouse_data[rec_pointer].get_pre_y() != y)
            {

                mouse_data[rec_pointer].add(x, y, mc, getDelta());


            }

        }

        private void FinishMouseData()
        {

            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            mc = 0;

            if (MouseButtons == MouseButtons.Left)
            {
                mc = 1;
            }
            else if (MouseButtons == MouseButtons.Right)
            {
                mc = 2;

            }

            mouse_data[rec_pointer].add(x, y, mc, getDelta());

        }


        //#########################################################################################################
        //#####################################     Hotkeys    ####################################################
        //#########################################################################################################

        private void CheckHotkeyPress()
        {
            if (!Cash.NOHOTKEYS)
            {
                if (!record && !playback_b)
                {
                    metro_tab_fix = -1;
                }

                if (Keyboard.IsKeyDown(Cash.key_rec) && pause_now == 0)
                {
                    pause_now = 20;
                    hotkey_rec = true;


                }

                if (Keyboard.IsKeyDown(Cash.key_playback) && pause_now == 0)
                {

                    pause_now = 20;
                    hotkey_playback = true;


                }

                if (Keyboard.IsKeyDown(Cash.key_pause) && pause_now == 0)
                {
                    pause_now = 20;
                    hotkey_pause = true;

                }

                if (pause_now > 0) pause_now -= 1;
            }
        }


        private void HotkeyOptions()
        {

            if (hotkey_rec && pause_now == 0)
            {
                hotkey_rec = false;

                if (!record && !playback_b)
                {
                    StartRec();


                }
                else
                {
                    StopRec();
                }


            }

            if (hotkey_playback && pause_now == 0)
            {

                hotkey_playback = false;

                if (playback_b)
                {

                    StopPlayback();

                }
                else if (!record && !playback_b)
                {
                    metro_tab_fix = 0;
                    playback_b = true;
                    ChangeMetroTabMain();

                    //StartPlayback();
                    Task.Run(() => StartPlayback());

                }


            }

            if (hotkey_pause && pause_now == 0)
            {
                hotkey_pause = false;

                if (!Cash.isPause())
                {
                    if (!Cash.playback_finish) Cash.paus_request = true;

                }
                else
                {
                    if (!Cash.playback_finish)
                    {

                        Task.Run(() => Cash.Resume());
                    }
                }



            }
        }


        private void StartPlayback()
        {


            //Playback playback = new Playback(Cash.data_list[start_pointer]);
            //if (!Cash.STOP_PLAYBACK) playback.Start();
            Cash.loop = Cash.loopMode;
            Cash.runingPlayback = new PlaybackPlay(Cash.PLAYBACK);
            //PlaybackPlay play = new PlaybackPlay(Cash.PLAYBACK);
            if (!Cash.STOP_PLAYBACK) Cash.runingPlayback.Start();


        }


        private void StopPlayback()
        {
            Cash.runingPlayback.Stop();
            Task.Run(() => StopPlaybackTask());
            if (Cash.loop) Cash.loop = false;
            pause_now = 20;
            metro_tab_fix = -1;
            playback_b = false;
            ChangeMetroTabMain();
        }

        private void StopPlaybackTask()
        {

            Thread.Sleep(5);
            Cash.STOP_PLAYBACK = true;
            Thread.Sleep(100);
            Cash.STOP_PLAYBACK = false;


        }

        private void StartRec()
        {
            metro_tab_fix = 0;

            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            mouse_data.Add(new MouseData());

            keyboard_data.Add(new KeyboardData());

            mouse_data[rec_pointer].add(x, y, 0, 0);
            start = DateTime.Now;

            record = true;
            ChangeMetroTabMain();
            Rec.Clear_Count();
        }

        private void StopRec()
        {
            metro_tab_fix = -1;
            record = false;
            FinishMouseData();

            Data data = new Data(mouse_data[mouse_data.Count - 1], keyboard_data[keyboard_data.Count - 1]);
            data.Name = mouse_data[mouse_data.Count - 1].getName();
            Cash.data_list.Add(data);
            rec_pointer++;

            ChangeMetroTabMain();
            //Task.Run(() => save());

        }

        private void save()
        {
            //  Save save = new Save(data[start_pointer], Keyboar_d);
            //  save.Start();

        }

        private void metroTabControl_main_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ChangeMetroTabMain();
        }





        //#########################################################################################################
        //#####################################     Timer    ####################################################
        //#########################################################################################################

        private void timer_hotkey_press_Tick(object sender, EventArgs e)
        {

            HotkeyOptions();


        }

        private String GetClosingInfo()
        {
            if (Cash.load) return Cash.infoLOADING;
            if (Cash.save) return Cash.infoSAVEING;
            return "";


        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            String infoText = GetClosingInfo();
            if (infoText != "")
            {
                bool check = false;
                using (var form = new ClosingInfo(infoText))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        check = form.CloseNow;

                    }
                }

                if (check)
                {
                    e.Cancel = false;
                    return;
                }
                e.Cancel = true;
            }

        }

        private void timer_hotkey_options_Tick(object sender, EventArgs e)
        {
            isLoopFinish();
            CheckHotkeyPress();

            if (metro_tab_fix >= 0 && metro_tab_fix != metroTabControl_min.SelectedIndex)
            {
                MetroTabChange(metro_tab_fix);
            }
        }



        private void timer_add_events_Tick(object sender, EventArgs e)
        {

            if (record)
            {

                addMouseEvent();
                keyboard_data[rec_pointer].inputData(getKeys());

            }
        }

        private void timer_rec_events_Tick(object sender, EventArgs e)
        {
            if (record)
            {
                long itmes_m = mouse_data[rec_pointer].getX().Length;
                long items_k = keyboard_data[rec_pointer].getKeyLength();
                Rec.changeCount(itmes_m + items_k + 2);

            }
        }




        //#########################################################################################################
        //#####################################     UI stuff    ####################################################
        //#########################################################################################################


        private void metroTabPage_Create_Click(object sender, EventArgs e)
        {

            /*this.panel_create.Controls.Clear();
            cpc_var.FormBorderStyle = FormBorderStyle.None;
            this.panel_create.Controls.Add(cpc_var);
            cpc_var.Show();*/
        }


        private void MetroTabChange(int index)
        {
            metroTabControl_min.SelectTab(index);

        }

        private void ChangeMetroTabMain()
        {

            if (record)
            {
                this.panal_main.Controls.Clear();
                rec_var.FormBorderStyle = FormBorderStyle.None;
                this.panal_main.Controls.Add(rec_var);
                rec_var.Show();
                return;
            }
            else if (playback_b)
            {

                this.panal_main.Controls.Clear();
                play_var.FormBorderStyle = FormBorderStyle.None;
                this.panal_main.Controls.Add(play_var);
                play_var.Show();
                return;

            }
            else
            {
                this.panal_main.Controls.Clear();
                main_var.FormBorderStyle = FormBorderStyle.None;
                this.panal_main.Controls.Add(main_var);
                main_var.Show();

            }

            this.panel_create.Controls.Clear();
            cpc_var.FormBorderStyle = FormBorderStyle.None;
            this.panel_create.Controls.Add(cpc_var);
            cpc_var.Show();

        }




        private void button_option_Click(object sender, EventArgs e)
        {
            Form dialog = new Settings();
            dialog.ShowDialog();



        }

    }
}
