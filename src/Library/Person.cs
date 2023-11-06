using System.Globalization;

public class Person{
    public string Nombre {get; set;}
    public int Edad {get; set;}

    public Person(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }

    public string GetPerson(){
         return $"{Nombre}, {Edad} años";
    }
}