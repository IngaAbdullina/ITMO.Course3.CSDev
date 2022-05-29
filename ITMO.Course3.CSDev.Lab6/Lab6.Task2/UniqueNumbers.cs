using System;

namespace Lab6
{
    public class UniqueNumbers
    {
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

        public static void Main(string[] args)
        {
            BankAccount first = UniqueNumbers.NewBankAccount();
            Write(first);
            Console.WriteLine("-=========================-");
            
            BankAccount second = UniqueNumbers.NewBankAccount();
            Write(second);
            Console.WriteLine("-=========================-");
        }
    }
    
    public enum AccountType { Checking, Deposit }
    public class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
        }
        
        public long Number()
        {
            return accNo;
        }
        
        public decimal Balance()
        {
            return accBal;
        }
        
        public String Type()
        {
            return accType.ToString();
        }

        private static long NextNumber()
        {
            return nextAccNo++;
        }
    }
}