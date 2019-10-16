using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_29
{
    class BankAccount
    {
        protected decimal accountBalance = 0;
        public void PayInFunds(decimal amountToPayIn)
        {
            accountBalance = accountBalance + amountToPayIn;
        }
        public virtual bool WithdrawFunds(decimal amountToWithdraw)
        {
            if (amountToWithdraw > accountBalance)
                return false;
            accountBalance = accountBalance - amountToWithdraw;
            return true;
        }
        public decimal GetBalance()
        {
            return accountBalance;
        }
    }
    class OverdraftAccount : BankAccount
    {
        decimal overdraftLimit = 100;
        public override bool WithdrawFunds(decimal amountToWithdraw)
        {
            if (amountToWithdraw > accountBalance + overdraftLimit)
                return false;
            accountBalance = accountBalance - amountToWithdraw;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount a = new BankAccount();
            a.PayInFunds(50);
            Console.WriteLine("Pay in 50");
            a.PayInFunds(50);
            if (a.WithdrawFunds(10))
                Console.WriteLine("Withdrawn 10");
            Console.WriteLine("Account balance is: {0}", a.GetBalance());
            Console.ReadKey();
        }
    }
}
