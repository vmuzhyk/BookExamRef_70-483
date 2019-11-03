using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int index = rand.Next(1, 185);
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
