using System;
class Program{
    static void Main(){
        Havo_malumotlarini_yigish();
    }
    static void Havo_malumotlarini_yigish(){
         int kunlarSoni = 7;
        double[] haroratlar = new double[kunlarSoni]; 
        int kiritilganKunlar = 0; 
        double umumiyHarorat = 0; 
        do{
            Console.Write($"Kunning {kiritilganKunlar + 1}-dagi haroratni kiriting: ");
            string kiritilganHaroratStr = Console.ReadLine();
        if (double.TryParse(kiritilganHaroratStr, out double kiritilganHarorat)){
                if (kiritilganHarorat >= -50 && kiritilganHarorat <= 50)  {
                    haroratlar[kiritilganKunlar] = kiritilganHarorat; 
                    umumiyHarorat += kiritilganHarorat; 
                    kiritilganKunlar++; 
                }
                else{
                    Console.WriteLine("Haroratni -50 dan 50 darajagacha yozing");
                }
            }
            else{
                Console.WriteLine("Haroratni to'g'ri raqam sifatida kiriting.");
            }
        } while (kiritilganKunlar < kunlarSoni); 

        double ortachaHarorat = umumiyHarorat / kunlarSoni;
        Console.WriteLine($"\nO'rtacha harorat: {ortachaHarorat} C");
    }
}
