using System;

class BankAccount
{
    static void Main()
    {
    System.Console.WriteLine("Xush kelibsiz!");
    StartBankOperatsiya();
    }

    static double[] hisob_qoldigi={5000.000, 3000.000, 1000000.000};
    static void StartBankOperatsiya()
    {
    bool chiqish = false;

    do
    {
    Menu();
    int tanlov = int.Parse(Console.ReadLine());
    switch (tanlov)
    {
        case 1:
            PulQoyish();
            break;
        case 2:
            PulYechish();
            break;
        case 3:
            HisobniTekshirish();
            break;
        case 4:
            chiqish = true;
            System.Console.WriteLine("Tizimdan chiqildi");
            break;
        default:
            System.Console.WriteLine("Tanlov xato");
            break;
    }
            Console.WriteLine();
    }
        while (!chiqish);
    }

    static void Menu()
    {
        System.Console.WriteLine("Tanlang:");
        System.Console.WriteLine("1. Pul qo'yish");
        System.Console.WriteLine("2. Pul yechish");
        System.Console.WriteLine("3. Hisobni tekshirish");
        System.Console.WriteLine("4. Chiqish");
    }

    static void PulQoyish()
    {
        System.Console.WriteLine("Hisob raqamni kiriting (1, 2, 3):");
        int depozit_hisobi = int.Parse(Console.ReadLine()) - 1;
        if (depozit_hisobi >= 0 && depozit_hisobi < hisob_qoldigi.Length)
            {
            System.Console.WriteLine("Qancha pul qo'ymoqchisiz:");
            double depozit_miqdori = double.Parse(Console.ReadLine());
            hisob_qoldigi[depozit_hisobi] += depozit_miqdori;
            System.Console.WriteLine($"{depozit_miqdori} miqdorida pul muvafaqiyatli qo'yildi.");
            }
        else
        {
            System.Console.WriteLine("Noto'g'ri hisob raqam!!!");
        }
    }

    static void PulYechish()
    {
        System.Console.WriteLine("Hisob raqamni kiriting (1, 2, 3):");
        int yechish_hisobi = int.Parse(Console.ReadLine()) - 1;
        if (yechish_hisobi >= 0 && yechish_hisobi < hisob_qoldigi.Length)
        {
            System.Console.WriteLine("Qancha pul yechmoqchisiz:");
            double yechish_miqdori = double.Parse(Console.ReadLine());

            if (yechish_miqdori <= hisob_qoldigi[yechish_hisobi])
            {
            hisob_qoldigi[yechish_hisobi] -= yechish_miqdori;
            System.Console.WriteLine($"{yechish_miqdori} miqdorda pul muvafaqiyatli yechildi.");
            }          
            else
            {
            System.Console.WriteLine("Hisob yetarli emas.");
            }
        }
        else
        {
        System.Console.WriteLine("Noto'g'ri hisob raqam!!!");
        }
    }

    static void HisobniTekshirish()
    {
        System.Console.WriteLine("Hisob raqamni kiriting (1, 2, 3):");
        int hisob_korish = int.Parse(Console.ReadLine()) - 1;

        if (hisob_korish >= 0 && hisob_korish < hisob_qoldigi.Length)
        {
            System.Console.WriteLine($"{hisob_korish + 1}-hisob qoldigi: {hisob_qoldigi[hisob_korish]}");
        }
        else
        {
            System.Console.WriteLine("Noto'g'ri hisob raqam!!!");
        }
    }
}
