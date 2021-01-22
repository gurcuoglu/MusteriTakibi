using System;

namespace MusteriTakibi
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Musteri costumer1 = new Musteri() { Adi = "Aykut", Id = 1, Bakiye = 100 / 3, Soyadi = "GÜRCÜOĞLU", Cinsiyet = false, TcNo = "12345678912", Yas=24};

            MusteriService musteriService = new MusteriService();

            musteriService.MusteriEkle(costumer1);
            musteriService.MusteriCikar(costumer1);
            musteriService.BakiyeGuncelle(costumer1, 80);
            //...

        }
    }
}
