using System;

namespace urunlerim
{
    class Program
    {
        static void Main(string[] args)
        {

            islemciler urun1 = new islemciler();
            urun1.marka = "intel";
            urun1.model = "i7-3.nesil";
            urun1.adet = 50;
            urun1.fiyat = 350;


            islemciler urun2= new islemciler();
            urun2.marka = "intel";
            urun2.model = "i7-3.nesil";
            urun2.adet = 50;
            urun2.fiyat = 350;
            islemciler urun3 = new islemciler();
            urun3.marka = "intel";
            urun3.model = "i5-4.nesil";
            urun3.adet = 47;
            urun3.fiyat = 250;
            islemciler urun4= new islemciler();
            urun4.marka = "intel";
            urun4.model = "i7-9.nesil";
            urun4.adet = 10;
            urun4.fiyat = 850;
            islemciler urun5 = new islemciler();
            urun5.marka = "intel";
            urun5.model = "i9-10.nesil";
            urun5.adet = 100;
            urun5.fiyat = 5600;
            islemciler urun6 = new islemciler();
            urun6.marka = "amd";
            urun6.model = "ryzen7";
            urun6.adet = 80;
            urun6.fiyat = 1200;

            islemciler[] urunler = new islemciler[] {urun1,urun2,urun3,urun4,urun5,urun6 };


            foreach (var islemciler in urunler)
            {
                Console.WriteLine(islemciler.marka+" "+islemciler.model+" "+islemciler.adet+"adet "+islemciler.fiyat+"TL ");
            }

    }


        class islemciler
        {
            public string marka{ get; set; }

            public string model { get; set; }

            public int adet { get; set; }

            public int fiyat { get; set; }

        }

    }
}
