namespace FunctionalProgramingProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your selection from below");
            Console.WriteLine("1. Flip Coin Percentage");
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. Power of Two");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Prime Factors");
            Console.WriteLine("6. Quotient and Remainder");
            Console.WriteLine("7. Swap Two Numbers");
            Console.WriteLine("8. Check Whether a Number is Even or Odd");
            Console.WriteLine("9. Alphabet is Vowel or Consonant");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    FlipCoin uc1 = new FlipCoin();
                    uc1.FlipCoinPercentage();
                    
                    break;

                case 2:LeapYear year=new LeapYear();
                    year.CheckLeapYear();
                    
                    break;

                case 3: PowerOfTwo power2=new PowerOfTwo();
                    power2.Power();

                    break;
                case 4: HarmonicFn harmon=new HarmonicFn();
                         harmon.Harmonic();
                    break;
                case 5: PrimeFactors prime = new PrimeFactors();
                        prime.Factors();
                    break;
                case 6:QuotientRemainder find = new QuotientRemainder();
                      find.RemainderQuotient();
                    break;
                case 7:  SwapNumbers swap = new SwapNumbers();
                         swap.Swap();
                    break;
                case 8: EvenOdd evenOdd = new EvenOdd();
                        evenOdd.CheckEvenOdd();
                    break;
                case 9:VowelConsonant check=new VowelConsonant();
                       check.CheckVowelConsonant();
                    break;



                default:
                    Console.WriteLine("Make Proper Selection");
                    break;
            }
        }
    }
}