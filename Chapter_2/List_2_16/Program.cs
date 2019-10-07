using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_16
{
    class IntArrayWrapper
    {
        // Create an array to store the values
        private int[] array = new int[100];
        // Declare an indexer property
        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntArrayWrapper x = new IntArrayWrapper();
            x[0] = 99;
            Console.WriteLine(x[0]);
            Console.ReadKey();
        }
    }
}
