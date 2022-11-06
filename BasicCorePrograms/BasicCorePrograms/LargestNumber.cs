using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public void ThirdLargestNumber()
        {
            int a = 5, b = 10, c = 8;
            if(a > b)
            {
                Console.WriteLine(a + " is Larger than "+ b +" and "+ c );
                if(a > c)
                {
                    Console.WriteLine(a + " is Larger than " + b + " and " + c);
                }
            }
            else if (b > c)
            {
                Console.WriteLine(b + " is Larger than " + a + " and " + c);
            }
            else
            {
                Console.WriteLine(c + " is Larger than " + a + " and " + b);
            }
        }
    }
}
