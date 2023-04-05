using System;

namespace SehirTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sehirTahmin();
        }

        public static void sehirTahmin()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("---Şehir Tahmin Oyunu---");
            Console.WriteLine("------------------------");
            Console.Write("Kaç Şehir Olacak: ");
            int sehirSayi = Convert.ToInt32(Console.ReadLine());

            string[] sehirler = new string[sehirSayi];

            for (int i = 0; i < sehirSayi; i++)
            {
                Console.WriteLine((i + 1) + ". Şehri giriniz");
                sehirler[i] = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < sehirSayi; i++)
            {
                Console.WriteLine((i + 1) + ". Şehir: " + sehirler[i]);
            }

            randomSehir(sehirler);
        }

        public static void randomSehir(string[] sehirler)
        {
            int skor = 0;
            int hataSkoru = 0;


            while (skor < 5 && hataSkoru < 10)
            {
                Random random = new Random();
                int deger = random.Next(0, sehirler.Length);
                Console.WriteLine("Şehir tahmininde bulun");
                string tahmin = Console.ReadLine().ToLower();
                if (sehirler[deger] == tahmin)
                {
                    skor++;
                    Console.WriteLine("Tebrikler doğru tahmin. Skorunuz: " + skor);
                }
                else
                {
                    hataSkoru++;
                    Console.WriteLine("Üzgünüm yanlış tahmin. Tekrar deneyin. Hata skorunuz: " + hataSkoru);
                }
            }
            skorKontrol(skor, hataSkoru);
        }

        public static void skorKontrol(int skor, int hataSkoru)
        {
            if (skor == 5)
            {
                Console.WriteLine("Tebrikler kazandınız");
            }
            else if (hataSkoru == 10)

            {
                Console.WriteLine("Üzgünüm sistem kazandı");
            }
            else
            {
                Console.WriteLine("Bir hata var");
            }
        }

    }
}
