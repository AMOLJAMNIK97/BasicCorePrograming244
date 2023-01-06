using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicCoreProgramnig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Flip Coin\n2.Check Leap Year\n3. Check power of two\n4. Harmonic Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipcoin = new FlipCoin();
                    flipcoin.CheckHeadTail();
                    break;
                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.FindLeap();
                    break;
                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.FindPower();
                    break;
                case 4:
                    Harmonic harmonic = new Harmonic();
                    harmonic.FindHarmoic();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
    }
}