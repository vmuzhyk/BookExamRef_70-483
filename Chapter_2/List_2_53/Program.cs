using System;
using System.Reflection;



namespace List_2_53
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool isMaried;
        public Person(int age, string name, bool ismaried, bool hasJob)
        {
            Age = age;
            Name = name;
            isMaried = ismaried;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Type type;
            Person p = new Person(22, "Peter", true, true);
            type = p.GetType();
            foreach (MemberInfo member in type.GetMembers())
            {
                Console.WriteLine(member.ToString());
            }
            Console.ReadKey();
        }
    }
}
