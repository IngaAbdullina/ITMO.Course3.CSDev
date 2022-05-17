using System;

namespace ITMO.Course3.Lab1.Task4
{
    internal class Task4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first integer");
            string temp = Console.ReadLine();
            int firstInt = Int32.Parse(temp);
            Console.WriteLine("Please enter the second integer");
            temp = Console.ReadLine();
            int secondInt = Int32.Parse(temp);

            try
            {
                int result = firstInt / secondInt;
                Console.WriteLine("The answer is " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
        }
    }
}
