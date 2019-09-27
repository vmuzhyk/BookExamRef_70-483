using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DateTime for today
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            // Move the date on to tomorrow
            date = date.AddDays(1);
            Console.WriteLine(date);
            Console.ReadKey();
        }
    }
}
