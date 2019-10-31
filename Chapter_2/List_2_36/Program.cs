using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_36
{
    class Program
    {
        static void GetFunnyDay(IAccount account)
        {
            account.PayInFunds(70.8M);
        }
        static void Main(string[] args)
        {
            decimal o = 30.2M;
            var babyaccount = new BabyAccount();
            babyaccount.WithdrawFunds(o);
            var bankacc = new BankAccount();
            bankacc.WithdrawFunds(40.5M);

            GetFunnyDay(babyaccount);
            GetFunnyDay(bankacc);

            IAccount toster = babyaccount as IAccount;
            toster.
            
        }
    }
}
