using System;

namespace Example_2_11
{
    public class Dog : Animal
    {
        public override void SaySomething()
        {
            base.SaySomething();
            Console.WriteLine();
        }

        public override void SaySomething(string something)
        {
            base.SaySomething(something);
            Console.WriteLine();
        }
    }
}