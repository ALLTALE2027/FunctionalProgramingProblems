using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    internal class VowelConsonant
    {
        public void CheckVowelConsonant()
        {
            Console.WriteLine("Program to Check Whether an alphabet is vowel or consonant");
            Console.WriteLine("Enter an  alphabate");
            char a = char.Parse(Console.ReadLine());

            switch (a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Alphabate is vowel");
                    break;
                default:
                    Console.WriteLine("Alphabate is Consonant");
                    break;


            }
        }
    }
}
