using System;

class MehmonxonaBronlashTizimi{
    static void Main(){
        MehmonxonaBronlash();
    }

    static void MehmonxonaBronlash(){
        int[] xonaRaqamlari = {101, 102, 103, 104, 105 };
        bool[] mavjudlik = { true, true, false, true, true };
        int tanlov;
        do{
            Console.WriteLine("\nMavjud xonalar:");
            for (int i = 0; i < xonaRaqamlari.Length; i++){
                string status = mavjudlik[i] ? "Mavjud" : "Band";
                Console.WriteLine($"{xonaRaqamlari[i]} - {status}");
            }
            Console.WriteLine("\nBron qilish yoki bekor qilish uchun xona raqamini kiriting (0 - chiqish): ");
            if (int.TryParse(Console.ReadLine(), out tanlov)) {
                if (tanlov == 0)
                {
                    Console.WriteLine("Dasturdan chiqyapsiz...");
                    break;
                }
                int xonaIndeksi = Array.IndexOf(xonaRaqamlari, tanlov);
                if (xonaIndeksi >= 0)
                {
                    if (mavjudlik[xonaIndeksi])
                    {
                        mavjudlik[xonaIndeksi] = false;
                        Console.WriteLine($"{xonaRaqamlari[xonaIndeksi]} xonasi bron qilindi.");
                    }
                    else
                    {
                        mavjudlik[xonaIndeksi] = true;
                        Console.WriteLine($"{xonaRaqamlari[xonaIndeksi]} xonasi bekor qilindi.");
                    }
                }
                else
                {
                    Console.WriteLine("Noto'g'ri xona raqami. Iltimos, qayta urinib ko'ring.");
                }
            }
            else
            {
                Console.WriteLine("Iltimos, raqam sifatida tanlov kiriting.");
            }

        } while (true); 
    }
}
