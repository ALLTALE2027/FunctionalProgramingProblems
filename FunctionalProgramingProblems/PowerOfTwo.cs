using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Program for Power of 2");
            Console.WriteLine("Enter an integer number betn  0 to 31");

            int N = int.Parse(Console.ReadLine());

            while (N < 0 || N > 31)
            {
                Console.WriteLine("please enter value from 0 to 31");
                N = int.Parse(Console.ReadLine());
            }

            int pow = 1;
            for (int i = 0; i <= N; i++)
            {
                pow = (int)Math.Pow(2, i);

                Console.WriteLine($"value of 2 to power {i} is: {pow}");
            }
        }
    }
}
