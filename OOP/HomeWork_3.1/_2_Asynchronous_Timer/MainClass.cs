using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Asynchronous_Timer
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Action action =
                () =>
                {
                    Console.WriteLine("Tick-Tack");
                };
            AsyncTimer firstTimer = new AsyncTimer(20, 1, action);
            firstTimer.Start();
            
        }
    }
}
