using System;
using System.Collections.Generic;

class KursYozilishTizimi
{
    static void Main()
    {
        YozilishTizimi();
    }

    static void YozilishTizimi()
    {
        string[] kurslar = { "Matematika", "Fizika", "Informatika", "Kimyo" };
        int[] mavjudJoylar = { 2, 3, 1, 2 }; 
        List<string>[] yozilganTalabalar = new List<string>[kurslar.Length];

        for (int i = 0; i < kurslar.Length; i++)
        {
            yozilganTalabalar[i] = new List<string>();
        }

        string davomEtish;
        do
        {
            Console.WriteLine("Quyidagi kurslar mavjud:");
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {kurslar[i]} (Mavjud joylar: {mavjudJoylar[i]})");
            }

            Console.Write("Qaysi kursga yozilmoqchisiz? (1-4): ");
            int kursTanlovi = Convert.ToInt32(Console.ReadLine()) - 1;

            if (kursTanlovi >= 0 && kursTanlovi < kurslar.Length)
            {
                if (mavjudJoylar[kursTanlovi] > 0)
                {
                    Console.Write("Ismingizni kiriting: ");
                    string talabaIsmi = Console.ReadLine();

                    yozilganTalabalar[kursTanlovi].Add(talabaIsmi);
                    mavjudJoylar[kursTanlovi]--;

                    Console.WriteLine($"{talabaIsmi} {kurslar[kursTanlovi]} kursiga yozildi.");
                }
                else
                {
                    Console.WriteLine($"{kurslar[kursTanlovi]} kursida joylar mavjud emas.");
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Iltimos, 1 dan 4 gacha raqam kiriting.");
            }

            Console.Write("Yana yozilmoqchimisiz? (h/y): ");
            davomEtish = Console.ReadLine().ToLower();

        } while (davomEtish == "h");

        YakuniyRoyxat(kurslar, yozilganTalabalar);
    }

    static void YakuniyRoyxat(string[] kurslar, List<string>[] yozilganTalabalar)
    {
        Console.WriteLine("\nYakuniy talabalar ro'yxati:");
        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine($"{kurslar[i]}: ");
            foreach (var talaba in yozilganTalabalar[i])
            {
                Console.WriteLine($" - {talaba}");
            }
            Console.WriteLine();
        }
    }
}
