using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_36
{
    interface IAccount
    {
        void PayInFunds(decimal amount);
        decimal GetBalance();
        bool WithdrawFunds(decimal amount);
    }
}
