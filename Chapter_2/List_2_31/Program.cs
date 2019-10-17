using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_31
{
    class BankAccount
    {
        protected class Address
        {
            public string FirstLine;
            public string Postcode;
        }
        protected decimal accountBalance = 0;
    }
    class OverdraftAccount : BankAccount
    {
        decimal overdraftLimit = 100;
        Address GuarantorAddress;
        public void Print ()
        {   
            Console.WriteLine(accountBalance);
            Console.WriteLine(GuarantorAddress.FirstLine);
            
        }
    }
    class Program
    {
         static void Main(string[] args)
        {
            
            
        }
    }
}
