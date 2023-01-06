using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicCoreProgramnig
{
    public class SawpNumber
    {
        public void SwappingNumber()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the seccond number");
            num2 = Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine("First number : " + num1);
            Console.WriteLine("Second number: " + num2);
        }
    }
}
