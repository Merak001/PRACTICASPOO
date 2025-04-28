using System;

class ProgramLibro
{
    static void Main(string[] args)
    {
        LibroController libros = new LibroController();

        for(int i=0; i<3;i++){
            Console.WriteLine($"Ingresa el nombre del libro {i + 1}");
             string autor = Console.ReadLine();

            Console.WriteLine($"Ingresa el Autor del libro {i + 1}:");
            string titulo = Console.ReadLine();

            libros.AgregarLibro(autor,titulo);
        }

        var listaLibros = libros.ObtenerLibors();
        foreach(var libro in listaLibros){
            Console.WriteLine($"Autor: {libro.Autor}");
            Console.WriteLine($"Título: {libro.Titulo}");
            Console.WriteLine("-----------------");
        }

        
    }
}