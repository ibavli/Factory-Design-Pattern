using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.OdemeTipleri
{
    //Alt sınıfları türeteceğimiz arayüz
    public interface IOdeme
    {
        //Ortak fonksiyon
        bool OdemeYap();
    }
}
