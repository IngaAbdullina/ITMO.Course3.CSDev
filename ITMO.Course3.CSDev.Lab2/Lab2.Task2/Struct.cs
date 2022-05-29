using System;

namespace Lab2
{
    public enum AccountType { Checking, Deposit }
    
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    
    public class Struct
    {
        public static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;
    
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Account Number {0}", goldAccount.accNo);
            Console.WriteLine("Account Type {0}", goldAccount.accType);
            Console.WriteLine("Account Balance ${0}",goldAccount.accBal);
        }
    }
}