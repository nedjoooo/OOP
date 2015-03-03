using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class AsunchronousTimerTest
    {
        static void Main(string[] args)
        {
            var timer = new AsunchronousTimer(10, 1000);
            timer.Run();
        }
    }
}
