using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_32
{
    interface IPrintable
    {
        string GetPrintableText(int pageWidth, int pageHeight);
        string GetTitle();
    }
    interface IDisplay
    {
        string GetTitle();
    }
    class Report : IPrintable, IDisplay
    {
        string IPrintable.GetPrintableText(int pageWidth, int pageHeight)
        {
            return "Report text to be printed";
        }
        string IPrintable.GetTitle()
        {
            return "Report title to be printed";
        }
        string IDisplay.GetTitle()
        {
            return "Report title to be displayed";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
