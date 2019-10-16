using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_28
{
    class Customer
    {
        private string _nameValue;
        public string Name
        {
            get
            {
                return _nameValue;
            }
            set
            {
                if (value == "")
                    throw new Exception("Invalid customer name");
                _nameValue = value;
            }
        }
    }
    class Program
    {
        public static void Main (string []arg)
        {
            Customer c = new Customer();
            c.Name = "Rob";
            Console.WriteLine("Customer name: {0}", c.Name);
            Console.ReadKey();
            // the following statement will throw an exception
            c.Name = "";
        }
    }
}