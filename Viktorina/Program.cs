using System;
class ViktorinaDasturi{
    static void Main(){
        Viktorina_otkazish();
    }
    static void Viktorina_otkazish()
    {
        string[] savollar = {
            "1. O'zbekiston pul birligi nima? (A. tenge, B. dinor, C. so'm, D.rubl )", "2. C# dasturlash tilida qaysi kalit so'z obyekt yaratish uchun ishlatiladi? (A. class, B. object, C. new, D. create)", "3. C# dasturlash tilida 5 sonini qaysi type da yozgan maqul? (A. float B. int, C. double, D. strinng)",
        };

        char[] javoblar = { 'C', 'C', 'B' }; 
        int togriJavoblarSoni = 0;
        int savollarSoni = savollar.Length;
        char javob;

        Console.WriteLine("Viktorinaga xush kelibsiz!");
        int i = 0;

        do{
            Console.WriteLine(savollar[i]);
            Console.Write("Javobingizni tanlang (A,B,C,D): ");
            javob = Char.ToUpper(Console.ReadKey().KeyChar); 
            Console.WriteLine();

            if (javob == javoblar[i]){
                Console.WriteLine("To'g'ri javob!");
                togriJavoblarSoni++;
            }
            else{
                Console.WriteLine("Noto'g'ri javob! To'g'ri javob: " + javoblar[i]);
            }
            i++;
        } while (i < savollarSoni);
        Console.WriteLine($"\nViktorina tugadi. Siz {togriJavoblarSoni} ta to'g'ri javob berdingiz.");
        Console.WriteLine($"Sizning natjangiz: {((double)togriJavoblarSoni / savollarSoni) * 100}%");
    }
}
