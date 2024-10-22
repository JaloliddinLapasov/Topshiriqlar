using System;

class Attendence
{
    static void Main(){
    davomat_boshlash();
    }

    static void davomat_boshlash(){
        string[] talabalar = { "Jamshid", "Davron", "Ruslan", "Mirxoja", "Asilbek", "Artur" };
        int[,] ishtirok = new int[talabalar.Length, 7]; 
        int haftalik = 7; 
        int kunlik = 1;
        davomat(talabalar, ishtirok, haftalik, ref kunlik);
        foizda_hisoblash(talabalar, ishtirok, haftalik); 
    }

    static void davomat(string[] talabalar, int[,] ishtirok, int haftalik, ref int kunlik)
    {
    do{
        Console.WriteLine($"Kun: {kunlik}");
            for (int i = 0; i < talabalar.Length; i++)
                {
                Console.Write($"{talabalar[i]} qatnashdimi? (h/y): ");
                ConsoleKeyInfo javob = Console.ReadKey();
                Console.WriteLine();
                if (javob.KeyChar == 'h' || javob.KeyChar == 'H'){
                    ishtirok[i, kunlik - 1] = 1; 
                }
                else{
                    ishtirok[i, kunlik - 1] = 0;
                }
                }
                kunlik++;
    } 
    while (kunlik <= haftalik);
    }
    static void foizda_hisoblash(string[] talabalar, int[,] ishtirok, int haftalik){
        for (int i = 0; i < talabalar.Length; i++){
        int jami_qatnashganlar = 0;
        for (int j = 0; j < haftalik; j++){
        jami_qatnashganlar += ishtirok[i, j];
        }
        double foiz = (double)jami_qatnashganlar / haftalik * 100;
        Console.WriteLine($"{talabalar[i]} ning davomat foizi: {foiz}%"); 
        } 
        }
}
