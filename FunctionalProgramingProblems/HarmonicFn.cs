using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class HarmonicFn
    {
        public void Harmonic()
        {
            Console.WriteLine("Harmonic Number program ");
            Console.WriteLine("Enter an integer n");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Please enter integer greater than 0");
                n = int.Parse(Console.ReadLine());
            }


            float harmonicValue = 0;

            for (float i = 1; i <= n; i++)
            {
                harmonicValue += 1 / i;

            }

            Console.WriteLine("Nth harmonic value is : " + harmonicValue);

        }
    }
}
