using Factory_Design_Pattern.Cons;
using Factory_Design_Pattern.OdemeTipleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class OdemeFactory
    {
        //İstemci tarafından gelen ödeme tipine göre ödeme nesnesi döner.
        public IOdeme OdemeNesnesiOlustur(string odemeTipi)
        {
            // ödeme tipi kredi kartı ise.
            if (odemeTipi == OdemeTipi.KREDIKARTI)
                return new KrediKarti();
            // ödeme tipi havale ise.
            if (odemeTipi == OdemeTipi.BANKAHAVALESI)
                return new BankaHavalesi();

            // varsayılan ödeme tipi
            return new KrediKarti();
        }
    }
}