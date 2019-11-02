using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*EnumeratorThing e = new EnumeratorThing(10);
            foreach (int i in e)
                Console.WriteLine(i);*/
            EnumeratorThing2 e2 = new EnumeratorThing2(10);
            foreach (int i in e2)
                Console.WriteLine(i);

        }
    }
}
