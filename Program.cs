using System;

class Program
{
    static void Main(string[] args)
    {/*
        // Crear un objeto de Animal
        Animal animal1 = new Animal("Felino", "Negro", 4.5);

        // Llamar sus métodos
        animal1.HacerSonido("Grrrrr");
        animal1.MostrarInfo();
        
        // También puedes crear un Gato o Perro si ya tienes esas clases
        var miGato = new Gato("verde",358);  // Esto llamará todo lo que pusiste en el constructor
        miGato.Maulla();
        miGato.Maulla();
        miGato.MostrarInfo();
        
        Test1();*/

        /*
        Persona persona1 = new Persona("Jose", 33);
        persona1.MostrarInfo();

        Persona persona2= new Persona("Juan",48);
        persona2.MostrarInfo();
        */


        /*
        CuentaBancaria  cuentaBancaria1 = new("Manuel",500);
        CuentaBancaria  cuentaBancaria2 = new("Itzeñ",100);

        cuentaBancaria1.Depositar(500);
        cuentaBancaria1.MostarSaldo();
    */


    /*
        Empleado empleado1 = new Empleado("Manuel", 1500);
        Gerente empleado2 = new Gerente("Tejeda",2500,"Gerencia");

        empleado1.MostrarInfo();
        empleado2.MostrarInfo();
        
*/

    /* REDUCIR PRECIOS
        Ejercicios ejercicio1 = new Ejercicios();
        Condicional condicional1= new Condicional();
        condicional1.Precio= 500;
        condicional1.ReducirPrecio(25);

        Condicional condicional2= new Condicional();
        condicional2.Precio= 100;
        condicional2.ReducirPrecio(25);

        condicional1.ReducirPrecio(55);

    }
    private static void Test1(){
        Animal animal2= new Animal("gallinezca","Morado",580);
        animal2.Color="rosa";
        animal2.MostrarInfo();*/        



        List<Libro>libros = new List<Libro>();

        for(int i=0; i<3; i++){
            Libro libro = new Libro();

            libro.Autor=$"Autor {i}";
            libro.Titulo=$"Titulo {i}";

            libros.Add(libro);

        }

        foreach (var libro in libros)
        {
         libro.DatosLibro();   
        }
        Libro libroz = new Libro();
        libroz.Autor="Desconocido";
        libroz.Titulo="Desconocido";

        libroz.DatosLibro("Apocrifo");

        
    }
}