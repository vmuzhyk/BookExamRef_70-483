using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List_2_26_2
{
    class Program
    {
            static void Main(string[] args)
            {
                // Create the interop
                var excelApp = new Application();
                // make the app visible
                excelApp.Visible = true;
                // Add a new workbook
                excelApp.Workbooks.Add();
                // Obtain the active sheet from the app
                // There is no need to cast this dynamic type
                Worksheet workSheet = excelApp.ActiveSheet;
                // Write into two cells
                workSheet.Cells[1, "A"] = "Hello";
                workSheet.Cells[1, "B"] = "from C#";
                workSheet.Cells[2, "A"] = "Hello";
                workSheet.Cells[2, "B"] = "Dima";
        }

        }
}


