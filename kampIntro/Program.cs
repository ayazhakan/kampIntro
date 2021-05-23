using System;

namespace kampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "hakan";
            string soyad = "ayaz";
            int yas = 22;
           
            bool erkekmi = true;

            if (erkekmi == true)
            {
                Console.WriteLine(ad);
                Console.WriteLine(soyad);
                
            }
            else { 
                Console.WriteLine("yanlış kişi");
            }

        }
    }
}
