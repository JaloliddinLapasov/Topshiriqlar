using System;
class StoreDB{
    static string[] mahsulot_nomlari = {"Non", "Sut", "Shakar", "Choy", "Un", "Tuxum", "Olma", "Go'sht", "Sabzi", "Kartoshka"  };
    static double[] mahsulot_narx_uzs={ 3000, 6000, 8000, 5000, 15000, 12000, 10000, 50000, 3000, 4000 };
    static double[] mahsulot_narx_usd={ 0.25, 0.50, 0.67, 0.42, 1.25, 1.00, 0.83, 4.17, 0.25, 0.33};

    static void Main(){
        tanlash_bosqichi();
    }
    static void tanlash_bosqichi(){
        bool davomi = true;
        while (davomi){
            System.Console.WriteLine("Mahsulotlar ro'yhati: ");
            for (int i= 0; i< mahsulot_nomlari.Length; i++){
                System.Console.Write($"{mahsulot_nomlari[i]}, ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Mahsulot nomini tanla yoki 'exit' :");
            string tanlangan_mahsulotlar=Console.ReadLine().Trim();
            if( tanlangan_mahsulotlar == null || tanlangan_mahsulotlar.ToLower() == "exit"){
                davomi = false;
                break;
            }
            string[]tanlangan_mahsulot_list = tanlangan_mahsulotlar.Split(',');
            double jami_usd=0;
            double jami_uzb=0;
            string xatoMahsulotlar = "";

            foreach (string nomi in tanlangan_mahsulot_list){
                string mahsulot_nomi = nomi.Trim();
                int mahsulot_index = mahsulot_topish(mahsulot_nomi);
                if (mahsulot_index != -1)
                {
                    jami_usd += mahsulot_narx_uzs[mahsulot_index];
                    jami_uzb +=mahsulot_narx_usd[mahsulot_index];

                }
                else{
                    System.Console.WriteLine($"Mahsulot nomi Xato - {mahsulot_nomi}");
                    xatoMahsulotlar += $"{mahsulot_nomi}, ";
                }

                }
            if(jami_usd>0 || jami_uzb>0){
                System.Console.WriteLine("Narx qaysi valyutada ko'rsatilsin? ");
                string valyuta = Console.ReadLine().Trim().ToLower();

                if (valyuta == "usd"){
                    System.Console.WriteLine($"Narxi: {jami_usd}");
                }
                else if (valyuta == "uzb") {
                    System.Console.WriteLine($"Narxi: {jami_uzb}");
                }
                else{
                    System.Console.WriteLine("Noto'g'ri valyuta kiritildi.");
                    Console.ReadKey();
                    System.Console.WriteLine();
                
                }
            }
            if (!string.IsNullOrEmpty(xatoMahsulotlar))
            {
                System.Console.WriteLine($"Xato mahsulotlar: {xatoMahsulotlar.Trim(' ', ',')}");
            }
        }
    }
    static int mahsulot_topish(string nomi){
        for(int i = 0; i <mahsulot_nomlari.Length; i++){
            if(mahsulot_nomlari[i].ToLower() == nomi.ToLower()){
                return i;
            }
        }
        return -1;
    }
    
}