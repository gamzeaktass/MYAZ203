using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ_203_05
{
    public class MaxHeap:Heap
    {
        public override int Extract()
        {
            var max = _heaps.Last();
            _heaps.Remove(max);
            return max;
        }
    }
}
