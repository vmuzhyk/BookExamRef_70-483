using System;

namespace Example_2_11
{
    public class Animal
    {
        public virtual void SaySomething()
        {
            Console.WriteLine("Scream");
        }  
        public virtual void SaySomething(string something)
        {
            Console.WriteLine("Scream");
        }  
        
    }
}