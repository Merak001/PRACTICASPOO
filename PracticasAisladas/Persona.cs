using System;



class Persona
{
    public string Nombre { get; set; } 
    public int Edad  { get; set; }

    public Persona(string nombre, int edad){

        Nombre = nombre;
        Edad = edad;

    }

    public void MostrarInfo(){
        Console.WriteLine($"Mi nombre es {Nombre}");
        Console.WriteLine($"Mi edad es {Edad}");
        Console.WriteLine($"_________________________");
    }
    

}

