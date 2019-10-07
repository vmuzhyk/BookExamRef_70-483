using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // the value 99 is boxed into an object
            object o = 99;
            // the boxed object is unboxed back into an int
            int oVal = (int)o;
            Console.WriteLine(oVal);
            float x = 9.9f;
            int i = (int)x;
            Console.ReadKey();
        }
    }
}
