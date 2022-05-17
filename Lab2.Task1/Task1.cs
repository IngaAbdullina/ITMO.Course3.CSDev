using System;

namespace Lab2.Task1
{
    public enum AccountType { Checking, Deposit }
    
    internal class Task1
    {
        public static void Main(string[] args)
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;
            
            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}