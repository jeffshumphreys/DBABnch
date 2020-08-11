using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickInterface.Helpers
{
    public class StopWatchExt : Stopwatch
    {
        public StopWatchExt()
        {
            this.Start();
        }
    }
}
