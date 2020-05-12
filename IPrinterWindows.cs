
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    public interface IPrinterWindows
    {
        void Show();
        /*{
            Console.WriteLine("\nPrinter display dimension");
        }*/
        void Print();
        /*{
            Console.WriteLine("\nPrinter printing");
        }*/
    }
}