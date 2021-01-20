using System;
using System.Collections.Generic;

namespace Vetera_MouseRec
{
    public class MouseData
    {
        public List<int> x { get; set; } = new List<int>();
        public List<int> y { get; set; } = new List<int>();
        List<int> mouse_click = new List<int>(); //0=kein,1=links,2=rechts
        public List<long> delay { get; set; } = new List<long>();
        string name;



        public MouseData()
        {
            name = "Data " + DateTime.Now.ToString();
        }


        public void add(int x, int y, int mouse_click, long delay)
        {
            this.x.Add(x);
            this.y.Add(y);
            this.delay.Add(delay);
            this.mouse_click.Add(mouse_click);

        }


        public String getName()
        {
            return name;

        }

        public void setName(String new_name)
        {
            name = new_name;

        }

        public int get_pre_x()
        {
            return x[x.Count - 1];
        }

        public int get_pre_y()
        {
            return y[y.Count - 1];
        }

        public int get_pre_mouseClick()
        {
            return mouse_click[mouse_click.Count - 1];
        }


        public int[] getX()
        {
            return x.ToArray();
        }

        public int[] getY()
        {
            return y.ToArray();
        }

        public int[] getMouseClick()
        {
            return mouse_click.ToArray();
        }

        public long[] getDelay()
        {
            return delay.ToArray();
        }



    }
}
