using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_tr8
{
    public class MemoryTracker
    {
        public long GetMemoryUsage()
        {
            return GC.GetTotalMemory(true);
        }
    }
}
