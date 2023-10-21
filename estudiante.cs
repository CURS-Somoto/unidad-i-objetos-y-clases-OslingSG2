using System;

public class Estudiante
{
   public string Curso { get; set; }
    public string Nombre { get; set; }
    public string Edad { get; set; }


    public Estudiante(string curso, string nombre, string edad)
    {
        Curso = curso;
        Nombre = nombre;
        Edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Curso: " + 4);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad:" + 18 );

    
   
}

class Program
{
    public static void Main(string[] args)
    {
        Estudiante estudiante1 = new Estudiante("4", "Carlos", "18");
        Estudiante estudiante2 = new Estudiante("6", "Willy", "20");

        Console.WriteLine("Información del Estudiante 1:");
      estudiante1.MostrarInformacion();

        Console.WriteLine("Informacion del estudiante 2:");
      estudiante2.MostrarInformacion();
        Console.ReadKey();
      
    }
}
