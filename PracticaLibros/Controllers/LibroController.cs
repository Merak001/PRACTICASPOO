using System.Collections.Generic;

public class LibroController{

        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(string autor, string titulo){

            libros.Add(new Libro{Autor = autor, Titulo =titulo});

        }

        public List<Libro> ObtenerLibors(){
            return libros;
        }
}
