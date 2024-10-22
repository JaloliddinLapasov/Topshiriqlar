using System;

class KutubxonaBoshqaruvi
{
    static void Main(){
        KutubxonaTizimi();
    }

    static void KutubxonaTizimi(){
        string[] kitoblar = { "Kitob A", "Kitob B", "Kitob C", "Kitob D" };
        bool[] mavjud = new bool[kitoblar.Length]; 
        string davomEtish;
        do{
            Console.WriteLine("\nMavjud kitoblar:");
            for (int i = 0; i < kitoblar.Length; i++){
                string holat = mavjud[i] ? " (qarzga olingan)" : " (mavjud)";
                Console.WriteLine($"{i + 1}. {kitoblar[i]}{holat}");
            }

            Console.WriteLine("\n1. Kitobni qarzga olish");
            Console.WriteLine("2. Kitobni qaytarish");
            Console.Write("Amalni tanlang (1 yoki 2): ");
            int amal = Convert.ToInt32(Console.ReadLine());

            if (amal == 1){
                Console.Write("Qarzga olmoqchi bo'lgan kitob raqamini kiriting: ");
                int kitobRaqami = Convert.ToInt32(Console.ReadLine()) - 1;

                if (kitobRaqami >= 0 && kitobRaqami < kitoblar.Length){
                    if (!mavjud[kitobRaqami]){
                        mavjud[kitobRaqami] = true; 
                        Console.WriteLine($"{kitoblar[kitobRaqami]} kitobi qarzga olindi.");
                    }
                    else{
                        Console.WriteLine($"{kitoblar[kitobRaqami]} kitobi allaqachon qarzga olingan.");
                    }
                }
                else{
                    Console.WriteLine("Noto'g'ri kitob raqami.");
                }
            }
            else if (amal == 2){
                Console.Write("Qaytarmoqchi bo'lgan kitob raqamini kiriting: ");
                int kitobRaqami = Convert.ToInt32(Console.ReadLine()) - 1;

                if (kitobRaqami >= 0 && kitobRaqami < kitoblar.Length){
                    if (mavjud[kitobRaqami]){
                        mavjud[kitobRaqami] = false; 
                        Console.WriteLine($"{kitoblar[kitobRaqami]} kitobi qaytarildi.");
                    }
                    else{
                        Console.WriteLine($"{kitoblar[kitobRaqami]} kitobi mavjud emas.");
                    }
                }
                else{
                    Console.WriteLine("Noto'g'ri kitob raqami.");
                }
            }
            else{
                Console.WriteLine("Noto'g'ri amal tanlandi.");
            }

            Console.Write("Yana amal bajarishni xohlaysizmi? (h/y): ");
            davomEtish = Console.ReadLine().ToLower();

        } while (davomEtish == "h");

        Console.WriteLine("Dastur tugadi.");
    }
}
