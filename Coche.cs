using System;
 

 class Coche{
    
    public string Marca { get; set; }  
    public string Modelo { get; set; }  
    public int Anio { get; set; }
    public string Color { get; set; }
    public double Kilometraje { get; set; }
 
 
    public Coche(string marca, string modelo, int anio, string color, double kilometraje)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        Color = color;
        Kilometraje = kilometraje;
    }

 
 public void MostrarInfo() {
    
    Console.WriteLine($"Marca: {Marca}");
    Console.WriteLine($"Modelo: {Modelo}");
    Console.WriteLine($"Año: {Anio}");
    Console.WriteLine($"Color: {Color}");
    Console.WriteLine($"Kilometraje: {Kilometraje}");
    Console.WriteLine("-------------------------");
    }
 

 }
 /*
 class Program2{
   static void Main(){
      var coche1 = new Coche("Dodge","Stratus", 2024, "sad", 677.5);
      
       Coche coche12 = new Coche("Toyota", "Corolla", 2020,"morado", 15000);
   }
 }*/
 
    

    