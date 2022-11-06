using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public void Swap2Numbers()
        {
            int number1 = 10;
            int number2 = 20;
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Numbers After Swapping number1 = " + number1 + " number2 = " + number2);
        }
    }
}
