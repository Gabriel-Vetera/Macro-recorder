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
                Storage.themePointer = 0;
            }
            else Storage.themePointer = 1;

            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Storage.ArrwoDown);
                Storage.ArrwoDown = image.Start();
            });
            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Storage.AUp);
                Storage.AUp = image.Start();
            });
            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Storage.ADown);
                Storage.ADown = image.Start();
            });
            Task.Run(() =>
            {
                ChangeImageColor image = new ChangeImageColor(Storage.Options);
                Storage.Options = image.Start();
            });

            Storage.smoothMouseTimeMin = Properties.Settings.Default.SMOOTHMIN;
            Storage.smoothMouseTimeMax = Properties.Settings.Default.SMOOTHMAX;
            Storage.loopMode = Properties.Settings.Default.LOOP;

            Storage.loopTime = Properties.Settings.Default.LOOPTIME;
            Storage.key_rec = (Key)Properties.Settings.Default.KEYREC;
            Storage.key_playback = (Key)Properties.Settings.Default.KEYPLAYBACK;
            Storage.key_pause = (Key)Properties.Settings.Default.KEYPAUSE;

            Application.Run(new Form1());
        }
    }
}
