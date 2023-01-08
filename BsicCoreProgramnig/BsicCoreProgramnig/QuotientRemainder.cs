using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicCoreProgramnig
{
    public class QuotientRemainder
    {
        public void QuotRemain()
        {

            int Dividend = 0;
            int Divisor = 0;

            Console.Write("Enter the Dividend: ");
            Dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Divisor: ");
            Divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            int Reminder = Dividend % Divisor;

            Console.WriteLine("Dividend: {0} Divisor: {1}", Dividend, Divisor);
            Console.WriteLine("Quotient:  " + Quotient);
            Console.WriteLine("Reminder: " + Reminder);
        }
    }
}
