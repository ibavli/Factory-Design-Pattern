using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.Bankalar
{
    public interface IBank
    {
        int TaksitYap();
        string BankaAdi();
    }
}
