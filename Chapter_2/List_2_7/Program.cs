using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_7
{
    class Alien
    {
        public int X;
        public int Y;
        public int Lives;
        private Alien(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException("Invalid position");
            X = x;
            Y = y;
            Lives = 3;
        }
        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Lives: {2}", X, Y, Lives);
        }
        public static Alien CreateAliens (int x, int y)
        {
            return new Alien(x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alien y = Alien.CreateAliens(10, 10);
            //Alien x = new Alien(100, 100);
            Console.WriteLine("x {0}", x);
            Console.ReadKey();
        }
    }
}
