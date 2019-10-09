using System;

namespace List_2_24
{
    class MessageDisplay
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello world");
            dynamic d = new MessageDisplay();
            d.Banana("hello world");
            MessageDisplay m2;
            m2 = new MessageDisplay();
        }
    }
}
