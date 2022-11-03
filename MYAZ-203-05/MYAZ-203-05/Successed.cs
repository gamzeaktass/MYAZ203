using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ_203_05
{
    public class Successed : Result
    {
        public Successed() : base(true, "Successed!")
        {

        }
        public Successed(string message) : base(true, message)
        {

        }

    }

}
