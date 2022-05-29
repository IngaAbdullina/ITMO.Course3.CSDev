using System;

namespace Lab8
{
    public class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        
        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
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
        
        public decimal Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                accBal += amount;
                return accBal;
            }
            else
            {
                return 0;
            }
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds) {
                accBal -= amount;
            }
            return sufficientFunds;
        }

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
    }
}