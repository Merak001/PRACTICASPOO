using System;
using System.Diagnostics.Contracts;

public class Empleado{
    public string Nombre { get; set; } 
    public double Suledo { get; set; }

    public Empleado(String nombre, double suledo){
        Nombre = nombre;
        Suledo = suledo;
    }

    public virtual void MostrarInfo(){
        Console.WriteLine($"Mi nombre es: {Nombre}");
        Console.WriteLine($"Mi suledo es de : {Suledo}");
        Console.WriteLine($"_________________________");

    }
    
}
public class Gerente : Empleado {
    
 public string Departamento { get; set; }
 public Gerente(string nombre, double suledo,string departamento) :base (nombre,suledo){
    Departamento = departamento;
 }
       public override void MostrarInfo(){
        Console.WriteLine($"Mi nombre es: {Nombre}");
        Console.WriteLine($"Mi suledo es de : {Suledo}");
        Console.WriteLine($"Mi departamento es: {Departamento}");
        Console.WriteLine($"_________________________");

    }

}