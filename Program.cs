using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinterWindows Printer;
            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int NomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (NomorPrinter == 1)
                Printer = new Epson();
            else if (NomorPrinter == 2)
                Printer = new Canon();
            else
                Printer = new LaserJet();

            Printer.Show();
            Printer.Print();

            Console.ReadKey();
        }
    }
}