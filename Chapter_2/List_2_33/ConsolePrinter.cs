using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_33
{
    class ConsolePrinter
    {
        public void PrintItem(IPrintable item)
        {
            Console.WriteLine(item.GetTitle());
            Console.WriteLine(item.GetPrintableText(pageWidth: 80, pageHeight: 25));
        }
    }
}
