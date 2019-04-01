using Factory_Design_Pattern.Bankalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
    public class BankaFactory
    {
        // istemci tarafından gelen ödeme tipine göre ödeme nesnesi döner.
        public IBank BankaNesnesiOlustur(string banka)
        {
            // Banka tipi XBANK ise
            if (banka == Cons.Bankalar.XBANK)
                return new XBank();
            // Banka tipi YBANK ise
            if (banka == Cons.Bankalar.YBANK)
                return new YBank();

            // varsayılan banka 
            return new XBank();
        }
    }
}
