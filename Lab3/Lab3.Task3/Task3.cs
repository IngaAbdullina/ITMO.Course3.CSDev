using System;

namespace Lab3.Task1
{
    public enum MonthName { January, February, March, April, May, June, July, August, September, October, November, December }
    
    class Task3
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the year");
                string input = Console.ReadLine();
                int yearNum = int.Parse(input);
                bool isLeapYear = (yearNum % 4 == 0) 
                                 && (yearNum % 100 != 0 
                                     || yearNum % 400 == 0);
                int maxDayNum;
                int[] daysInMonth;
                if (isLeapYear)
                {
                    maxDayNum = 366;
                    daysInMonth = new int[]{ 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                } else
                {
                    maxDayNum = 365;
                    daysInMonth = new int[]{ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                }

                Console.WriteLine("Please enter a day number between 1 and {0}: ", maxDayNum);
                input = Console.ReadLine();
                int dayNum = int.Parse(input);
                
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                int monthNum = 0;

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