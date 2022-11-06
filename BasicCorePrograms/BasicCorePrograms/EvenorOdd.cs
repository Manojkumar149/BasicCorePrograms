using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenorOdd
    {
        public void EvenOrOdd()
        {
            int i = 10;
            if (i % 2 == 0)
                Console.WriteLine("Given Number " + i + " is Even.");
            else
                Console.WriteLine("Given Number " + i + " is Odd.");
        }
    }
}
