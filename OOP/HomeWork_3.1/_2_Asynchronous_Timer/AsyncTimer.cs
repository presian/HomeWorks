using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2_Asynchronous_Timer
{
    class AsyncTimer
    {
        private int ticks;
        private int time;
        private Action ticker;
        public int Ticks
        {
            get { return ticks; }
            set { ticks = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public Action Ticker
        {
            get { return ticker; }
            set { ticker = value; }
        }
        
        public AsyncTimer(int ticks, int t, Action ticker)
        {
            this.Ticks = ticks;
            this.Time = t*1000;
            this.Ticker = ticker;
        }

        public void Worker()
        {

            for (int i = this.ticks; i > 0; i--)
            {
                Thread.Sleep(this.time);
                Console.Beep();
                ticker();
            }
        }

        public void Start()
        {
            Thread ticTac = new Thread(Worker);
            ticTac.Start();
        }
        
    }

   
}
