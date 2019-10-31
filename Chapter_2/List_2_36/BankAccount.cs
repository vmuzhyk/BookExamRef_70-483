using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_36
{
    public class BankAccount : IAccount
    {
        private decimal _balance = 0;
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
    }
    public class BabyAccount : BankAccount, IAccount
    {
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
