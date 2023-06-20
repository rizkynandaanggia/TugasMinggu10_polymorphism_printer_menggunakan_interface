using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PemogramanMinggu10
{
    public class Canon : IPrinterWindows
    {
        public Canon()
        {

        }
        public void Show(Printer jenis)
        {
        Console.WriteLine("\nCanon display dimension: 9.5*12");
        }
        public void Print(Printer jenis)
        {
        Console.WriteLine("Canon printer printing....");
        }
        
    }
}
