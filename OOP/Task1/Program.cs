using System;
class program{
    static void Main(){
        Person person = new Person();
        person.Setname("Alisher");
        person.SetAge(23);
        System.Console.WriteLine($"Ism: {person.GetName()}");
        System.Console.WriteLine($"Yosh: {person.GetAge()}");
    }
}
public class Person{
    private string name;
    private int age;
    public string GetName(){
        return name;
    }
    public void Setname(string name){
        this.name = name;
    }
    public int GetAge(){
        return age;
    }
    public void SetAge(int age){
        if (age>0){
            this.age = age;
        }
        else{
            System.Console.WriteLine("Yoshingiz manfiy bo'lmasin");
        }
    }
}