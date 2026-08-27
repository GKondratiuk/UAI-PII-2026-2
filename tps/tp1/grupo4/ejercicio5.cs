using System;

class Ejercicio5
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Ingrese la base del rectangulo (CM): ");
        double baserec = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectangulo (CM): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Superficie: " + baserec * altura);
    }
}