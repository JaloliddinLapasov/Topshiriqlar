using System;

class Film_bileti_bron
{
    static void Main()
    {
        BronQilishTizimi();
    }

    static void BronQilishTizimi(){
        int orindiqlarSoni = 10;
        string[] orindiqlar = new string[orindiqlarSoni];
        bool[] mavjudlik = new bool[orindiqlarSoni];
        for (int i = 0; i < orindiqlarSoni; i++){
            orindiqlar[i] = $"O'rindiq {i + 1}";
            mavjudlik[i] = true; 
        }
        int tanlov = 0;

        do
        {
            Console.WriteLine("\nMavjud o'rindiqlar:");
            for (int i = 0; i < orindiqlarSoni; i++){
                if (mavjudlik[i])
                {
                Console.WriteLine($"{orindiqlar[i]} - Mavjud");
                }
                else
                {
                Console.WriteLine($"{orindiqlar[i]} - Band");
                }
            }

            Console.WriteLine("\nQaysi o'rindiqni bron qilishni xohlaysiz? (1-10) yoki tizimdan chiqish uchun 0:");
            if (int.TryParse(Console.ReadLine(), out tanlov) && (tanlov >= 0 && tanlov <= orindiqlarSoni))
            {
                if (tanlov == 0)
                {
                    Console.WriteLine("Dasturdan chiqyapsiz...");
                    break;
                }

                int orindiqIndex = tanlov - 1;
                if (mavjudlik[orindiqIndex])
                {
                    mavjudlik[orindiqIndex] = false; 
                    Console.WriteLine($"{orindiqlar[orindiqIndex]} bron qilindi.");
                }
                else
                {
                    Console.WriteLine($"{orindiqlar[orindiqIndex]} allaqachon band qilingan.");
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri tanlov. Iltimos, 1 dan 10 gacha yoki 0 ni kiriting.");
            }

        } while (true); 
    }
}
