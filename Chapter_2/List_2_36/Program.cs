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


            var account1 = new BankAccount(80675);
            var account2 = new BankAccount(76647);
            var result = account1.CompareTo(account2);

            /*// Create 20 accounts with random balances
            List<IAccount> accounts = new List<IAccount>();
            Random rand = new Random(1);
            for (int i = 0; i < 3; i++)
            {
                IAccount account = new BankAccount(rand.Next(0, 10000));
                accounts.Add(account);
            }
            // Sort the accounts
            accounts.Sort();
            // Display the sorted accounts
            foreach (IAccount account in accounts)
            {
                Console.WriteLine(account.GetBalance());
            }*/
            Console.ReadKey();
        }
    }
}
