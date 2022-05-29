using System;

namespace Lab7.Lab7.Task2
{
    public class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        
        private static int Factorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0 || n == 1) return 1;
            
            try
            {
                return n * Factorial(n - 1);
            }
            catch (StackOverflowException caught) 
            {
                Console.WriteLine(caught);
                return -1;
            }
        }
        
        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
            {
                sRev = sRev + s[k];
            }
            
            s = sRev;
        }
    }
}