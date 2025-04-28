using System;


public class Ejercicios{

}


public class Condicional
{
    public string Nombre { get; set; }
    public double Precio { get; set; } 

    public void ReducirPrecio(float porcentaje){

        if(porcentaje <= 50){
            double descuento = 0;
            descuento = Precio * (porcentaje/100);
            Precio = Precio - descuento;
            Console.WriteLine($"El nuevo precio es de {Precio}");

        }else{
            Console.WriteLine($"No se puede hacer el descuento, el  precio es de {Precio}");
        }

    }

}

public class Librox
{
    public string  Titulo { get; set; }
    public string Autor { get; set; }

    public void DatosLibro(){
        Console.WriteLine($"Titulo del libro: {Titulo}");
        Console.WriteLine($"Autor del libro: {Autor}");
        Console.WriteLine($"_______________________");
    }

    public void DatosLibro(string titulo){
        Console.WriteLine($"Titulo del libro: {titulo}");
        Console.WriteLine($"Autor del libro: {Autor}");
        Console.WriteLine($"_______________________");
    }
}



