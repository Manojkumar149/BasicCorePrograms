using System;
namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            bool flag = true;
            Console.WriteLine(" 1.FlipCoin \n 2.LeapYear \n 3.PowerOfTwo \n 4.HarmonicNumber \n 5.Factors \n 6.QuotientAndRemainder \n 7.SwapTwoNumbers \n 8. EvenorOdd \n 9.VowelOrConsonant \n 10. LargestNumber");
            int check = Convert.ToInt32(Console.ReadLine());
            while (flag)
            {
                switch (check)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.play(1);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                        swapTwoNumbers.Swap2Numbers();
                        break;
                    case 8:
                        EvenorOdd evenorOdd = new EvenorOdd();
                        evenorOdd.EvenOrOdd();
                        break;
                    case 9:
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        largestNumber.ThirdLargestNumber();
                        break;
                    default:
                        break;
                }
                break;
            }
        }
    }
}
