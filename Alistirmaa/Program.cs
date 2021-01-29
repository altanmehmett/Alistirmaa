using System;

namespace Alistirmaa
{
    class Program 
    {
        static void Main(string[] args)
        {
            string Ad, Soyad, Sınıf, No;
            Console.WriteLine("***ÖĞRENCİ BİLGİLERİ***");
            Console.WriteLine("Ad :" );
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            Soyad = Console.ReadLine();
            Console.WriteLine("Sınıf:");
            Sınıf = Console.ReadLine();
            Console.WriteLine("No:");
            No = Console.ReadLine();

            int sınav1, sınav2, proje, ortalama;
            Console.WriteLine("***SINAV BİLGİLERİ***");
            Console.WriteLine("Sınav 1i Giriniz:");
            sınav1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sınav 2yi Giriniz:");
            sınav2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Proje Notunu Giriniz:");
            proje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***Ortalama Notu***");
            ortalama = (sınav1 + sınav2 + proje) / 3;
            Console.WriteLine("ORTALAMA:" + ortalama);


        }
    }
}
