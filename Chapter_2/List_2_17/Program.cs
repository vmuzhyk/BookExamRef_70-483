using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedIntArray x = new NamedIntArray();
            x["zero"] = 99;
            Console.WriteLine(x["zero"]);
            Console.ReadKey();
        }
    }
}
