﻿#define TERSE
//#define VERBOSE

using System;
using System.Diagnostics;


namespace List_2_47
{
    class Program
    {
        [Conditional("VERBOSE"), Conditional("TERSE")]
        static void reportHeader()
        {
            Console.WriteLine("This is the header for the report");
        }
        [Conditional("VERBOSE")]
        static void verboseReport()
        {
            Console.WriteLine("This is output from the verbose report.");
        }
        [Conditional("TERSE")]
        static void terseReport()
        {
            Console.WriteLine("This is output from the terse report.");
        }
        static void Main(string[] args)
        {
            reportHeader();
            terseReport();
            verboseReport();
            Console.ReadKey();
        }
    }
}
