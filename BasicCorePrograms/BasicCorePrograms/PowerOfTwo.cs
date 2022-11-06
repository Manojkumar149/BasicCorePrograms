using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public void PowerofTwo(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}
