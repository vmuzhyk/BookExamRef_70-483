using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_6
{
    class Program
    {
        public bool IsAlive (ILifeForm ogr, ILifeForm ciclop)
        {
            ogr.IsAlive();
            ciclop.IsAlive();
            return false;
        }
        public void IsAlive(ILifeForm warrior)
        {
            warrior.IsAlive();
        }
        static void Main(string[] args)
        {
            Unit sceletron = new Unit();
            
        }
    }
}
