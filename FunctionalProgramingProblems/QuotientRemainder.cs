﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class QuotientRemainder
    {
        public void RemainderQuotient()
        {
            Console.WriteLine("Program to Compute Quotient and Remainder");
            Console.WriteLine("Enter first Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            int n2 = int.Parse(Console.ReadLine());
            int n3, n4;
            n3 = n1 / n2;
            n4 = n1 % n2;
            Console.WriteLine("Quotient is {0} and Remainder is {1}", n3, n4);

        }
    }
}
