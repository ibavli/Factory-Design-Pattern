using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.OdemeTipleri
{
    public class BankaHavalesi : IOdeme
    {
        public bool OdemeYap()
        {
            return this.BankaHavalesiKontrolEt();
        }

        private bool BankaHavalesiKontrolEt()
        {
            Console.WriteLine("Banka hesabı kontrol edildi, havale gelmiş.");
            return true;
        }
    }
}
