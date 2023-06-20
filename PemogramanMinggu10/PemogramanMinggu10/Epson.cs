using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemogramanMinggu10
{
    public class Epson : IPrinterWindows
    {
        public Epson()
        {

        }

        public void Show(Printer jenis)
        {
            Console.WriteLine("\nEpson display dimension: 10*11");
        }
        public void Print(Printer jenis)
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
