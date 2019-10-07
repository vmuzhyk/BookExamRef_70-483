using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_2_19
{
    class Document
    {
        // All documents have the same GetDate behavior so
        // this method will not be overridden
        public void GetDate()
        {
            Console.WriteLine("Hello from GetDate in Document");
        }
        // A document may have its own DoPrint behavior so
        // this method is virtual so it can be overriden
        public virtual void DoPrint()
        {
            Console.WriteLine("Hello from DoPrint in Document");
        }
    }
    // The Invoice class derives from the Document class
    class Invoice : Document
    {
        // Override the DoPrint method in the base class
        // to provide custom printing behaviour for an Invoice
        public override void DoPrint()
        {
            Console.WriteLine("Hello from DoPrint in Invoice");
        }
    }
    class PrePaidInvoice : Invoice
    {
        public override void DoPrint()
        {
            base.DoPrint();
            Console.WriteLine("Hello from DoPrint in PrePaidInvoice");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Invoice
            //Invoice c = new Invoice();
            //// This will run the SetDate method from Document
            //c.GetDate();
            //// This will run the DoPrint method from Invoice
            //c.DoPrint();
            PrePaidInvoice p = new PrePaidInvoice();
            p.GetDate();
            p.DoPrint();
            Console.ReadKey();
        }
    }
}
