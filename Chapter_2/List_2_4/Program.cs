using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_4
{
    enum AlienState :
    byte
    {
        Sleeping = 1,
        Attacking = 2,
        Destroyed = 4
    };
    class Program
    {
        static void Main(string[] args)
        {
            AlienState x = AlienState.Attacking;
            Console.WriteLine((int) x);
            Console.ReadKey();
        }
    }
}
