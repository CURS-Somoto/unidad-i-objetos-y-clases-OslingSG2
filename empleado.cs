using System;

public class Empleado
{
   
    public string Nombre { get; set; }
    public double Salario { get; set; }
   Empleado empleado1 = new Empleado();
            empleado1.Nombre = "Carlos Alberto Martinez";
            empleado1.Salario = 3000;



            Empleado empleado2 = new Empleado();
            empleado2.Nombre  = "Jose Manuel Alfaro Carazo";
            empleado2.Salario = 5000;

            Console.WriteLine("El salario anual de:" +empleado1.Nombre+ "es de" +empleado1.CalcularSalarioAnual());
            Console.WriteLine("El salario anual de:" +empleado2.Nombre+ "es de" +empleado2.CalcularSalarioAnual());

            Console.ReadKey();

    {
        
    }
}

class Program
{
    public static void Main(string[] args)
       {
        public string Nombre
        { get; set; }

        public double Salario
        { get; set; }

        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }
}
       
    {
        Console.WriteLine("¡Hola, mundo!");
    }
}
