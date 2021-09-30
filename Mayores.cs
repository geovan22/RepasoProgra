using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Mayores
    {
        private int n1 = 0;
        private int n2 = 0;
        private int MayorA(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int MayorB()
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        public int MayorC(int Val)
        {
            return Val;
        }
    }
}
