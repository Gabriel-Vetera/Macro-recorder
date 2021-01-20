using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    class SmoothMouseLoop
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        public SmoothMouseLoop(int x, int y)
        {
            Smooth(x, y);
        }


        public void Smooth(int x, int y)
        {

            Storage.smoothMouseTime = GetTime(x, y);

            Play.SmoothText = Storage.smoothMouseTime.ToString();
            Play.SmoothMode = true;
            bool timeout, stop, completed;
            float speed_x = GetSpeed(Cursor.Position.X, x);
            float speed_y = GetSpeed(Cursor.Position.Y, y);
            int new_x;
            int new_y;
            int ms = 0;


            do
            {
                new_x = GetNewRoundPos(speed_x, ms);
                new_y = GetNewRoundPos(speed_y, ms);

                SetCursorPos(x + new_x, y + new_y);     // Move mouse

                timeout = (ms > (Storage.smoothMouseTime + 10));
                completed = (x == Cursor.Position.X || y == Cursor.Position.Y);
                stop = Storage.STOP_PLAYBACK;

                ms++;
                Thread.Sleep(1);
            } while (!timeout && !completed && !stop);
            Play.SmoothMode = false;
        }

        private int GetTime(int x, int y)
        {
            int screen_whith = SystemInformation.VirtualScreen.Width;
            int screen_height = SystemInformation.VirtualScreen.Height;
            int distance_max = (int)(Math.Sqrt((screen_whith * screen_whith) + (screen_height * screen_height)));

            int mouse_whith = Math.Abs(x - Cursor.Position.X);
            int mouse_height = Math.Abs(y - Cursor.Position.Y);
            int distance = (int)(Math.Sqrt((mouse_whith * mouse_whith) + (mouse_height * mouse_height)));
            return Remap(distance, 0, distance_max, Storage.smoothMouseTimeMin, Storage.smoothMouseTimeMax);
        }

        private float GetSpeed(int start, int end)      //return pixel/ms
        {
            int distance = start - end;
            return ((float)distance / (float)Storage.smoothMouseTime);

        }

        private int GetNewRoundPos(float speed, int ms)     // return pixel
        {
            return (int)(speed * (Storage.smoothMouseTime - ms));
        }

        public int Remap(float value, float from1, float to1, float from2, float to2)
        {
            float OutPut = (value - from1) / (to1 - from1) * (to2 - from2) + from2;
            return (int)OutPut;
        }

    }
}
