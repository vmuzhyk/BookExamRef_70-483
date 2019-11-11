using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace List_2_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Attribute a = Attribute.GetCustomAttribute(typeof(Person), typeof(ProgrammerAttribute));
            ProgrammerAttribute p = (ProgrammerAttribute)a;
            Console.WriteLine("Programmer: {0}", p.Programmer);
            

            Type type;
            Person r = new Person();
            type = r.GetType();
            MethodInfo setMethod = type.GetMethod("set_Name");
            setMethod.Invoke(r, new object[] { "Fred" });
            Console.WriteLine(r.Name);
            //Console.WriteLine("Person type: {0}", type.ToString());
            Console.ReadKey();

        }
    }
}
