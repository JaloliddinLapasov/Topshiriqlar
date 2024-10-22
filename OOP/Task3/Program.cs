using System;
class Program{
    static void Main(){
    BankAccount account = new BankAccount(1000);
    System.Console.WriteLine("Boshlang'ich balans: "+ account.BalansniKorish() + "so'm");

    account.Deposit(500);
    System.Console.WriteLine("Yangi balans: "+ account.BalansniKorish() + "so'm");

    account.PulYechish(300);
    System.Console.WriteLine("Mablag' yechib olingandan keyingi balans: "+ account.BalansniKorish()+ " so'm");
    }
}
public class BankAccount{
    private double balance;
    public BankAccount(double boshlangichBalance){
        balance = boshlangichBalance;
    }
    public void Deposit (double miqdori ){
        if(miqdori>0){
            balance += miqdori;
            System.Console.WriteLine($"{miqdori} so'm depozit qo'yildi.");
        }
        else{
            System.Console.WriteLine("Depozit miqdori manfiy bo'lmaydi");
        }
    }
    public void PulYechish(double miqdori){
        if(miqdori>0 && miqdori<=balance){
            balance -= miqdori;
            System.Console.WriteLine($"{miqdori} so'm yechib olindi.");
        }
        else if(miqdori > balance){
            System.Console.WriteLine("Hisobingizda mablag' yetarli emas.");
        }
        else{
            System.Console.WriteLine("Manfiy qiymat kiritib bo'lmaydi.");
        }
    }
    public double BalansniKorish(){
        return balance;
    }

}