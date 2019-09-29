using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_12
{
    class Alien
    {
        public int X;
        public int Y;
        public int Lives;
        public Alien (int x, int y)
        {
            X = x;
            Y = y;
            Lives = 3;
        }
        public bool RemoveLives(int livesToRemove)
        {
            Lives = Lives - livesToRemove;
            if (Lives <= 0)
            {
                Lives = 0;
                X = -1000;
                Y = -1000;
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alien x = new Alien(100, 100);
            Console.WriteLine("x {0}", x.Lives);
            if (x.RemoveLives(4))
            {
                Console.WriteLine("Still alive");
            }
            else
            {
                Console.WriteLine("Alien destroyed");
            }
            Console.WriteLine("x {0}", x.Lives);
            Console.ReadKey();
        }
    }
}
