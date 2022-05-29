using System;

namespace Lab7
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            BankAccount first = NewBankAccount();
            Write(first);
            Console.WriteLine("-=========================-");
            
            BankAccount second = NewBankAccount();
            Write(second);
            Console.WriteLine("-=========================-");
            
            first.TransferFrom(second, 1000);
            Write(first);
            Console.WriteLine("-=========================-");
            Write(second);
        }
        
        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();
            Random random = new Random();
            decimal balance = random.Next();
            created.Populate(balance);
            return created;
        }
        
        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
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
    
    // public enum AccountType { Checking, Deposit }
    // public class BankAccount
    // {
    //     private long accNo;
    //     private decimal accBal;
    //     private AccountType accType;
    //     private static long nextAccNo = 123;
    //     
    //     public void Populate(decimal balance)
    //     {
    //         accNo = NextNumber();
    //         accBal = balance;
    //         accType = AccountType.Checking;
    //     }
    //     
    //     public long Number()
    //     {
    //         return accNo;
    //     }
    //     
    //     public decimal Balance()
    //     {
    //         return accBal;
    //     }
    //     
    //     public String Type()
    //     {
    //         return accType.ToString();
    //     }
    //
    //     private static long NextNumber()
    //     {
    //         return nextAccNo++;
    //     }
    //     
    //     public void TransferFrom(BankAccount accFrom, decimal amount)
    //     {
    //         if (accFrom.Withdraw(amount))
    //             this.Deposit(amount);
    //     }
    // }
}