using System;

namespace Lab4
{
    public class Task3
    {
        public static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter the number:");
            x = int.Parse(Console.ReadLine());

            int answer = Factorial(x);
            Console.WriteLine("The factorial of number " + x 
                                                         + " is: " + answer);
        }

        private static int Factorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0 || n == 1) return 1;
            
            try
            {
                checked
                {
                    return n * Factorial(n - 1);
                }
            }
            catch (Exception caught) 
            {
                Console.WriteLine(caught);
                return -1;
            }
        }
    }
}