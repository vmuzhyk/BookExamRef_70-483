using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get an enumerator that can iterate through a string
            var stringEnumerator = "Hello world".GetEnumerator();
            while (stringEnumerator.MoveNext())
            {
                Console.Write(stringEnumerator.Current + ".");
            }

            foreach (char ch in "Hello world")
                Console.Write(ch);

            Console.ReadKey();
        }
    }
}
