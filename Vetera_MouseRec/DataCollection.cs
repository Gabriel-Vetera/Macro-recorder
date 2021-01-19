using System;
using System.Collections.Generic;

namespace Vetera_MouseRec
{
    public class DataCollection
    {
        public int Schedule { get; set; } = 0;  //Insert!(Ablaufplan)   | 0 = InOrder; 1 = InRandomOrder(NO double picking); 2 = Random (Pick $Random random DataPackages (double picking is possible))
        public int Random { get; set; } = 0;    //Insert!
        public int Type { get; set; }           //REMOVE?
        public String Title { get; set; }
        public String Description { get; set; }
        public List<Data> Data { get; set; } = new List<Data>();

        public int[] PixelVar { get; set; } = new int[2] { 0, 0 };
        public int[] TimeVar { get; set; } = new int[2] { 0, 0 };

        public List<int> Order { get; set; } = new List<int>();

        public DataCollection(List<Data> data, String Title, String Description, int Type)
        {
            Data = data;
            for (int i = 0; i < data.Count; i++)
            {
                Order.Add(i + 1);
            }
            this.Title = Title;
            this.Description = Description;
            this.Type = Type;
        }

        public DataCollection()
        {
        }

    }
}
