using System;
class Saylov{
     static void Main() {
        OvozBerishi();
    }

    static void OvozBerish(){
        string[] nomzodlar = { "Davron", "Ruslan", "Mirxoja" };
        int[] ovozlar = new int[nomzodlar.Length]; 
        int jamiTalabalar = 10; 
        int ovozBeruvchi = 0; 
        int ovoz;
        do{
            Console.WriteLine("Talabalar ovoz berishmoqda...");
            Console.WriteLine("Quyidagi nomzodlar mavjud:");

            for (int i = 0; i < nomzodlar.Length; i++){
                Console.WriteLine($"{i + 1}. {nomzodlar[i]}");
            }

            Console.Write("Ovoz berish uchun nomzod raqamini kiriting (1-4): ");
            ovoz = Convert.ToInt32(Console.ReadLine());

            if (ovoz >= 1 && ovoz <= nomzodlar.Length){
                ovozlar[ovoz - 1]++; 
                ovozBeruvchi++;
            }
            else{
                Console.WriteLine("Noto'g'ri raqam, 1 dan 4 gacha raqam kiriting.");
            }
        } while (ovozBeruvchi < jamiTalabalar);
        GolibniAniqlash(nomzodlar, ovozlar);
    }
    static void GolibniAniqlash(string[] nomzodlar, int[] ovozlar)
    {
        int engKopOvoz = 0;
        string golib = "";

        for (int i = 0; i < ovozlar.Length; i++) {
            Console.WriteLine($"{nomzodlar[i]} uchun ovozlar: {ovozlar[i]}"); 
            if (ovozlar[i] > engKopOvoz) 
            {
                engKopOvoz = ovozlar[i];
                golib = nomzodlar[i];
            }
        }
     Console.WriteLine($"G'olib: {golib} - {engKopOvoz} ovoz bilan!"); 
    }
}
