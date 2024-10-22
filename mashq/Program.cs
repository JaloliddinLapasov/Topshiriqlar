using System;
class Lesson{

   static void sonlar(){
    int [] raqamlar = {2, 77, 8, 54, 32, 1,8, 9,77, 20} ;
       int [] qaytarilmaganlar = {};
        for(int i =0; i<raqamlar.Length; i++){
            bool bormi = false;
            for (int j=0; j<i; j++){
                if (raqamlar[i] == raqamlar[j]){
                    bormi =true;
                    break;
                }
        
            }
            if(!bormi){
                System.Console.Write($"{raqamlar[i]}, ");
            }
          }
   }
    static void Main(){
        sonlar();
            
    }
}