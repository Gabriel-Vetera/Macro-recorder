using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    public class SimulateKeyPress
    {


        [DllImport("user32.dll")] static extern short VkKeyScan(char ch);
        // Import the user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        // Declare some keyboard keys as constants with its respective code
        // See Virtual Code Keys: https://msdn.microsoft.com/en-us/library/dd375731(v=vs.85).aspx
        public const int KEYEVENTF_EXTENDEDKEY = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_RCONTROL = 0xA3; //Right Control key code
        public const int VK_LCONTROL = 0xA2; //Left Control key code
        public const int VK_LSHIFT = 0xA0;
        public const int VK_RSHIFT = 0xA1;

        byte key;
        long cooldown;

        long cooldown_time = 500;
        long delay;
        long delay_now;
        bool first_press = false;

        DateTime lastCooldown;
        DateTime start;
        DateTime stop;
        TimeSpan ts;
        Thread t;
        public SimulateKeyPress(long delay, Key keys_key)
        {
            key = (byte)KeyInterop.VirtualKeyFromKey(keys_key);
            lastCooldown = DateTime.Now;

            this.delay = delay;


            t = new Thread(new ThreadStart(runRecordKeyboard));
            if (keys_key == Key.LeftShift || keys_key == Key.RightShift)
            {
                t = new Thread(new ThreadStart(runShift));
            }
            else if (keys_key == Key.LeftCtrl)
            {
                t = new Thread(new ThreadStart(runCtrl));
            }

            t.Start();

        }


        private void runShift()
        {
            start = DateTime.Now;
            Cash.wait_for_paus_k = true;
            while (delay >= delay_now)
            {
                stop = DateTime.Now;
                ts = (stop - start);
                delay_now = (long)ts.TotalMilliseconds;
                if (!first_press)
                {
                    keybd_event(key, 0, KEYEVENTF_EXTENDEDKEY, 0);
                    first_press = true;
                }
                Thread.Sleep(3);
            }
            keybd_event(VK_LSHIFT, 0, KEYEVENTF_KEYUP, 0);
            keybd_event(VK_RSHIFT, 0x45, KEYEVENTF_KEYUP, 0);
            Cash.wait_for_paus_k = false;
        }

        private void runCtrl()
        {
            start = DateTime.Now;
            Cash.wait_for_paus_k = true;
            while (delay >= delay_now)
            {
                stop = DateTime.Now;
                ts = (stop - start);
                delay_now = (long)ts.TotalMilliseconds;
                if (!first_press)
                {
                    keybd_event(VK_LCONTROL, 0x9d, 0, 0);
                    first_press = true;
                }

                Thread.Sleep(3);
            }
            keybd_event(VK_LCONTROL, 0x9d, KEYEVENTF_KEYUP, 0);
            Cash.wait_for_paus_k = false;
        }

        private void runRecordKeyboard()
        {
            start = DateTime.Now;
            Cash.wait_for_paus_k = true;
            while (delay >= delay_now)
            {
                stop = DateTime.Now;
                ts = (stop - start);
                delay_now = (long)ts.TotalMilliseconds;

                if (first_press)
                {
                    cooldown = getCooldown();
                    if (cooldown >= cooldown_time)
                    {
                        lastCooldown = DateTime.Now;
                        cooldown_time = 33;


                        keybd_event(key, 0x45, 0, 0);
                        keybd_event(key, 0x45, KEYEVENTF_KEYUP, 0);


                    }
                }
                else
                {
                    lastCooldown = DateTime.Now;
                    keybd_event(key, 0x45, 0, 0);
                    keybd_event(key, 0x45, KEYEVENTF_KEYUP, 0);
                    first_press = true;
                }
                Thread.Sleep(1);
            }
            keybd_event(key, 0x45, KEYEVENTF_KEYUP, 0);
            Cash.wait_for_paus_k = false;
        }
        private long getCooldown()
        {
            DateTime cooldown_stop = DateTime.Now;
            TimeSpan cooldown_timespan = (cooldown_stop - lastCooldown);
            return (long)cooldown_timespan.TotalMilliseconds;
        }


    }
}
