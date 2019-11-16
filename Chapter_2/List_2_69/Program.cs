using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace List_2_69
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataString = 
@"Rob Miles
21";
            StringReader dataStringReader = new StringReader(dataString);
            string name = dataStringReader.ReadLine();
            int age = int.Parse(dataStringReader.ReadLine());
            dataStringReader.Close();
            Console.WriteLine("Name: {0} Age: {1}", name, age);

            string input = " Rob Miles";
            int nameStart = input.IndexOf("Rob");
            string name1 = input.Substring(nameStart, 3);
            Console.Write(name1);

            string sentence = "The cat sat on the mat.";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Default comparison fails because the strings are different
            if (!"encyclopædia".Equals("encyclopaedia"))
                Console.WriteLine("Unicode encyclopaedias are not equal");
           
            // Set the curent culture for this thread to EN-US
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            // Using the current culture the strings are equal
           
            if ("encyclopædia".Equals("encyclopaedia", StringComparison.CurrentCulture))
            Console.WriteLine("Culture comparison encyclopaedias are equal");
            // We can use the IgnoreCase option to perform comparisions that ignore case
        
            if ("encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("Case culture comparison encyclopaedias are equal");
         
            if (!"encyclopædia".Equals("ENCYCLOPAEDIA", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Ordinal comparison encyclopaedias are not equal");

            foreach (char ch in "Hello world") 
            { 
                Console.WriteLine(ch); 
            }

            int i = 99;
            double pi = 3.141592654;
            Console.WriteLine(" {0,-10:D}{0, -10:X}{1,5:N2}", i, pi);

            Console.ReadKey();
        }
    }
}
