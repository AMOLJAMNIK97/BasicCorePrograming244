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
            Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power of two\n4.Harmonic\n5. Factors\n6.Sawp Two Number ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CheckHeadTail();
                    break;
                case 2:
                    LeapYear leap = new LeapYear();
                    leap.FindLeap();
                    break;
                case 3:
                    Power power = new Power();
                    power.FindPower();
                    break;
                case 4:
                    Harmonic harmonic = new Harmonic();
                    harmonic.FindHarmoic();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactor();
                    break;
                case 6:
                    SawpNumber sawpNumber = new SawpNumber();
                    sawpNumber.SwappingNumber();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
    }
}