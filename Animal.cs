using System;
using Microsoft.VisualBasic;


public class Animal
{

    public string Especie { get; set; }
    public string Color { get; set; }
    public double Peso { get; set; }

    public Animal(string especie, string color, double peso)
    {

        Especie = especie;
        Color = color;
        Peso = peso;
    }

    public void HacerSonido(string sonido){
           Console.WriteLine(sonido);
    }
    public void MostrarInfo()
    {

        Console.WriteLine($"Especie: {Especie}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Peso: {Peso}");
        Console.WriteLine("-------------------------");
    }

}
public class Perro : Animal
{
    // Constructor de Perro que manda datos a Animal
    public Perro(string color, double peso) : base("Can", color, peso)
    {
    }

    public void Ladra()
    {
        HacerSonido("¡Guau guau!");
    }
}

public class GatoMAlo : Animal{
    public GatoMAlo (): base ("Gatuna","Morado",5){
        GatoMAlo gato1= new GatoMAlo();
        gato1.HacerSonido("Maulla");
        gato1.MostrarInfo();

    }
}

public class Gato : Animal{
    public  Gato (string color, double Pesp) : base("Gatuna",color,Pesp){

    }
    public void Maulla(){
        HacerSonido("Miaaaauuuuu");
    }
}
