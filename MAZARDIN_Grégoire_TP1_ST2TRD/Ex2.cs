using System;

namespace MAZARDIN_Grégoire_TP1_ST2TRD
{
    public class Ex2
    {
        public void Prime()
        {
            int test, max = 1000;
            for (int i = 2; i <= max; i++)
            {
                test = 2;
                bool isPrime = true;
                for (test = 2; test < i; test++)
                {
                    if (i % test == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    Console.WriteLine("Number is Prime: "+i);
                }
            }
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public void Fibonacci()
        {
            int number = AskUserForParameter();
            int a = 0, b = 1;
            Console.WriteLine("Fibonacci suite for " + number);
            Console.Write("{0} {1}",a,b);
            for (int c = 2; c < number; c++)
            {
                c = a + b;
                if (c < number)
                {
                    Console.Write(" {0}",c);
                    a = b;
                    b = c;
                }
                
            }
        }

        public void Factorial()
        {
            int number = AskUserForParameter();
            int result = 1;
            Console.WriteLine("Factorial of " + number);
            for (int i = 2; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}