using System;

namespace Lab4
{
    internal class Task1
    {
        public static void Main(string[] args)
        {
            int x; 
            int y;
            int greater;

            Console.WriteLine("Enter the first number:");
            x = int.Parse(Console.ReadLine( ));
            Console.WriteLine("Enter the second number:");
            y = int.Parse(Console.ReadLine( ));

            greater = Task1.Greater(x, y);
            Console.WriteLine("The greater value is "+ greater);
        }

        /**
         * Return the greater of two integer values
         */
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}