using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    public class SimulateKeyboard
    {
        List<Key> keys = new List<Key>();
        List<long> keys_start = new List<long>();
        List<long> keys_stop = new List<long>();

        DateTime keyboarstart;
        DateTime keyboarstop;
        TimeSpan keyboartTs;

        public SimulateKeyboard(KeyboardData recKeyboard)
        {
            foreach (DataKey data in recKeyboard.getKeyboarData())
            {
                keys.Add(data.getKey());
                keys_start.Add(data.getStart());
                keys_stop.Add(data.getStop());
            }
        }

        public void StartSim()
        {
            runRecordKeyboard();
            Storage.paus_k = true;
            Storage.wait_for_paus_k = false;
            Storage.keyboard_finish = true;
        }

        private long getKeyboartTime()
        {
            keyboarstop = DateTime.Now;
            keyboartTs = (keyboarstop - keyboarstart);
            return (long)keyboartTs.TotalMilliseconds;
        }

        private void runRecordKeyboard()
        {
            Storage.keyboard_finish = false;
            keyboarstart = DateTime.Now;
            long time = 0; ;
            long last_keyboard_time = 0;
            int key_size;
            key_size = keys.Count;

            while (key_size != 0 && !Storage.STOP_PLAYBACK)
            {
                if (!Storage.isPause())
                {
                    key_size = keys.Count;
                    time = getKeyboartTime() + last_keyboard_time;

                    for (int i = 0; i < key_size; i++)
                    {
                        if (time >= keys_start[i])
                        {
                            performKeyboardEvent(i);
                            removeKey(i);
                            Play.KeyboardItems++;
                            break;
                        }
                    }

                    if (!Storage.wait_for_paus_m && Storage.isKeyboardReadyForPause() && Storage.paus_request)
                    {
                        Storage.paus_k = true;
                    }
                }
                else
                {
                    Storage.paus_k = true;
                    last_keyboard_time = time;
                    keyboarstart = DateTime.Now;
                }
                Thread.Sleep(1);
            }

        }


        private void removeKey(int index)
        {
            keys.RemoveAt(index);
            keys_start.RemoveAt(index);
            keys_stop.RemoveAt(index);
        }

        private void performKeyboardEvent(int index)
        {
            new SimulateKeyPress(keys_stop[index], keys[index]);
        }

    }
}
