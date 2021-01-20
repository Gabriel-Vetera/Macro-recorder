using System;

namespace Vetera_MouseRec
{
    public class Data
    {

        public String Name { get; set; }
        public MouseData MouseData { get; set; }
        public KeyboardData KeyboardData { get; set; }
        public Data(MouseData mouseData, KeyboardData keyboarddata)
        {
            this.MouseData = mouseData;
            this.KeyboardData = keyboarddata;
        }

    }
}
