using System;
using System.IO;

namespace List_2_68
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            writer.WriteLine("Hello World");
            writer.Close();
            Console.Write(writer.ToString());
            Console.ReadKey();
        }
    }
}
