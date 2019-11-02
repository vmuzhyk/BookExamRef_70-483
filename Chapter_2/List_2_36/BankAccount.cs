using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_36
{
    public class BankAccount : IAccount
    {
        private decimal _balance;

        public BankAccount(int balance)
        {
            _balance = balance; 
        }

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (_balance < amount)
            {
                return false;
            }
            _balance = _balance - amount;
            return true;
        }
        void IAccount.PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }
        decimal IAccount.GetBalance()
        {
            return _balance;
        }
        public int CompareTo(IAccount other)
        {
            // if we are being compared with a null object we are definitely after it
            if (other == null) return 1;
           
            // use the balance value as the basis of the comparison
            var result = this._balance.CompareTo(other.GetBalance());
            return result;
        }

        /*public int CompareTo(IAccount other)
        {
            throw new NotImplementedException();
        }*/
    }
    public class BabyAccount : BankAccount, IAccount
    {
        public BabyAccount(int balance) : base(balance)
        {
        }

        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            else
            {
                return base.WithdrawFunds(amount);
            }
        }
    }
}
