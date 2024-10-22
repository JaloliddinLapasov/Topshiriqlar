using System;
class Vazifa_Dasturi{
    static void Main(){
        VazifaListBoshqarish();
    }
    static void VazifaListBoshqarish(){
        string[] vazifalar = new string[100]; 
        bool[] bajarilgan = new bool[100];    
        int vazifaSoni = 0;                   
        string tanlov;
        do{ Console.WriteLine("\nVazifalar jadvali Dasturi");
            Console.WriteLine("1. Yangi vazifa qo'shish");
            Console.WriteLine("2. Vazifani olib tashlash");
            Console.WriteLine("3. Vazifani bajarilgan deb belgilash");
            Console.WriteLine("4. Vazifalar ro'yxatini ko'rish");
            Console.WriteLine("5. Dasturdan chiqish");
            Console.Write("Tanlovingizni kiriting: ");
            tanlov = Console.ReadLine();
            switch (tanlov){
                case "1":
                    Console.Write("Vazifa matnini kiriting: ");
                    string yangiVazifa = Console.ReadLine();
                    if (vazifaSoni < 100){
                        vazifalar[vazifaSoni] = yangiVazifa;
                        bajarilgan[vazifaSoni] = false; 
                        vazifaSoni++;
                    }
                    else{
                        Console.WriteLine("Ro'yxat to'lgan! Yana vazifa qo'shish uchun joy yo'q.");
                    }
                    break;

                case "2":
                    Console.Write("Olib tashlamoqchi bo'lgan vazifaning raqamini kiriting (1 dan " + vazifaSoni + " gacha): ");
                    int olibTashlashRaqami = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (olibTashlashRaqami >= 0 && olibTashlashRaqami < vazifaSoni)
                    {
                        for (int i = olibTashlashRaqami; i < vazifaSoni - 1; i++){
                            vazifalar[i] = vazifalar[i + 1];
                            bajarilgan[i] = bajarilgan[i + 1];
                        }
                        vazifaSoni--;
                    }
                    else{
                        Console.WriteLine("Noto'g'ri raqam! Vazifa mavjud emas.");
                    }
                    break;

                case "3":
                    Console.Write("Bajarilgan deb belgilamoqchi bo'lgan vazifaning raqamini kiriting (1 dan " + vazifaSoni + " gacha): ");
                    int bajarilganDebBelgilashRaqami = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (bajarilganDebBelgilashRaqami >= 0 && bajarilganDebBelgilashRaqami < vazifaSoni){
                        bajarilgan[bajarilganDebBelgilashRaqami] = true;
                    }
                    else{
                        Console.WriteLine("Noto'g'ri raqam! Vazifa mavjud emas.");
                    }
                    break;

                case "4":
                    Console.WriteLine("\nVazifalar ro'yxati:");
                    for (int i = 0; i < vazifaSoni; i++){
                        string status = bajarilgan[i] ? "[Bajarilgan]" : "[Bajarilmagan]";
                        Console.WriteLine($"{i + 1}. {vazifalar[i]} {status}");
                    }
                    break;

                case "5":
                    Console.WriteLine("Dastur tugadi.");
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov, qaytadan urinib ko'ring.");
                    break;
            }

        } while (tanlov != "5");
    }
}
