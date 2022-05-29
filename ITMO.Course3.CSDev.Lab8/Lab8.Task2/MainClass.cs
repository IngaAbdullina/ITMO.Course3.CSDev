using System;

namespace Lab8
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(AccountType.Deposit, 500);
            account1.Deposit(700);
            BankAccount account2 = new BankAccount(AccountType.Deposit, 1300);

            account1.TransferFrom(account2, 1000);
            Write(account1);
            Write(account2);
        }

        static void Write(BankAccount account)
        {
            Console.WriteLine("Account number is {0}", account.Number());
            Console.WriteLine("Account balance is {0}", account.Balance());
            Console.WriteLine("Account type is {0}", account.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in account.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }
        
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        
        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount)) {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}