using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class AsunchronousTimer
    {
        private uint tickCount;
        private uint interval;
        Action<uint> method = (num) => Console.WriteLine("I am test timer {0}", num);

        public AsunchronousTimer(uint tickCount, uint interval)
        {
            this.tickCount = tickCount;
            this.interval = interval;
        }

        public void Run()
        {
            while(this.tickCount > 0)
            {
                System.Threading.Thread.Sleep((int)this.interval);
                this.method(this.tickCount);
                this.tickCount--;
            }
        }
    }
}
