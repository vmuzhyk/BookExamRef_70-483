using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_3
{
    class Join
    {
        public static void Enter ()
        {
            Console.WriteLine("Alert. I am going in.");
        }
        public void Insert()
        {
            Enter();
        }
    }

    class Leave
    {
        public void Out ()
        {
            Console.WriteLine("Alert. I am going away.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Join.Enter();
            Leave leave = new Leave();
            leave.Out();
            One();
            
        }
    }
}
