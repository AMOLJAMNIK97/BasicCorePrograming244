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
            Console.WriteLine("1.Flip Coin\n2.Leap Year\n3.Power of two\n4.Harmonic\n5. Factors\n6.Sawp Two Number\n7. Check Number Even or Odd\n8.Quotient Remainder\n9.Largest three Number\n10.Alphabet is Vowel or Consonant");
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
                case 7:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.CheckEvenOdd();
                    break;
                case 8:
                    QuotientRemainder remainder = new QuotientRemainder();
                    remainder.QuotRemain();
                    break;
                case 9:
                    LargestNumber largest = new LargestNumber();
                    largest.FindThreeNumber();
                    break;
                case 10:
                    Alphabet check = new Alphabet();
                    check.CheckConsonantOrVowel();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
    }
}