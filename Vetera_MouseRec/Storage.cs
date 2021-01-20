using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    public static class Storage
    {
        //################################################################################################################################
        //#########################################                 Text                    ##############################################
        //################################################################################################################################

        //ClosingInfo.cs
        public static String infoLOADING = "A File is loading in the background.\n\nAre you sure you want to close this application?";
        public static String infoSAVEING = "Data is saving in the background.\n\nAre you sure you want to close this application?";

        //Settings.cs
        public static String infoBoxTheamChange = "You need to restart to change the theme";

        //Play.cs
        public static String infoWaitForPause = "Wait for best moment to pause..";
        public static String infoNextLoopStartIn = "Next Loop in.. ";
        public static String infoPause = "Pause.. (Press " + key_pause.ToString() + " to resume)\n";
        public static String infoSmooth = "Smooth transition for ";


        //################################################################################################################################
        //#########################################                 Bitmaps                    ###########################################
        //################################################################################################################################

        static System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDataCollectionItem));

        public static Bitmap ArrwoDown = (Bitmap)resources.GetObject("pictureBox_DropDown.Image");
        public static Bitmap AUp = (Bitmap)resources.GetObject("button_up.Image");
        public static Bitmap ADown = (Bitmap)resources.GetObject("button_down.Image");
        public static Bitmap Options = (Bitmap)resources.GetObject("button_options.Image");

        //######################################################################################################################################
        //#########################################                 Public Settings                    #########################################
        //######################################################################################################################################

        public static int smoothMouseTime;  //In ms
        public static int smoothMouseTimeMin = 100;  //In ms
        public static int smoothMouseTimeMax = 1000;  //In ms

        public static int themePointer = 0;  // 0 =Dark; 1=Light

        public static bool loop = true;
        public static bool loopMode = true;
        public static int loopTime = 6000; //in ms

        //###########################################################################

        //#########################################################################################################
        //#########################################     Color Theames     #########################################
        //#########################################################################################################

        public static Color[] colorButton = new Color[]{
            Color.FromArgb(50,50,50),
             Color.FromArgb(180,180,180)
        };

        public static Color[] colorItemBackgrund = new Color[]{
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(210, 210, 210)
        };

        public static Color[] colorContrast = new Color[]{
            Color.FromArgb(124, 65, 153),
            Color.FromArgb(0, 170, 173)
        };

        public static Color[] colorBackgrund = new Color[]{
            Color.FromArgb(17, 17, 17),
             Color.FromArgb(255, 255, 255)
        };

        public static Color[] colorText = new Color[]{
            Color.FromArgb( 188, 188, 188),
            Color.FromArgb( 1, 1, 1)
        };

        public static Color[] colorHint = new Color[]{
            Color.FromArgb( 100, 100, 100),
            Color.FromArgb( 100, 100, 100)
        };

        public static MetroFramework.MetroThemeStyle[] colorTheme = new MetroFramework.MetroThemeStyle[]{
            MetroFramework.MetroThemeStyle.Dark,
            MetroFramework.MetroThemeStyle.Light
        };

        public static MetroFramework.MetroColorStyle[] colorStyle = new MetroFramework.MetroColorStyle[]{
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

        public static DataPlayback PLAYBACK = new DataPlayback();
        public static int[] pixelVar = new int[] { 0, 0 };
        public static int[] timeVar = new int[] { 0, 0 };

        public static Playback play;
        public static PlaybackPlay runingPlayback = new PlaybackPlay(PLAYBACK);

        public static bool finish = true;        

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
            if (playback_finish && Storage.loop) return true;
            return false;


        }

        public static bool IsPlaybackLoopFinish()
        {
            if (finish && loop) return true;
            return false;
        }


    }
}
