using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Vetera_MouseRec
{
    class Save
    {
        static SQLiteConnection db_conn;
        static SQLiteCommand sqlite_cmd;

        private static String path;
        private List<DataCollection> dataCollections = new List<DataCollection>();

        public Save(DataCollection dataCollection, String Path)
        {
            dataCollections.Clear();
            dataCollections.Add(dataCollection);
            path = Path;
        }

        public Save(DataPlayback dataPlayback, String Path)
        {
            dataCollections.Clear();
            for (int i = 0; i < dataPlayback.dataCollections.Count; i++)
            {
                dataCollections.Add(dataPlayback.dataCollections[i]);
            }

            path = Path;
        }      

        static void Insert_I_Data(DataCollection collection, int IDCollection)
        {
            int schedule = collection.Schedule;
            int random = collection.Random;
            String title = collection.Title;
            String description = collection.Description;
            int pixelMin = collection.PixelVar[0];
            int pixelMax = collection.PixelVar[1];
            int timeMin = collection.TimeVar[0];
            int timeMax = collection.TimeVar[1];

            sqlite_cmd.CommandText = "INSERT INTO DataInfo(CollectionID, Schedule, Random, Title, Description , PixelMin , PixelMax , TimeMin , TimeMax) VALUES(" + IDCollection + ", " + schedule + ", " + random + ", '" + title + "', '" + description + "', " + pixelMin + ", " + pixelMax + ", " + timeMin + ", " + timeMax + "); ";
            sqlite_cmd.ExecuteNonQuery();
        }    

        static void SplitInsert(String InsertText, String[] Values)
        {
            String OutPut = "";
            bool start = true;
            int count = 1;

            for (int i = 0; i < Values.Length; i++)
            {
                if (start)
                {
                    OutPut = InsertText + Values[i];
                    start = false;
                }
                else
                {
                    if (count == 995)
                    {
                        OutPut = OutPut + ", " + Values[i] + ";";
                        sqlite_cmd.CommandText = OutPut;
                        sqlite_cmd.ExecuteNonQuery();

                        start = true;
                        count = 1;
                    }
                    else OutPut = OutPut + ", " + Values[i];
                }
            }

            if (!start)
            {
                OutPut = OutPut + ";";
                sqlite_cmd.CommandText = OutPut;
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        static void InsertDataCollectionNEW(DataCollection collection, int IDCollection)
        {
            Insert_I_Data(collection, IDCollection);
            InsertDataNEW(collection.Data, IDCollection, collection.Order);
        }

        static void InsertDataNEW(List<Data> data, int IDCollection, List<int> PlayOrder)
        {
            List<MouseData> mList = new List<MouseData>();
            List<KeyboardData> kList = new List<KeyboardData>();
            List<String> nList = new List<String>();

            for (int i = 0; i < data.Count; i++)
            {
                mList.Add(data[i].MouseData);
                kList.Add(data[i].KeyboardData);
                nList.Add(data[i].Name);
            }

            Insert_L_DataNEW(nList, IDCollection, PlayOrder);
            Insert_M_DataNEW(mList, IDCollection);
            Insert_K_DataNEW(kList, IDCollection);
        }

        static void Insert_L_DataNEW(List<String> Name, int IDCollection, List<int> PlayOrder)
        {
            String insertText = "INSERT INTO DataList(Name , PlayOrder , ID, CollectionID) VALUES";
            SplitInsert(insertText, Get_L_DataText(Name, PlayOrder, IDCollection));          
        }

        static void Insert_K_DataNEW(List<KeyboardData> keyboard, int IDCollection)
        {
            List<String> OutPut = new List<String>();
            String[] cash;

            String insertText = "INSERT INTO DataKeyboard(KeysINT, Start, Stop ,ItemID, ListID, CollectionID) VALUES";

            for (int i = 0; i < keyboard.Count; i++)
            {
                keyboard[i].finish = true;
                cash = Get_K_DataText(keyboard[i].getKeyboarData(), i, IDCollection);

                foreach (String text in cash)
                {
                    OutPut.Add(text);
                }
            }

            SplitInsert(insertText, OutPut.ToArray());
        }

        static void Insert_M_DataNEW(List<MouseData> mouse, int IDCollection)
        {
            List<String> OutPut = new List<String>();
            String[] cash;

            String insertText = "INSERT INTO DataMouse(X, Y, M, Delay, ItemID, ListID, CollectionID) VALUES";

            for (int i = 0; i < mouse.Count; i++)
            {
                cash = Get_M_DataText(mouse[i].getX(), mouse[i].getY(), mouse[i].getMouseClick(), mouse[i].getDelay(), i, IDCollection);
                foreach (String text in cash)
                {
                    OutPut.Add(text);
                }
            }

            SplitInsert(insertText, OutPut.ToArray());
        }

        static String[] Get_M_DataText(int[] X, int[] Y, int[] M, long[] Delay, int ListID, int CollectionID)
        {
            List<String> OutPut = new List<String>();

            for (int i = 0; i < X.Length; i++)
            {
                OutPut.Add("(" + X[i] + ", " + Y[i] + ", " + M[i] + ", '" + Delay[i] + "', " + i + ", " + ListID + ", " + CollectionID + ")");
            }

            return OutPut.ToArray();
        }

        static String[] Get_K_DataText(List<DataKey> key_list, int ListID, int IDCollection)
        {
            List<String> OutPut = new List<String>();

            for (int i = 0; i < key_list.Count; i++)
            {
                OutPut.Add("(" + (int)key_list[i].getKey() + ", " + key_list[i].getStart() + ", " + key_list[i].getStop() + ", " + i + ", " + ListID + ", " + IDCollection + ")");
            }

            return OutPut.ToArray();
        }


        static String[] Get_L_DataText(List<String> Name, List<int> PlayOrder, int IDCollection)
        {
            List<String> OutPut = new List<String>();            

            for (int i = 0; i < Name.Count; i++)
            {
                OutPut.Add("('" + Name[i] + "', " + PlayOrder[i] + ", " + i + ", " + IDCollection + ")");
            }

            return OutPut.ToArray();
        }

        public void Start()
        {
            Storage.save = true;
            if (Form1.infoBox.InvokeRequired) Form1.infoBox.Invoke((MethodInvoker)delegate { Form1.infoBox.Text = "Save and compress.."; Form1.infoBox.SelectionAlignment = HorizontalAlignment.Center; });
            
            DateTime start = DateTime.Now;

            db_conn = CreateConnection();
            CreateTable();

            for (int i = 0; i < dataCollections.Count; i++)
            {
                InsertDataCollectionNEW(dataCollections[i], i);               
            }

            db_conn.Dispose();            
            DateTime stop = DateTime.Now;
            TimeSpan t;
            t = (stop - start);
            String passtTime = t.TotalSeconds.ToString();

            if (Form1.infoBox.InvokeRequired) Form1.infoBox.Invoke((MethodInvoker)delegate { Form1.infoBox.Text = "Done(Save and compress). Finished in " + passtTime + " s." + DateTime.Now.ToString(); ; Form1.infoBox.SelectionAlignment = HorizontalAlignment.Center; });
            Storage.save = false;
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source = " + path + "; Version = 3; New = True; Compress = True; ");
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

        static void CreateTable()
        {        
            string CreateInfo = "CREATE TABLE DataInfo(CollectionID INT, Schedule INT, Random INT, Title TEXT, Description TEXT, PixelMin INT, PixelMax INT, TimeMin INT, TimeMax INT)";
            string CreateList = "CREATE TABLE DataList(Name TEXT, PlayOrder INT, ID INT, CollectionID INT)";
            string CreateData = "CREATE TABLE DataMouse(X INT, Y INT, M INT, Delay BIGINT, ItemID INT, ListID INT, CollectionID INT)";
            string CreateDataKeyboard = "CREATE TABLE DataKeyboard(KeysINT INT, Start BIGINT, Stop BIGINT, ItemID INT, ListID INT, CollectionID INT)";
            sqlite_cmd = db_conn.CreateCommand();

            sqlite_cmd.CommandText = CreateInfo;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = CreateList;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = CreateData;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = CreateDataKeyboard;
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
