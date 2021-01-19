using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    public static class Cash
    {
        //################################################################################################################################
        //#########################################                 Text                    ##############################################
        //################################################################################################################################

        //ClosingInfo.cs
        public static String infoLOADING = "A File is loading in the backgrund.\n\nAre you sure to close this application?";
        public static String infoSAVEING = "Data is saving in the backgrund.\n\nAre you sure to close this application?";

        //Settings.cs
        public static String infoBoxTheamChange = "You neet to restart to change the theam";

        //Play.cs
        public static String infoWaitForPause = "Wait for best moment to pause..";
        public static String infoNextLoopStartIn = "Next Loop in.. ";
        public static String infoPause = "Pause.. (Press " + key_pause.ToString() + " to resume)\n";
        public static String infoSmooth = "Smooht transition for ";


        //################################################################################################################################

        static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDataCollectionItem));

        public static Bitmap ArrwoDown = (Bitmap)resources.GetObject("pictureBox_DropDown.Image");
        public static Bitmap A_up = (Bitmap)resources.GetObject("button_up.Image");
        public static Bitmap A_down = (Bitmap)resources.GetObject("button_down.Image");
        public static Bitmap _options = (Bitmap)resources.GetObject("button_options.Image");
        public static Bitmap Options = (Bitmap)resources.GetObject("button_options.Image");
        /* public static Bitmap Options {
             get { return _options; }
             set { 
                 _options = value;
                 //Form1.options.Image = _options;

             }
         }*/

        public static Bitmap ChangeColor(Bitmap bmp)
        {
            Graphics g = Graphics.FromImage(bmp);



            // Set the image attribute's color mappings
            ColorMap[] colorMap = new ColorMap[1];
            colorMap[0] = new ColorMap();
            colorMap[0].OldColor = Color.FromArgb(255, 0, 0, 0);
            colorMap[0].NewColor = Cash.color_text[Cash.theame];
            ImageAttributes attr = new ImageAttributes();
            attr.SetRemapTable(colorMap);
            // Draw using the color map
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            g.DrawImage(bmp, rect, 0, 0, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
            return bmp;

        }

        //###################################################################################
        //###########################     Public Settings     ###############################
        //###################################################################################

        public static int smooth_mouse_time;  //In ms
        public static int smooth_mouse_time_min = 100;  //In ms
        public static int smooth_mouse_time_max = 1000;  //In ms

        public static bool loop = true;
        public static int loop_time = 6000;

        //###########################################################################

        //###########################################################################
        //###########################     Theames     ###############################
        //###########################################################################

        public static int theame = 1;
        public static Color color_1 = Color.FromArgb(0, 255, 0);

        public static Color[] color_button = new Color[]{
            Color.FromArgb(50,50,50),
             Color.FromArgb(180,180,180)
        };

        public static Color[] color_item_backgrund = new Color[]{
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(210, 210, 210)

        };

        public static Color[] color_contrast = new Color[]{
            Color.FromArgb(124, 65, 153),
            Color.FromArgb(0, 170, 173)
        };

        public static Color[] color_backgrund = new Color[]{
            Color.FromArgb(17, 17, 17),
             Color.FromArgb(255, 255, 255)
        };

        public static Color[] color_text = new Color[]{
            Color.FromArgb( 188, 188, 188),
            Color.FromArgb( 1, 1, 1)
        };

        public static Color[] color_hint = new Color[]{
            Color.FromArgb( 100, 100, 100),
            Color.FromArgb( 100, 100, 100)
        };

        public static MetroFramework.MetroThemeStyle[] color_theme = new MetroFramework.MetroThemeStyle[]{
            MetroFramework.MetroThemeStyle.Dark,
            MetroFramework.MetroThemeStyle.Light
        };

        public static MetroFramework.MetroColorStyle[] color_style = new MetroFramework.MetroColorStyle[]{
            MetroFramework.MetroColorStyle.Purple,
            MetroFramework.MetroColorStyle.Teal
        };

        //#######################################################################################
        //################################      Cash        #####################################
        //#######################################################################################
        public static List<Data> data_list { get; set; } = new List<Data>();
        public static DataPlayback save_playback { get; set; } = new DataPlayback();

        public static bool save = false;
        public static bool load = false;
        public static int load_waiting_list = 0;
        public static DateTime load_start_time;
        public static List<LoadedData> load_cash = new List<LoadedData>();

        //PlayBack
        public static DataPlayback PLAYBACK = new DataPlayback();
        public static int[] pixelVar = new int[] { 0, 0 };
        public static int[] timeVar = new int[] { 0, 0 };

        public static Playback play;
        public static PlaybackPlay runingPlayback = new PlaybackPlay(PLAYBACK);

        public static bool finish = true;
        public static bool loopMode = true;
        //PlayBack END

        //#######################################################################################


        public static bool NOHOTKEYS = false;
        public static Key key_rec = Key.F5;
        public static Key key_playback = Key.F6;
        public static Key key_pause = Key.F7;

        public static bool keyboard_finish = false;
        public static bool paus_k = false;
        public static bool paus_m = false;
        public static bool paus_request = false;
        public static bool wait_for_paus_k = false;
        public static bool wait_for_paus_m = false;
        public static bool STOP_PLAYBACK = false;

        public static int x_mouse = 0;
        public static int y_mouse = 0;

        public static bool playback_finish = true;


        public static bool mode_rec = false;
        public static bool mode_playback = false;

        public static void Resume()
        {
            new SmoothMouseLoop(x_mouse, y_mouse);

            paus_request = false;
            wait_for_paus_k = false;
            wait_for_paus_m = false;
            if (keyboard_finish)
            {
                paus_k = true;
            }
            else paus_k = false;

            paus_m = false;
        }

        public static bool isPause()
        {
            if (keyboard_finish & paus_m) return true;
            if (!keyboard_finish & paus_m & paus_m) return true;
            return false;
        }

        public static bool isKeyboardReadyForPause()
        {
            if (keyboard_finish) return true;
            if (!keyboard_finish & !paus_k) return true;
            return false;
        }


        public static bool isLoopFinish()
        {
            if (playback_finish && Cash.loop) return true;
            return false;


        }

        public static bool IsPlaybackLoopFinish()
        {
            if (finish && loop) return true;
            return false;
        }



    }
}
