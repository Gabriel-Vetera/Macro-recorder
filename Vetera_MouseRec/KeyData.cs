using System.Windows.Input;

namespace Vetera_MouseRec
{

    public class KeyData
    {

        Key key;
        long start;
        long stop;
        public KeyData(Key key, long start)
        {
            this.key = key;
            this.start = start;

        }

        public void setStop(long stop)
        {
            this.stop = stop;
        }

        public long getStart()
        {
            return start;

        }

        public long getStop()
        {
            return stop;

        }

        public Key getKey()
        {
            return key;

        }

    }
}
