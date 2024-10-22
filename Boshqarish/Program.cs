using System;
class InventarizatsiyaBoshqaruvi{
    static void Main(){
        InventarizatsiyaTizimi();
    }

    static void InventarizatsiyaTizimi()
    {
        string[] mahsulotlar = new string[100];
        int[] miqdorlar = new int[100];
        int mahsulotSoni = 0; 
        string davomEtish;

        do{
            Console.WriteLine("\nInventarizatsiya boshqaruv tizimi:");
            Console.WriteLine("1.Yangi mahsulot qo'shish");
            Console.WriteLine("2.Mahsulot miqdorini yangilash");
            Console.WriteLine("3.Mahsulotni olib tashlash");
            Console.WriteLine("4.Inventarizatsiya ro'yxatini ko'rsatish");
            Console.Write("Amalni tanlang (1-4): ");
            int amal = Convert.ToInt32(Console.ReadLine());
            switch (amal){
                case 1: 
                    if (mahsulotSoni < 100) {
                        Console.Write("Mahsulot nomini kiriting: ");
                        mahsulotlar[mahsulotSoni] = Console.ReadLine();
                        Console.Write("Mahsulot miqdorini kiriting: ");
                        miqdorlar[mahsulotSoni] = Convert.ToInt32(Console.ReadLine());
                        mahsulotSoni++;
                        Console.WriteLine("Mahsulot qo'shildi.");
                    }
                    else{
                        Console.WriteLine("Mahsulotlar ro'yxati to'liq!");
                    }
                    break;

                case 2: 
                    Console.Write("Yangilamoqchi bo'lgan mahsulot raqamini kiriting (1 - {0}): ", mahsulotSoni);
                    int yangilashRaqami = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (yangilashRaqami >= 0 && yangilashRaqami < mahsulotSoni)
                    {
                        Console.Write("Yangi miqdorni kiriting: ");
                        miqdorlar[yangilashRaqami] = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Mahsulot miqdori yangilandi.");
                    }
                    else{
                        Console.WriteLine("Noto'g'ri mahsulot raqami.");
                    }
                    break;

                case 3: 
                    Console.Write("Olib tashlamoqchi bo'lgan mahsulot raqamini kiriting (1 - {0}): ", mahsulotSoni);
                    int olibTashlashRaqami = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (olibTashlashRaqami >= 0 && olibTashlashRaqami < mahsulotSoni)
                    {
                        for (int i = olibTashlashRaqami; i < mahsulotSoni - 1; i++)
                        {
                            mahsulotlar[i] = mahsulotlar[i + 1];
                            miqdorlar[i] = miqdorlar[i + 1];
                        }
                        mahsulotSoni--;
                        Console.WriteLine("Mahsulot olib tashlandi.");
                    }
                    else
                    {
                        Console.WriteLine("Noto'g'ri mahsulot raqami.");
                    }
                    break;

                case 4: 
                    Console.WriteLine("\nInventarizatsiya ro'yxati:");
                    for (int i = 0; i < mahsulotSoni; i++)
                    {
                        Console.WriteLine($"{i + 1}. {mahsulotlar[i]} - {miqdorlar[i]} dona");
                    }
                    break;

                default:
                    Console.WriteLine("Noto'g'ri amal tanlandi.");
                    break;
            }

            Console.Write("Yana amal bajarishni xohlaysizmi? (h/y): ");
            davomEtish = Console.ReadLine().ToLower();

        } while (davomEtish == "h");

        Console.WriteLine("Dastur tugadi.");
    }
}
