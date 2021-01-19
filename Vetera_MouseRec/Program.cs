using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    static class Program
    {

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Properties.Settings.Default.ROOTPATH.Length < 1)
            {
                Properties.Settings.Default.ROOTPATH = System.Reflection.Assembly.GetEntryAssembly().Location;
                Properties.Settings.Default.Save();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (Properties.Settings.Default.DARKMODE)
            {
                Cash.theame = 0;
            }
            else Cash.theame = 1;

            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Cash.ArrwoDown);
                Cash.ArrwoDown = image.Start();
            });
            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Cash.A_up);
                Cash.A_up = image.Start();
            });
            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Cash.A_down);
                Cash.A_down = image.Start();
            });
            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Cash.Options);
                Cash.Options = image.Start();
            });

            Cash.smooth_mouse_time_min = Properties.Settings.Default.SMOOTHMIN;
            Cash.smooth_mouse_time_max = Properties.Settings.Default.SMOOTHMAX;
            Cash.loopMode = Properties.Settings.Default.LOOP;

            Cash.loop_time = Properties.Settings.Default.LOOPTIME;
            Cash.key_rec = (Key)Properties.Settings.Default.KEYREC;
            Cash.key_playback = (Key)Properties.Settings.Default.KEYPLAYBACK;
            Cash.key_pause = (Key)Properties.Settings.Default.KEYPAUSE;

            Application.Run(new Form1());
        }
    }
}
