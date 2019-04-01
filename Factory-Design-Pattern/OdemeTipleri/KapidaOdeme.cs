using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.OdemeTipleri
{
    public class KapidaOdeme : IOdeme
    {
        public bool OdemeYap()
        {
            return this.KapidaOdemeYap();
        }

        private bool KapidaOdemeYap()
        {
            // Kullanıcı Seçimine Göre İşlem Yapılır. Session'daki kullanıcı seçimine bakılır.
            // Kapida ödeme nakit seçildiyse
            if (SessionManager.GetInstance().GetKapidaOdemeTipi() == Cons.KapidaOdemeTipi.KapidaNakit)
                return this.KapidaNakit();
            // Kapıda kredi kartı seçildiyse
            else if (SessionManager.GetInstance().GetKapidaOdemeTipi() == Cons.KapidaOdemeTipi.KapidaKrediKarti)
                return this.KapidaKrediKarti();
            // varsayılan ödeme Kapida ödeme nakit
            else
                return this.KapidaNakit();
        }

        private bool KapidaKrediKarti()
        {
            Console.WriteLine("Kapıda ödeme kredi kartı seçildi");
            return true;
        }

        private bool KapidaNakit()
        {
            Console.WriteLine("Kapıda ödeme nakit seçildi");
            return true;
        }
    }
}
