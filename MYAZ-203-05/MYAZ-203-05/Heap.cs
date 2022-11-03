using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ_203_05
{
    public abstract class Heap
    {
        
        protected SortedSet<int> _heaps;
        public Heap()
        {
            _heaps = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            _heaps.Add(item);
        }
        public abstract int Extract();
    }
}
