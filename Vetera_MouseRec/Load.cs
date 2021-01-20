using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Windows.Input;

namespace Vetera_MouseRec
{
    class Load
    {
        SQLiteDataReader sqlite_datareader;
        SQLiteConnection db_conn;
        SQLiteCommand sqlite_cmd;

        DataInfo dataInfo = new DataInfo();
        DataList dataList = new DataList();

        DataMouse dataMouse = new DataMouse();
        DataKeyboard dataKeyboard = new DataKeyboard();



        public Load()
        {

        }

        public List<DataCollection> GetData(String Path)
        {
            if (Form1.infoBox.InvokeRequired) Form1.infoBox.Invoke((MethodInvoker)delegate { Form1.infoBox.Text = "Load data.."; Form1.infoBox.SelectionAlignment = HorizontalAlignment.Center; });

            List<DataCollection> OutPut = new List<DataCollection>();

            db_conn = CreateConnection(Path);        
            sqlite_cmd = db_conn.CreateCommand();   

            sqlite_cmd.CommandText = "SELECT COUNT(*) FROM DataInfo";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            sqlite_datareader.Read();
            int size = sqlite_datareader.GetInt32(0);
            sqlite_datareader.Close();


            Read();
            for (int i = 0; i < size; i++)
            {
                OutPut.Add(GetCollectionNEW(i));
            }

            return OutPut;

        }


        SQLiteConnection CreateConnection(String Path)
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source = " + Path + ";");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {

            }

            return sqlite_conn;
        }

        void Read()
        {
            GetDataInfo();
            GetDataList();
            GetDataMouse();
            GetDataKeyboard();
        }

        DataCollection GetCollectionNEW(int IdCollection)
        {
            DataCollection OutPut = new DataCollection();

            int size = dataList.Size(IdCollection);

            for (int i = 0; i < size; i++)
            {
                OutPut.Data.Add(GetDataNEW((i + 1), IdCollection));
                OutPut.Order.Add(i + 1);
            }

            String[] data = dataInfo.Get(IdCollection);

            OutPut.Schedule = int.Parse(data[0]);
            OutPut.Random = int.Parse(data[1]);
            OutPut.Title = data[2];
            OutPut.Description = data[3];
            OutPut.PixelVar[0] = int.Parse(data[4]);
            OutPut.PixelVar[1] = int.Parse(data[5]);
            OutPut.TimeVar[0] = int.Parse(data[6]);
            OutPut.TimeVar[1] = int.Parse(data[7]);

            return OutPut;
        }

        Data GetDataNEW(int PlayOrder, int IdCollection)
        {
            String[] data = dataList.Get(PlayOrder, IdCollection);
            String name = data[0];
            int IdList = int.Parse(data[1]);

            Data OutPut = new Data(dataMouse.Get(IdList, IdCollection), dataKeyboard.Get(IdList, IdCollection));
            OutPut.Name = name;

            return OutPut;
        }

        void GetDataInfo()
        {

            sqlite_cmd.CommandText = "SELECT * FROM DataInfo";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {
                    String Title = (String)sqlite_datareader["Title"];
                    String Description = (String)sqlite_datareader["Description"];

                    int CollectionID = (int)sqlite_datareader["CollectionID"];
                    int Schedule = (int)sqlite_datareader["Schedule"];
                    int Random = (int)sqlite_datareader["Random"];

                    int PixelMin = (int)sqlite_datareader["PixelMin"];
                    int PixelMax = (int)sqlite_datareader["PixelMax"];

                    int TimeMin = (int)sqlite_datareader["TimeMin"];
                    int TimeMax = (int)sqlite_datareader["TimeMax"];

                    dataInfo.Add(Title, Description, CollectionID, Schedule, Random, PixelMin, PixelMax, TimeMin, TimeMax);
                }
            }
            sqlite_datareader.Close();
        }

        void GetDataList()
        {
            sqlite_cmd.CommandText = "SELECT * FROM DataList";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {
                    String Name = (String)sqlite_datareader["Name"];

                    int PlayOrder = (int)sqlite_datareader["PlayOrder"];
                    int ID = (int)sqlite_datareader["ID"];
                    int CollectionID = (int)sqlite_datareader["CollectionID"];

                    dataList.Add(Name, PlayOrder, ID, CollectionID);
                }
            }
            sqlite_datareader.Close();

        }

        void GetDataMouse()
        {

            sqlite_cmd.CommandText = "SELECT * FROM DataMouse";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {

                    int X = (int)sqlite_datareader["X"];
                    int Y = (int)sqlite_datareader["Y"];
                    int M = (int)sqlite_datareader["M"];

                    long Delay = (long)sqlite_datareader["Delay"];
                    int ItemID = (int)sqlite_datareader["ItemID"];

                    int ListID = (int)sqlite_datareader["ListID"];
                    int CollectionID = (int)sqlite_datareader["CollectionID"];

                    dataMouse.Add(X, Y, M, Delay, ItemID, ListID, CollectionID);
                }
            }
            sqlite_datareader.Close();

        }

        void GetDataKeyboard()
        {

            sqlite_cmd.CommandText = "SELECT * FROM DataKeyboard";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            if (sqlite_datareader.HasRows)
            {
                while (sqlite_datareader.Read())
                {

                    int KeysINT = (int)sqlite_datareader["KeysINT"];
                    long Start = (long)sqlite_datareader["Start"];
                    long Stop = (long)sqlite_datareader["Stop"];

                    int ItemID = (int)sqlite_datareader["ItemID"];
                    int ListID = (int)sqlite_datareader["ListID"];
                    int CollectionID = (int)sqlite_datareader["CollectionID"];

                    dataKeyboard.Add(KeysINT, Start, Stop, ItemID, ListID, CollectionID);
                }
            }
            sqlite_datareader.Close();

        }
    }

    class DataInfo
    {
        List<String> Title_List = new List<string>();
        List<String> Description_List = new List<string>();

        List<int> CollectionID_List = new List<int>();
        List<int> Schedule_List = new List<int>();
        List<int> Random_List = new List<int>();
        List<int> PixelMin_List = new List<int>();
        List<int> PixelMax_List = new List<int>();
        List<int> TimeMin_List = new List<int>();
        List<int> TimeMax_List = new List<int>();

        public void Add(String Title, String Description, int CollectionID, int Schedule, int Random, int PixelMin, int PixelMax, int TimeMin, int TimeMax)
        {
            Title_List.Add(Title);
            Description_List.Add(Description);
            CollectionID_List.Add(CollectionID);
            Schedule_List.Add(Schedule);
            Random_List.Add(Random);
            PixelMin_List.Add(PixelMin);
            PixelMax_List.Add(PixelMax);
            TimeMin_List.Add(TimeMin);
            TimeMax_List.Add(TimeMax);
        }

        int GetPointer(int CollectionID)
        {
            int NotFound = -1;

            for (int i = 0; i < CollectionID_List.Count; i++)
            {

                if (CollectionID_List[i] == CollectionID) return i;

            }

            return NotFound;
        }

        public String[] Get(int CollectionID)
        {
            int pointer = GetPointer(CollectionID);
            String[] OutPut = new String[8];

            OutPut[0] = Schedule_List[pointer].ToString();
            OutPut[1] = Random_List[pointer].ToString();
            OutPut[2] = Title_List[pointer];
            OutPut[3] = Description_List[pointer];
            OutPut[4] = PixelMin_List[pointer].ToString();
            OutPut[5] = PixelMax_List[pointer].ToString();
            OutPut[6] = TimeMin_List[pointer].ToString();
            OutPut[7] = TimeMax_List[pointer].ToString();

            return OutPut;
        }
    }


    class DataList
    {
        List<String> Name_List = new List<string>();
        List<int> PlayOrder_List = new List<int>();

        List<int> ID_List = new List<int>();
        List<int> CollectionID_List = new List<int>();

        public void Add(String Name, int PlayOrder, int ID, int CollectionID)
        {
            Name_List.Add(Name);
            PlayOrder_List.Add(PlayOrder);
            ID_List.Add(ID);
            CollectionID_List.Add(CollectionID);
        }

        public int Size(int IdCollection)
        {
            int OutPut = 0;

            for (int i = 0; i < CollectionID_List.Count; i++)
            {
                if (CollectionID_List[i] == IdCollection) OutPut++;
            }

            return OutPut;
        }

        int GetPointer(int PlayOrder, int IdCollection)
        {
            int NotFound = -1;

            for (int i = 0; i < PlayOrder_List.Count; i++)
            {
                if (PlayOrder_List[i] == PlayOrder)
                {
                    if (CollectionID_List[i] == IdCollection) return i;
                }
            }

            return NotFound;
        }


        public String[] Get(int PlayOrder, int IdCollection)
        {
            String[] OutPut = new String[2];

            int pointer = GetPointer(PlayOrder, IdCollection);
            String name = Name_List[pointer];
            int IdList = ID_List[pointer];
            OutPut[0] = name;
            OutPut[1] = IdList.ToString();

            return OutPut;
        }
    }


    class DataMouse
    {

        List<int> CollectionID_List = new List<int>();
        List<int> ItemID_List = new List<int>();
        List<int> ListID_List = new List<int>();

        List<int> X_List = new List<int>();
        List<int> Y_List = new List<int>();
        List<int> M_List = new List<int>();
        List<long> Delay_List = new List<long>();
        public void Add(int X, int Y, int M, long Delay, int ItemID, int ListID, int CollectionID)
        {
            X_List.Add(X);
            Y_List.Add(Y);
            M_List.Add(M);
            Delay_List.Add(Delay);

            ItemID_List.Add(ItemID);
            ListID_List.Add(ListID);
            CollectionID_List.Add(CollectionID);
        }

        int Count(int IdList, int IdCollection)
        {
            int OutPut = 0;

            for (int i = 0; i < CollectionID_List.Count; i++)
            {
                if (CollectionID_List[i] == IdCollection && ListID_List[i] == IdList) OutPut++;

            }

            return OutPut;
        }

        int GetPointer(int IdList, int IdCollection, int ItemID)
        {
            int NotFound = -1;

            for (int i = 0; i < ItemID_List.Count; i++)
            {

                if (ItemID_List[i] == ItemID)
                {
                    if (CollectionID_List[i] == IdCollection)
                    {
                        if (ListID_List[i] == IdList) return i;
                    }
                }
            }

            return NotFound;
        }

        public MouseData Get(int IdList, int IdCollection)
        {
            MouseData OutPut = new MouseData();


            int size = Count(IdList, IdCollection);

            for (int i = 0; i < size; i++)
            {
                int pointer = GetPointer(IdList, IdCollection, i);
                OutPut.add(X_List[pointer], Y_List[pointer], M_List[pointer], Delay_List[pointer]);
            }

            return OutPut;
        }

    }

    class DataKeyboard
    {

        List<int> CollectionID_List = new List<int>();
        List<int> ItemID_List = new List<int>();
        List<int> ListID_List = new List<int>();

        List<int> KeysINT_List = new List<int>();
        List<long> Start_List = new List<long>();
        List<long> Stop_List = new List<long>();

        public void Add(int KeysINT, long Start, long Stop, int ItemID, int ListID, int CollectionID)
        {
            KeysINT_List.Add(KeysINT);
            Start_List.Add(Start);
            Stop_List.Add(Stop);

            ItemID_List.Add(ItemID);
            ListID_List.Add(ListID);
            CollectionID_List.Add(CollectionID);
        }

        int Count(int IdList, int IdCollection)
        {
            int OutPut = 0;

            for (int i = 0; i < CollectionID_List.Count; i++)
            {
                if (CollectionID_List[i] == IdCollection) if (ListID_List[i] == IdList) OutPut++;

            }

            return OutPut;
        }

        int GetPointer(int IdList, int IdCollection, int ItemID)
        {
            int NotFound = -1;

            for (int i = 0; i < ItemID_List.Count; i++)
            {

                if (ItemID_List[i] == ItemID)
                {
                    if (CollectionID_List[i] == IdCollection)
                    {
                        if (ListID_List[i] == IdList) return i;
                    }
                }
            }

            return NotFound;
        }

        public KeyboardData Get(int IdList, int IdCollection)
        {
            KeyboardData OutPut = new KeyboardData();


            int size = Count(IdList, IdCollection);

            List<Key> keys_list = new List<Key>();
            List<long> keys_start = new List<long>();
            List<long> keys_stop = new List<long>();


            for (int i = 0; i < size; i++)
            {
                int pointer = GetPointer(IdList, IdCollection, i);

                keys_list.Add((Key)KeysINT_List[pointer]);
                keys_start.Add(Start_List[pointer]);
                keys_stop.Add(Stop_List[pointer]);

            }

            for (int i = 0; i < keys_list.Count; i++)
            {
                DataKey keyboard = new DataKey(keys_list[i], keys_start[i]);
                keyboard.setStop(keys_stop[i]);
                OutPut.AddData(keyboard);

            }

            return OutPut;
        }
    }

}
