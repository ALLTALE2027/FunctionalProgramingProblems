using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class LargestNumber
    {
        public void GetMaxNum()
        {
            Console.WriteLine("Program to Find the Largest Among Three Numbers");
            Console.WriteLine("Enter the first Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third Number");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum from {0} {1} {2} is {3} ", a, b, c, a > b ? (a > c ? a : c) : (b > c ? b : c));
        }
    }
}
