using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemogramanMinggu10
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("\nNomor Printer[1...3]: ");

            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            printer.Jenis = nomorPrinter;

            IPrinterWindows? show = null, print = null;

            if(printer.Jenis == 1 )
            {
                show = new Epson();
                print = new Epson();
            }
            else if(printer.Jenis == 2)
            {
                show = new Canon();
                print = new Canon();
            }
            else if (printer.Jenis == 3)
            {
                show = new LaserJet();
                print = new LaserJet();
            }
            else
            {
                Console.WriteLine("\nPilihan Invalid");
            }

            show?.Show(printer);
            print?.Print(printer);
            Console.ReadKey();
        }
    }
}

