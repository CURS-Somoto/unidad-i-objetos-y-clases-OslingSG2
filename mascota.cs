using System;

public class Mascota
{
    public string Tipo { get; set; }
    public string Nombre { get; set; }
    public string Edad { get; set; }


    public Mascota(string tipo, string nombre, string edad) 
    {
        Tipo = tipo;
        Nombre = nombre;
        Edad = edad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad:" + 4);
    }
     
}

class Program
{
    public static void Main(string[] args)
    {
       Mascota mascota1 = new Mascota("Pitbull", "Dolar", "4");
        Mascota mascota2 = new Mascota ("Pastor Aleman", "Body", "6");

        Console.WriteLine("Información de la Mascota 1:");
        mascota1.MostrarInformacion();

        Console.WriteLine("Informacion de la Mascota 1:");
        mascota2.MostrarInformacion();
        Console.ReadKey();
    }
}
