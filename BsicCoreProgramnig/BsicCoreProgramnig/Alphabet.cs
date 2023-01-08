using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsicCoreProgramnig
{
    public class Alphabet
    {
        public void CheckConsonantOrVowel()
        {
            char input;
            Console.WriteLine("Enter a Character");
            input = Convert.ToChar(Console.ReadLine());
            if (input == 'a' || input == 'A' || input == 'e' || input == 'E' || input == 'i' || input == 'I' || input == 'o' || input == 'O' || input == 'u' || input == 'U')
            {
                Console.WriteLine(input + " is a Vowel");
            }
            else
            {
                Console.WriteLine(input + " is a Consonant");
            }

        }
    }
}
