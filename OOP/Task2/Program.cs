using System;
class Lesson{
    static void Main(){
        Person person= new Person("Alisher");
        System.Console.WriteLine("Ism: " + person.Name );
        person.SetAge(25);
        System.Console.WriteLine("Yosh: "+ person.Age);
    }
}

public class Person {
    private readonly string _name;
    private int age;

    public Person(string name){
        this._name = name;
    }
    public string Name{
        get{return _name;}
    }

    public int Age{
        get {return age;}
    }
    public void SetAge(int age){
        if(age>=0){
            this.age = age;
        }
        else{
            System.Console.WriteLine("Yosh manfiy bo'lmasligi kerak.");
        }
    }
}
