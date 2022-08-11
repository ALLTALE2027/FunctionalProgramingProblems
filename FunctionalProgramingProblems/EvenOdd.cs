using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class EvenOdd
    {
        public void CheckEvenOdd()
        {

            Console.WriteLine("Program to Check Whether a Number is Even or Odd");
            Console.WriteLine("Enter a whole Number");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Given number {0} is Even", n);
            }
            else
            {
                Console.WriteLine("Given number {0} is Odd", n);
            }
        }
    }
}
