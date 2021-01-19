using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    public class KeyboardData
    {

        List<Key> keys_down_pre = new List<Key>();

        List<KeyData> key = new List<KeyData>();

        DateTime time_start = DateTime.Now;
        DateTime time_stop = DateTime.Now;
        TimeSpan ts;
        public bool finish { get; set; } = false;

        public KeyboardData()
        {
            time_start = DateTime.Now;
        }

        public void setStopp()
        {

            time_stop = DateTime.Now;
            time_start = DateTime.Now;

        }

        public void RemoveLast()
        {

            key.RemoveAt(key.Count - 1);

        }

        public List<KeyData> getKeyboarData()
        {
            if (!finish)
            {
                finish = true;
                RemoveLast();
            }
            return key;

        }

        public void inputData(List<Key> keys_now)
        {

            if (!compareKeys(keys_now))
            {
                addNewPress(getNewKeys(keys_now));
                addStop(getLostKeys(keys_now));

            }

            keys_down_pre = keys_now;
        }

        private void addNewPress(List<Key> add_keys)
        {
            foreach (Key key in add_keys)
            {
                this.key.Add(new KeyData(key, getTime()));
            }
        }

        private void addStop(List<Key> add_keys)
        {
            long stop_time = getTime();
            int size = key.Count - 1;
            foreach (Key key in add_keys)
            {

                for (int i = size; i > 0; i--)
                {
                    if (this.key[i].getKey() == key)
                    {
                        long stopTime = stop_time - this.key[i].getStart();
                        this.key[i].setStop(stopTime);
                        break;
                    }

                }
            }
        }

        private long getTime()
        {
            time_stop = DateTime.Now;
            ts = (time_stop - time_start);
            return (long)ts.TotalMilliseconds;

        }

        public long getKeyLength()
        {
            return key.Count;

        }

        public void AddData(KeyData data)
        {
            key.Add(data);

        }


        private List<Key> getNewKeys(List<Key> keys)
        {
            return keys.Except(keys_down_pre).ToList();

        }

        private bool compareKeys(List<Key> keys)
        {
            bool one = !keys_down_pre.Except(keys).Any();
            bool two = !keys.Except(keys_down_pre).Any();
            if (!one || !two)
            {
                return false;
            }
            else return true;
        }

        private List<Key> getLostKeys(List<Key> keys)
        {
            return keys_down_pre.Except(keys).ToList();
        }









    }
}
