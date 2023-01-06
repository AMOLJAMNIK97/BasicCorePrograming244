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
            Console.WriteLine("1.Flip Coin ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.CheckHeadTail();
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    break;
            }
        }
    }
}