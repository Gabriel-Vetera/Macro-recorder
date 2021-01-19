using System;
using System.Collections.Generic;
using System.Threading;

namespace Vetera_MouseRec
{
    public class PlaybackPlay
    {
        bool stop = false;
        DataPlayback data;
        Random random = new Random();

        public PlaybackPlay(DataPlayback data)
        {
            this.data = data;
            FinishData();
        }

        public void Stop()
        {
            stop = true;
            //Cash.STOP_PLAYBACK = true;
        }

        public void Start()
        {
            stop = false;
            Cash.finish = false;
            for (int i = 0; i < data.dataCollections.Count; i++)
            {
                if (!stop)
                {
                    if (data.dataCollections[i].Schedule == 2)
                    {
                        SendDataRandom(data.dataCollections[i]);

                    }
                    else
                    {
                        SendData(data.dataCollections[i]);
                    }
                }
                else return;
            }

            Cash.finish = true;
        }

        private List<int> CreateRandomOrder(List<int> Order)
        {
            int n1, n2;
            int r1, r2;
            for (int i = 0; i < Order.Count; i++)
            {
                r1 = random.Next(0, Order.Count);

                do
                {
                    r2 = random.Next(0, Order.Count);
                } while (r2 == r1);

                n1 = Order[r1];
                n2 = Order[r2];
                Order[r1] = n2;
                Order[r2] = n1;

            }
            return Order;

        }

        private List<int> CreateRandomOrder(int loopNumber, int size)
        {
            List<int> Order = new List<int>();

            for (int i = 0; i < loopNumber; i++)
            {
                Order.Add(random.Next(1, size));
            }

            return Order;

        }

        private void SendData(DataCollection data)
        {
            bool wait;

            for (int i = 1; i <= data.Order.Count; i++)
            {
                if (!stop)
                {
                    wait = Cash.playback_finish;
                    while (!wait)
                    {
                        if (stop) return;

                        Thread.Sleep(10);
                        wait = Cash.playback_finish;
                    }

                    int pointer = GetDataPointer(data.Order, i);
                    Play(data.Data[pointer], data.Title);
                }
                else return;

            }

        }

        private void SendDataRandom(DataCollection data)
        {
            bool wait;

            for (int i = 0; i < data.Order.Count; i++)
            {
                if (!stop)
                {
                    wait = Cash.isLoopFinish();
                    while (!wait)
                    {
                        Thread.Sleep(10);
                        wait = Cash.isLoopFinish();
                    }

                    //int pointer = GetDataPointer(data.Order, i);
                    Play(data.Data[data.Order[i]], data.Title);
                }
                else return;

            }

        }

        private void Play(Data data, String Title)
        {
            Cash.play = new Playback(data, Title);
            Cash.play.Start();
        }

        private int GetDataPointer(List<int> Order, int number)
        {
            for (int i = 0; i < Order.Count; i++)
            {
                if (Order[i] == number) return i;
            }

            return -1;

        }

        private void FinishData()
        {
            for (int i = 0; i < data.dataCollections.Count; i++)
            {
                if (!stop)
                {

                    if (data.dataCollections[i].Schedule == 1)
                    {
                        data.dataCollections[i].Order = CreateRandomOrder(data.dataCollections[i].Order);
                    }
                    else if (data.dataCollections[i].Schedule == 2)
                    {
                        data.dataCollections[i].Order = CreateRandomOrder(data.dataCollections[i].Random, data.dataCollections[i].Order.Count);
                    }

                    for (int z = 0; z < data.dataCollections[i].Data.Count; z++)
                    {
                        data.dataCollections[i].Data[z].MouseData = SetVar(data.dataCollections[i].Data[z].MouseData, data.dataCollections[i].PixelVar, data.dataCollections[i].TimeVar);
                    }
                }
                else return;
            }

        }

        private MouseData SetVar(MouseData data, int[] pixelVar, int[] timeVar)
        {
            int tMin = timeVar[0];
            int tMax = timeVar[1];

            int pMin = pixelVar[0];
            int pMax = pixelVar[1];
            if ((pMin != 0 || pMax != 0) || (tMin != 0 || tMax != 0))
            {

                List<int> x = data.x;
                List<int> y = data.y;
                List<long> delay = data.delay;

                for (int i = 0; i < x.Count; i++)
                {
                    if (pMin != 0 || pMax != 0)
                    {
                        x[i] = x[i] + GetRandomNumber(pMin, pMax + 1);
                        //if (x[i] < 0) x[i] = 0;
                        y[i] = y[i] + GetRandomNumber(pMin, pMax + 1);
                        //if (y[i] < 0) y[i] = 0;
                    }

                    if (tMin != 0 || tMax != 0)
                    {
                        delay[i] = delay[i] + GetRandomNumber(tMin, tMax + 1);
                        if (delay[i] < 0) delay[i] = 0;
                    }
                }
                data.x = x;
                data.y = y;
                data.delay = delay;

            }
            return data;
        }



        private int GetRandomNumber(int min, int max)
        {
            int Out = random.Next(min, max);
            if (random.Next(0, 2) == 0) Out *= -1;
            return Out;
        }

    }
}
