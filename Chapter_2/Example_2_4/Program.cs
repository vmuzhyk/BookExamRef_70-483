using System;

namespace Example_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TarotCard card = new TarotCard();
            var monk = new Monk();
            var skeleton = new Skeleton();
            card.KillFromOneShoot(monk);
            card.KillFromOneShoot(skeleton);
            Console.ReadKey();
        }
    }
}
