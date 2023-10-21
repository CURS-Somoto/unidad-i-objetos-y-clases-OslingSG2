using System;

public class Libro
{
    // Propiedades
    public string Título { get; set; }
    public string Autor { get; set; }
    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
    }
   
}

class Program
{
   public  static void Main(string[] args)
    {
        Libro libro1 = new Libro("El código Da Vinci", "Dan Brown");
        Libro libro2 = new Libro("Don Quijote de la Mancha", "Miguel de Cervantes");

        Console.WriteLine("Información del Libro 1:");
        libro1.MostrarInformacion();

        Console.WriteLine("Información del Libro 2:");
        libro2.MostrarInformacion();
        Console.ReadKey();
    }
}
