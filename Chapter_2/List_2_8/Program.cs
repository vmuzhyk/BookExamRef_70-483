using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_8
{
    class Alien
    {
        public int X;
        public int Y;
        public int Lives;
        public Alien(int x, int y, int lives)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException("Invalid position");
            X = x;
            Y = y;
            Lives = lives;
        }
        public Alien(int x, int y)
        {
            X = x;
            Y = y;
            Lives = 3;
        }
    }
}
