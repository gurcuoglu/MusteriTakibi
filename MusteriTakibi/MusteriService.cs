using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriTakibi
{
    class MusteriService
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı : "+musteri.Adi);
            Console.WriteLine("Müşteri Soyadi : "+musteri.Soyadi);
            Console.WriteLine("Bakiyesi : "+musteri.Bakiye);
        }

        public void MusteriCikar(Musteri musteri)
        {
            musteri.Adi = "Adsız";
            musteri.Bakiye = 0;
            musteri.Cinsiyet = default;
            musteri.Id = 0;
            musteri.Soyadi = "Adsız";
            musteri.TcNo = "###################";
            musteri.Yas = 0;
            
        }

        public void BakiyeGuncelle(Musteri musteri, float bakiye)
        {
            musteri.Bakiye = bakiye;
            
        }
    }
}
