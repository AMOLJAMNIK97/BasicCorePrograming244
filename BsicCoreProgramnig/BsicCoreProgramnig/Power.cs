using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicCoreProgramnig
{
    public class Power
    {
        // Function to check if x is power of 2
        static bool isPowerofTwo(int n)
        {
            if (n == 0)
                return false;
            if ((n & (~(n - 1))) == n)
                return true;
            return false;
        }
        public void FindPower()
        {
            Console.WriteLine("Enter of Power Number");
            int NumofCount = Convert.ToInt32(Console.ReadLine());
            if (isPowerofTwo(30) == true)
            {
                Console.WriteLine("Yes");
            }
            else if (isPowerofTwo(128) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
