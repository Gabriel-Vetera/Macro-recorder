using System.Collections.Generic;

namespace Vetera_MouseRec
{
    public class LoadedData
    {
        public List<DataCollection> Data { get; set; } = new List<DataCollection>();
        public int Position { get; set; }
        public LoadedData(List<DataCollection> Data, int Position)
        {
            this.Data = Data;
            this.Position = Position;

        }
    }
}
