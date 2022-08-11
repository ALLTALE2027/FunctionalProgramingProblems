using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingProblems
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Leap Year Programme");
            Console.WriteLine("Enter a year YYYY: ");
            int year = int.Parse(Console.ReadLine());

            while (year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter 4 digit value");
                year = int.Parse(Console.ReadLine());
            }

            if (year % 4 == 0)
            {
                if (year % 100 != 0)
                    Console.WriteLine($"Year {year} is a Leap Year ");

                else
                {
                    if (year % 400 == 0)
                        Console.WriteLine($"Year {year} is a Leap Year ");
                    else
                        Console.WriteLine($"Year {year} is not a Leap Year ");
                }
            }
            else
            {
                Console.WriteLine($"Year {year} is not a Leap Year ");
            }


        }
    }
    }


