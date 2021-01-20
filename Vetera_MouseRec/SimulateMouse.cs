using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Vetera_MouseRec
{
    public class SimulateMouse
    {

        //#####################################################################################################################
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_MOVE = 0x0001;

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        //#####################################################################################################################

        MouseData mouseData;
        int[] x_arr, y_arr, mouse_click_arr;
        long[] delay_arr_mouse;

        int mouse_button_pre = 0;
        int mouse_button;
        int x;
        int y;

        public SimulateMouse(MouseData mouseData)
        {
            this.mouseData = mouseData;
            x_arr = this.mouseData.getX();
            y_arr = this.mouseData.getY();
            mouse_click_arr = this.mouseData.getMouseClick();
            delay_arr_mouse = this.mouseData.getDelay();
        }

        public void StartSim()
        {
            runRecordMouse();
        }

        private void runRecordMouse()
        {

            DateTime start = DateTime.Now;
            DateTime stop;
            TimeSpan ts;

            long time = 0;

            long waited_delay = 0;
            int count = 0;
            int max = x_arr.Length;
            long delay = delay_arr_mouse[count];

            while (count < max && !Storage.STOP_PLAYBACK)
            {
                if (!Storage.isPause())
                {

                    stop = DateTime.Now;
                    ts = (stop - start);
                    time = (long)ts.TotalMilliseconds + waited_delay;

                    if (delay <= time)
                    {
                        waited_delay = 0;
                        performMouseEvent(count);
                        Play.MouseItems++;
                        count++;
                        if (count != max) delay = delay_arr_mouse[count];
                        start = DateTime.Now;
                    }

                    if (Storage.isKeyboardReadyForPause() && !Storage.wait_for_paus_m && Storage.paus_request)
                    {
                        Storage.paus_m = true;
                    }
                }
                else
                {
                    waited_delay = time;
                    Storage.x_mouse = x_arr[count - 1];
                    Storage.y_mouse = y_arr[count - 1];
                    start = DateTime.Now;
                }

                Thread.Sleep(1);
            }

            Storage.playback_finish = true;
        }

        private void performMouseEvent(int pos)
        {

            mouse_button = mouse_click_arr[pos];
            x = x_arr[pos];
            y = y_arr[pos];

            if (mouse_button_pre != mouse_button && mouse_button_pre == 1)
            {
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
            if (mouse_button_pre != mouse_button && mouse_button_pre == 2) mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);

            switch (mouse_button)
            {
                case 0:
                    Storage.wait_for_paus_m = false;
                    SetCursorPos(x, y); //move
                    break;

                case 1:
                    Storage.wait_for_paus_m = true;
                    if (mouse_button_pre == mouse_button)
                    {
                        Drag(x_arr[pos - 1], y_arr[pos - 1], x, y); //left Click drag
                    }
                    else
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0); //left Click
                    }

                    break;

                case 2:
                    Storage.wait_for_paus_m = false;
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0); //right Click
                    break;
            }

            mouse_button_pre = mouse_button;
        }

        private static void Drag(int xStart, int yStart, int x, int y)
        {
            x = x - xStart;
            y = y - yStart;
            SetCursorPos(xStart, yStart);
            mouse_event(MOUSEEVENTF_MOVE, x, y, 0, 0);
        }


    }
}
