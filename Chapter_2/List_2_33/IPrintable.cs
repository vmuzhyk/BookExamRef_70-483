using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_33
{
    interface IPrintable
    {
        string GetPrintableText(int pageWidth, int pageHeight);
        string GetTitle();
    }
}
