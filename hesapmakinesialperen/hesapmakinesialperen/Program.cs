using System;

namespace BasitHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan iki sayı alınıyor
            Console.WriteLine("Lütfen ilk sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan yapmak istediği işlem isteniyor
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1- Toplama (+)");
            Console.WriteLine("2- Çıkarma (-)");
            Console.WriteLine("3- Çarpma (*)");
            Console.WriteLine("4- Bölme (/)");

            int secim = Convert.ToInt32(Console.ReadLine()); // Seçilen işlem

            // İşlem sonucu
            double sonuc = 0;
            bool islemGecerli = true; // İşlem geçerliliğini kontrol eden değişken

            // switch-case yapısı ile işlem seçimi
            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Toplama sonucu: {sonuc}");
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Çıkarma sonucu: {sonuc}");
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Çarpma sonucu: {sonuc}");
                    break;
                case 4:
                    // Bölme işleminde 0'a bölme kontrolü
                    if (sayi2 != 0)
                    {
                        sonuc = (double)sayi1 / sayi2; // Ondalıklı bölme
                        Console.WriteLine($"Bölme sonucu: {sonuc}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayı 0'a bölünemez!");
                        islemGecerli = false;
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen 1-4 arasında bir değer giriniz.");
                    islemGecerli = false;
                    break;
            }

            // Geçerli işlemse sonucu göster
            if (islemGecerli)
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }

            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
