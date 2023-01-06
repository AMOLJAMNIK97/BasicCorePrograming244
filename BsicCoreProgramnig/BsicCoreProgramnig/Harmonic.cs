using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicCoreProgramnig
{
    public class Harmonic
    {
        static double nthHarmonic(int N)
        {
            float harmonic = 1;

            for (int i = 1; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;
        }

        public void FindHarmoic()
        {
            int N = 12;
            Console.WriteLine(nthHarmonic(N));

        }
    }
}
