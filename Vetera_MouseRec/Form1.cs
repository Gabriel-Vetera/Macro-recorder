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
        public static PictureBox options;
        public static RichTextBox infoBox;

        Main main_var = new Main() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Rec rec_var = new Rec() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Play play_var = new Play() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        readonly CreatePlaybackCreate cpc_var = new CreatePlaybackCreate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        GetKeys keys = new GetKeys();

        List<KeyboardData> keyboard_data = new List<KeyboardData>();
        List<MouseData> mouse_data = new List<MouseData>();

        DateTime start = DateTime.Now;
        DateTime stop = DateTime.Now;
        TimeSpan ts;

        int pause_now = 0;      //Button press cooldown in ms
        int rec_pointer = 0;
        int metro_tab_fix = -1; //(metro_tab_fix > -1 ) Lock metroTabControl tab to selected value
        int x, y, mc;           //Mouse status; x= Mouse X coordinate; y= Mouse Y coordinate; mc = Mouse Button Down: 1=MouseButtons.Left; 2=MouseButtons.Right;
        int qual = 1;           //Record quality; Check for input update in ms

        bool record = false;        //true = On record
        bool playback_b = false;    //true = On playback
        bool queue_loop = false;    //true = On loop cooldown
        bool hotkey_playback = false, hotkey_rec = false, hotkey_pause = false; //true = hotkey pressed


        public Form1()
        {
            InitializeComponent();
            ChangeMetroTabMain();
            infoBox = infoTextBox;
            infoBox.Text = "Done(Start). Finished on " + DateTime.Now.ToString();
            infoBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 400;
            this.Width = 800;
            metroTabControl.SelectTab(0);

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
            this.Theme = Storage.colorTheme[Storage.themePointer];
            this.Style = Storage.colorStyle[Storage.themePointer];

            metroTabControl.Theme = Storage.colorTheme[Storage.themePointer];
            metroTabControl.Style = Storage.colorStyle[Storage.themePointer];

            infoTextBox.BackColor = Storage.colorBackgrund[Storage.themePointer];
            infoTextBox.ForeColor = Storage.colorText[Storage.themePointer];

            button_option.Image = Storage.Options;
            button_option.BackColor = Storage.colorBackgrund[Storage.themePointer];
            options = button_option;
        }

        private void LoopState()
        {
            if (playback_b && !record && Storage.loop && !queue_loop && Storage.IsPlaybackLoopFinish() && Storage.isLoopFinish())    
            {
                //If loop is finished
                queue_loop = true;
                Task.Run(() => NextLoop());
            }
        }

        private void NextLoop()
        {
            int timeout = Storage.loopTime; //in ms
            timeout = timeout / 100;
            for (int i = timeout; i > 1; i--)
            {
                if (Storage.STOP_PLAYBACK) return;
                Play.Countdown = i;
                Thread.Sleep(100);
            }
            if (Storage.STOP_PLAYBACK) return;

            queue_loop = false;
            Task.Run(() => StartPlayback());
        }



        //################################################################################################
        //#####################################     Rec functions    #####################################
        //################################################################################################

        private List<Key> GetKeys()
        {
            return keys.GetDownKeys().ToList();
        }

        private long GetDelta()
        {
            stop = DateTime.Now;
            ts = (stop - start);
            start = DateTime.Now;
            return (long)ts.TotalMilliseconds;
        }

        private void AddMouseEvent()
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

            if (mouse_data[rec_pointer].get_pre_mouseClick() != mc || mouse_data[rec_pointer].get_pre_x() != x || mouse_data[rec_pointer].get_pre_y() != y)
            {
                mouse_data[rec_pointer].add(x, y, mc, GetDelta());
            }

        }

        private void MouseDataFinishing()
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

            mouse_data[rec_pointer].add(x, y, mc, GetDelta());
        }


        //##########################################################################################
        //#####################################     Hotkeys    #####################################
        //##########################################################################################

        private void CheckHotkeyPress()
        {
            if (!Storage.NOHOTKEYS)
            {
                if (!record && !playback_b)
                {
                    metro_tab_fix = -1;
                }

                if (Keyboard.IsKeyDown(Storage.key_rec) && pause_now == 0)
                {
                    pause_now = 20;
                    hotkey_rec = true;
                }

                if (Keyboard.IsKeyDown(Storage.key_playback) && pause_now == 0)
                {
                    pause_now = 20;
                    hotkey_playback = true;
                }

                if (Keyboard.IsKeyDown(Storage.key_pause) && pause_now == 0)
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
                    Task.Run(() => StartPlayback());
                }
            }

            if (hotkey_pause && pause_now == 0)
            {
                hotkey_pause = false;

                if (!Storage.isPause())
                {
                    if (!Storage.playback_finish) Storage.paus_request = true;
                }
                else
                {
                    if (!Storage.playback_finish)
                    {
                        Task.Run(() => Storage.Resume());
                    }
                }
            }
        }

        private void StartPlayback()
        {
            Storage.loop = Storage.loopMode;
            Storage.runingPlayback = new PlaybackPlay(Storage.PLAYBACK);
            if (!Storage.STOP_PLAYBACK) Storage.runingPlayback.Start();
        }

        private void StopPlayback()
        {
            Storage.runingPlayback.Stop();
            Task.Run(() => StopPlaybackTask());
            if (Storage.loop) Storage.loop = false;
            pause_now = 20;
            metro_tab_fix = -1;
            playback_b = false;
            ChangeMetroTabMain();
        }

        private void StopPlaybackTask()
        {
            Thread.Sleep(5);
            Storage.STOP_PLAYBACK = true;
            Thread.Sleep(100);
            Storage.STOP_PLAYBACK = false;
        }

        private void StartRec()
        {
            Storage.PLAYBACK.Clear();
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
            MouseDataFinishing();

            Data data = new Data(mouse_data[mouse_data.Count - 1], keyboard_data[keyboard_data.Count - 1]);
            data.Name = mouse_data[mouse_data.Count - 1].getName();
            Storage.data_list.Add(data);
            rec_pointer++;

            ChangeMetroTabMain();
        }

        private void metroTabControl_main_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ChangeMetroTabMain();
        }

        //########################################################################################
        //#####################################     Timer    #####################################
        //########################################################################################

        private void timer_hotkey_press_Tick(object sender, EventArgs e)
        {
            HotkeyOptions();
        }

        private String GetClosingInfo()
        {
            if (Storage.load) return Storage.infoLOADING;
            if (Storage.save) return Storage.infoSAVEING;
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
            LoopState();
            CheckHotkeyPress();

            if (metro_tab_fix >= 0 && metro_tab_fix != metroTabControl.SelectedIndex)
            {
                MetroTabChange(metro_tab_fix);
            }
        }

        private void timer_add_events_Tick(object sender, EventArgs e)
        {
            if (record)
            {
                AddMouseEvent();
                keyboard_data[rec_pointer].inputData(GetKeys());
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

        //###########################################################################################
        //#####################################     UI stuff    #####################################
        //###########################################################################################

        private void MetroTabChange(int index)
        {
            metroTabControl.SelectTab(index);
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



        //##########################################################################################
        //#####################################     Buttons    #####################################
        //##########################################################################################
        private void button_option_Click(object sender, EventArgs e)
        {
            Form dialog = new Settings();
            dialog.ShowDialog();
        }

    }
}
