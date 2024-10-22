using System;
class Talaba_hisobot_kartasi{
    static void Main(){
        hisobot_yaratish();
    }

    static void hisobot_yaratish(){
        string[] fanlar = { "Matematika", "Fizika", "Kimyo", "Biologiya", "Tarix" };
        int[] baholar = new int[fanlar.Length];

        Console.WriteLine("Talaba ismini kiriting: ");
        string talabaIsmi = Console.ReadLine();
        int jamiBaholar = 0;
        int fanlarSoni = fanlar.Length;
        int i = 0;

        do{
            Console.WriteLine($"{fanlar[i]} bahosini kiriting   (0-100): ");
            if (int.TryParse(Console.ReadLine(), out baholar[i]) && baholar[i] >= 0 && baholar[i] <= 100){
                jamiBaholar += baholar[i];
                i++;
            }
            else{
                Console.WriteLine("Noto'g'ri baho.0 dan 100 gacha bo'lgan raqam kiriting.");
            }
        } while (i < fanlarSoni);

        double ortachaBaho = (double)jamiBaholar / fanlarSoni;
        Console.WriteLine($"\nTalaba: {talabaIsmi}");
        Console.WriteLine("Fanlar va baholar:");
        for (int j = 0; j < fanlarSoni; j++){
            Console.WriteLine($"{fanlar[j]}: {baholar[j]}");
        }

        Console.WriteLine($"O'rtacha baho: {ortachaBaho:F2}"); 
        if (ortachaBaho >= 50){
            Console.WriteLine("Yakuniy baho: O'tdi");
        }
        else{
            Console.WriteLine("Yakuniy baho: O'tmadi");
        }
    }
}
