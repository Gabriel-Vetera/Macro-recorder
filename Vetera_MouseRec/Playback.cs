using System;
using System.Threading.Tasks;

namespace Vetera_MouseRec
{
    public class Playback
    {

        SimulateKeyboard simulateKeyboard;
        SimulateMouse simulateMouse;
        MouseData mouseData;

        public Playback(Data data, String Title)
        {
            Cash.playback_finish = false;
            this.mouseData = data.MouseData;
            data.KeyboardData.finish = true;

            Play.Reset();

            long count = 0;

            foreach (KeyData keyboard_data in data.KeyboardData.getKeyboarData())
            {
                count++;
            }


            Play.Items = mouseData.getX().Length + count;
            Play.Time = mouseData.getDelay();
            Play.ItemName = data.Name;
            Play.ItemTitle = Title;

            new SmoothMouseLoop(data.MouseData.getX()[0], data.MouseData.getY()[0]);

            simulateKeyboard = new SimulateKeyboard(data.KeyboardData);
            simulateMouse = new SimulateMouse(data.MouseData);

        }



        public void Start()
        {

            Task.Run(() => simulateKeyboard.StartSim());
            Task.Run(() => simulateMouse.StartSim());
            Play.StartTime = DateTime.Now;

        }

        public void Pause()
        {
            Cash.paus_request = true;
        }

        public void Resume()
        {
            Task.Run(() => Resume_now());
        }

        private void Resume_now()
        {
            Cash.Resume();
        }


    }
}
