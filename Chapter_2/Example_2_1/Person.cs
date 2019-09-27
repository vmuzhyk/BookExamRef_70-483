using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_1
{
    public struct Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
