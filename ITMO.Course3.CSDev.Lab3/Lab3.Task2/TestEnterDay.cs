using System;

namespace Lab3
{
    public enum MonthName { January, 
        February, 
        March, 
        April, 
        May, 
        June, 
        July, 
        August, 
        September, 
        October, 
        November, 
        December }
    
    public class TestEnterDay
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число от 1 до 365");
                string input = Console.ReadLine();
                int dayNum = int.Parse(input);
                if (dayNum < 1 || dayNum > 365)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

                int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                foreach (int day in daysInMonth)
                {
                    if (dayNum <= day)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= day;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught) {
                Console.WriteLine(caught);
            }
        }
    }
}