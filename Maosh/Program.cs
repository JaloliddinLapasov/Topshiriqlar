using System;
class Maoshi{
    static void Main(){
        Maosh_hisoblash();
    }
    static void Maosh_hisoblash(){
        string[] xodimlar = { "Jamshid", "Davron", "Ruslan", "Mirxoja", "Asilbek" };
        double[] soatlikStavkalar = { 15.0, 20.0, 18.5, 22.0, 25.0 }; 
        int[] ishlanganSoatlar = new int[xodimlar.Length];
        for (int i = 0; i < xodimlar.Length; i++){
        Console.WriteLine($"{xodimlar[i]} uchun ishlangan soatlarni kiriting: ");
        ishlanganSoatlar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nXodimlar maoshlarini hisoblash natijalari:");
        for (int i = 0; i < xodimlar.Length; i++){
            double maosh = soatlikStavkalar[i] * ishlanganSoatlar[i];
            Console.WriteLine($"{xodimlar[i]} ning maoshi: {maosh} so'm");
        }
    }
}
