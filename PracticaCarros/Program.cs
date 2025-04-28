using System;

class ProgramCaros
{
    static void Main(string[] args)
    {
        CarController carros = new CarController();

        for(int i=0; i<3;i++){
            Console.WriteLine($"Ingresa la marca del carro {i + 1}");
             string marca = Console.ReadLine();

            Console.WriteLine($"Ingresa el Modelo del carro {i + 1}:");
            string modelo = Console.ReadLine();

            Console.WriteLine($"Ingresa el Año del carro {i + 1}:");
            int anio =  int.Parse(Console.ReadLine());

            carros.AddCarr(marca,modelo,anio);
        }

        var listCars = carros.GetCars();

        foreach(var carr in listCars){
            Console.WriteLine($"Marca del auto {carr.Marca}");
            Console.WriteLine($"Modelo del auto {carr.Modelo}");
            Console.WriteLine($"El año del auto {carr.Anio}");
            Console.WriteLine("-----------------");
        }

        

        
    }
}