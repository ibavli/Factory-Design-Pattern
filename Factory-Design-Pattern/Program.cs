using Factory_Design_Pattern.OdemeTipleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OdemeFactory factory = new OdemeFactory();
            IOdeme odeme = factory.OdemeNesnesiOlustur("KapidaOdeme");
            odeme.OdemeYap();

            Console.ReadKey();
        }
    }
}
