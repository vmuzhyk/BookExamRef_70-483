using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_11
{
    class Alien
    {
        public static int Max_Lives = 99;
        public int X;
        public int Y;
        public int Lives;
        public Alien(int x, int y, int lives)
        {
            if (x < 0 || y < 0)
                throw new Exception("Invalid position");
            if (lives > Max_Lives)
                throw new Exception("Invalid lives");
            X = x;
            Y = y;
            Lives = lives;
        }
        public override string ToString()
        {
            var output = "maxLives " + Max_Lives + " " + Lives;
            return output;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Alien item = new Alien(2,2,20);
            Alien.Max_Lives = 190;
            Alien item2 = new Alien(3, 3, 15);
            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadKey();
        }
    }
}
