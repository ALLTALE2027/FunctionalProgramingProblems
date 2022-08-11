using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class SwapNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Program to Swap Two Numbers");
            Console.WriteLine("Enter value of first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of second number");
            int b = int.Parse(Console.ReadLine());


            int c = a;
            a = b;
            b = c;

            Console.WriteLine("value of a and b are: {0} {1} ", a, b);
        }
    }
}
