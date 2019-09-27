using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.Voice());
            Cat simon = new Cat();
            Console.WriteLine(simon.Voice());
            Dog jass = new Dog();
            Console.WriteLine(jass.Voice());
            Console.ReadKey();
        }
    }
}
