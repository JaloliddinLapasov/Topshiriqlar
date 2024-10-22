using System;

class Parvoz


{
    static void Main(){
        Parvozlarni_bronlash();
    }

    static void Parvozlarni_bronlash(){
        string[] parvozlar = { "Parvoz A", "Parvoz B", "Parvoz C" };
        int[] mavjudJoylar = { 5, 3, 4 }; 
        int tanlov = -1;
        do{
            Console.WriteLine("\nMavjud parvozlar:");
            for (int i = 0; i < parvozlar.Length; i++){
                Console.WriteLine($"{i + 1}. {parvozlar[i]} - Mavjud joylar: {mavjudJoylar[i]}");
            }

            Console.Write("\nQaysi parvozni bron qilishni xohlaysiz? (1-3, 0 - chiqish): ");
            if (int.TryParse(Console.ReadLine(), out tanlov)){
                if (tanlov == 0){
                    Console.WriteLine("Dasturdan chiqyapsiz...");
                    break;
                }
                if (tanlov < 1 || tanlov > parvozlar.Length){
                    Console.WriteLine("Noto'g'ri tanlov. Iltimos, qayta urinib ko'ring.");
                    continue;
                }
                int parvozIndeksi = tanlov - 1;
                if (mavjudJoylar[parvozIndeksi] > 0){
                    mavjudJoylar[parvozIndeksi]--; 
                    Console.WriteLine($"{parvozlar[parvozIndeksi]} uchun joy bron qilindi.");
                    Console.ReadKey();
                }
                else{
                    Console.WriteLine($"{parvozlar[parvozIndeksi]} uchun joy mavjud emas.");
                }

            }
            else{
                Console.WriteLine("Iltimos, raqam sifatida tanlov kiriting.");
            }

        } while (true); 
    }
}
