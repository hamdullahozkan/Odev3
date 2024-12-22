using System;

class Program
{
    static void Main(string[] args)
    {
        int dogruSayisi = 0; // Doğru cevap sayısını tutan değişken

        Console.WriteLine("Kim Milyoner Olmak İster Yarışmasına Hoş Geldiniz!");
        Console.WriteLine();

        // 1. Soru
        Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
        Console.WriteLine("a) Lama  b) Deve");
        Console.Write("Cevabınız: ");
        string cevap1 = Console.ReadLine().ToLower(); // Kullanıcı girişi, büyük/küçük harf duyarlılığı kaldırıldı.

        if (cevap1 == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: a) Lama");
        }

        // Eğer doğru cevap sayısı büyük ödülü kazanmak için yeterli olamayacaksa yarışmayı sonlandırabiliriz
        if (dogruSayisi == 0)
        {
            Console.WriteLine("Maalesef büyük ödülü kazanma şansınız kalmadı.");
            return;
        }

        Console.WriteLine();

        // 2. Soru
        Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?");
        Console.WriteLine("a) Venüs  b) Mars");
        Console.Write("Cevabınız: ");
        string cevap2 = Console.ReadLine().ToLower();

        if (cevap2 == "a")
        {
            Console.WriteLine("Doğru cevap!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: a) Venüs");
        }

        // Eğer doğru cevap sayısı büyük ödülü kazanmak için yeterli olamayacaksa yarışmayı sonlandırabiliriz
        if (dogruSayisi < 2)
        {
            Console.WriteLine("Maalesef büyük ödülü kazanma şansınız kalmadı.");
            return;
        }

        Console.WriteLine();

        // 3. Soru
        Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
        Console.WriteLine("a) 7  b) 12");
        Console.Write("Cevabınız: ");
        string cevap3 = Console.ReadLine().ToLower();

        if (cevap3 == "b")
        {
            Console.WriteLine("Doğru cevap!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap! Doğru cevap: b) 12");
        }

        Console.WriteLine();

        // Sonuç
        if (dogruSayisi >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız! hayırlı, uğurlu olsun.");
        }
        else
        {
            Console.WriteLine("Maalesef büyük ödülü kazanamadınız seneye yine bekleriz. Tekrar deneyin!");
        }
    }
}

