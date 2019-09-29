using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_10
{
    class Alien
    {
        // Alien code here
        static Alien()
        {
            Console.WriteLine("Static Alien constructor running");
        }
        public Alien()
        {
            Console.WriteLine("Static Alien constructor running");
        }
        public static void AddAlien()
        {
            Console.WriteLine("Alien added");
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alien.AddAlien();
            Console.ReadKey();
        }
    }
}
