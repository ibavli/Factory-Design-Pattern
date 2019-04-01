using Factory_Design_Pattern.Bankalar;
using Factory_Design_Pattern.Cons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.OdemeTipleri
{
    public class KrediKarti : IOdeme
    {
        public bool OdemeYap()
        {
            return this.KrediKartıCekimYap();
        }

        private bool KrediKartıCekimYap()
        {
            // Kullanıcı Seçimine Göre İşlem Yapılır. Session'daki kullanıcı seçimine bakılır.
            // Taksit seçildiyse
            if (SessionManager.GetInstance().GetKrediKartiOdemeTipi() == KrediKartiOdemeTipi.Taksit)
                return this.TaksitYap();
            // Tek çekim seçildiyse
            else if (SessionManager.GetInstance().GetKrediKartiOdemeTipi() == KrediKartiOdemeTipi.TekCekim)
                return this.TekCekimYap();
            // varsayılan ödeme tek çekim
            else
                return this.TekCekimYap();
        }

        private bool TekCekimYap()
        {
            Console.WriteLine("Kredi kartı ile tek çekim yapıldı");
            return true;
        }

        private bool TaksitYap()
        {
            // Kullanıcı Seçimine Göre İşlem Yapılır. Session'daki kullanıcı seçimine bakılır.
            // Banka Fabrikasi Oluşturulur.
            BankaFactory bankaFactory = new BankaFactory();
            // Kullanıcının seçtiği bankaya göre banka nesnesi oluşturulur.
            IBank banka = bankaFactory.BankaNesnesiOlustur(SessionManager.GetInstance().GetBanka());
            banka.TaksitYap();
            Console.WriteLine("Kredi kartı ile " + banka.BankaAdi() + " bankasına " + banka.TaksitYap() + " taksit yapıldı.");
            return true;
        }
    }
}
