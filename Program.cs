using System;

namespace Okul
{
    class Program
    {
        static void Main(string[] args)
        {
            double puan;
            int notu=0;
            Console.Write("Öğrenci Puanı: ");
            puan = Convert.ToDouble(Console.ReadLine());
            if (puan<0)
            {
                Console.WriteLine("Lütfen 0-100 arasında bir değer giriniz");
            }
            else if (puan < 25)
            {
                notu = 0;
            }
            else if (
                puan <= 44 //else if (puan < 45)
            )
            {
                notu = 1;
            }
            else if (puan < 55)
            {
                notu = 2;
            }
            else if (puan < 70)
            {
                notu = 3;
            }
            else if (puan < 85)
            {
                notu = 4;
            }
            else if (puan <= 100)
            {
                notu = 5;
            }
            else
            {
                Console.WriteLine("Lütfen 0-100 arasında bir değer giriniz");
            }

            //Console.WriteLine("Öğrenci Puanı : {0}, Öğrenci Notu: {1}", puan, notu);
            if (puan>0 && puan<=100)
            {
                 Console
                .WriteLine("Öğrenci Puanı :" + puan + " Öğrenci Notu: " + notu);
            }
           
        }
    }
}
