using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_33
{
    class Report : IPrintable
    {
        public string GetPrintableText(int pageWidth, int pageHeight)
        {
            return "Report text";
        }
        public string GetTitle()
        {
            return "Report title";
        }
    }
}
