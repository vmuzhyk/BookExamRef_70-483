﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_18
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d0 = new DateTime(ticks: 636679008000000000);
            DateTime d1 = new DateTime(year: 2018, month: 7, day: 23);
            Console.WriteLine(d0);
            Console.WriteLine(d1);
            Console.ReadKey();
            
        }
    }
}
