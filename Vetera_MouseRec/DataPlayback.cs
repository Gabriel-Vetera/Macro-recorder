using System.Collections.Generic;

namespace Vetera_MouseRec
{
    public class DataPlayback
    {
        public List<DataCollection> dataCollections { get; set; } = new List<DataCollection>();
        public DataPlayback(List<DataCollection> DataCollections)
        {
            dataCollections = DataCollections;
        }

        public DataPlayback()
        {
        }

        public void Clear()
        {
            dataCollections.Clear();
        }

    }


}
