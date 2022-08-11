using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class PrimeFactors
    {
        public void Factors()
        {
            Console.WriteLine("Prime Factors program");
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());


            for (int i = 2; i * i <= n; i++)
            {
                int prime = 0;
                if (n % i == 0)
                {
                    for (int j = 2; j * j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime += 1;
                        }
                    }

                    if (prime == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }



        }
    }
}
