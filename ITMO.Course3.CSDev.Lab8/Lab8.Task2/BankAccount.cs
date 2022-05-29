using System;
using System.Collections;

namespace Lab8
{
    public class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        private Queue tranQueue = new Queue();
        
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
                BankTransaction tran = new BankTransaction(amount);
                tranQueue.Enqueue(tran);
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
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
        
        public Queue Transactions()
        {
            return tranQueue;
        }
    }
}