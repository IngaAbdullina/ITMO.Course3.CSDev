using System;

namespace Lab4
{
    public class Utils2
    {
        public static void Main(string[] args)
        {
            int x; 
            int y;
            
            Console.WriteLine("Enter the first number:");
            x = int.Parse(Console.ReadLine( ));
            Console.WriteLine("Enter the second number:");
            y = int.Parse(Console.ReadLine( ));
        
            Console.WriteLine("Before swap: x = " + x + ", y = " + y);
            Swap(ref x, ref y);
            Console.WriteLine("After swap: x = " + x + ", y = " + y);
        }

        private static void Swap(ref int a, ref int b)
        {
            // (a, b) = (b, a);
            int temp = a;
            a = b;
            b = temp;
        }
    }
}