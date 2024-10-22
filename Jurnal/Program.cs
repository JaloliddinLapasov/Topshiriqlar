using System;

class Baholar_tizimi
{
    static void Main(){
        BaholarniBoshqarish();
    }

    static void BaholarniBoshqarish(){
        string[] talabalar = { "Jamshid", "Davron", "Ruslan", "Mirxoja", "Asilbek" };
        int[] baholar = { 85, 90, 78, 88, 92 }; 
        string davomEtish;
        do{
            Console.Write("Talabaning ismini kiriting: ");
            string talabaniQidirish = Console.ReadLine();
            int index = Qidirish(talabalar, talabaniQidirish);
            if (index != -1){
                Console.WriteLine($"{talabalar[index]} ning bahosi: {baholar[index]}");
            }
            else{
                Console.WriteLine("Talaba topilmadi.");
            }
            Console.Write("Yana qidirishni xohlaysizmi? (h/y): ");
            davomEtish = Console.ReadLine().ToLower();

        } while (davomEtish == "h");
    }

    static int Qidirish(string[] talabalar, string talabaniQidirish){
        for (int i = 0; i < talabalar.Length; i++){
            if (talabalar[i].Equals(talabaniQidirish, StringComparison.OrdinalIgnoreCase))
            {
                return i; 
            }
        }
        return -1; 
    }
}
