using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ_203_05
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var min = _heaps.First();
            _heaps.Remove(min);
            return min;
        }
    }

}
