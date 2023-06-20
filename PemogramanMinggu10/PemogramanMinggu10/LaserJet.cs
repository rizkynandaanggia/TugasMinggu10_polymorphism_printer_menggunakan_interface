
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemogramanMinggu10
{
    public class LaserJet : IPrinterWindows
    {
        public LaserJet()
        {

        }
        public void Show(Printer jenis)
        {
            Console.WriteLine("\nLaserJet display dimension: 12*12");
        }
        public void Print(Printer jenis)
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
