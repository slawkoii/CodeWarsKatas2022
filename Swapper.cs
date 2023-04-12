using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas2022
{
    public class Swapper
    {
        public object[] Arguments { get; private set; }

        public Swapper(object[] args)
        {
           Arguments = args;            
        }

        public void SwapValues()
        {           
            object temp = Arguments[0];
            Arguments[0] =  Arguments[1];
            Arguments[1] = temp;
        }
    }
}
