using System;

class Ejercicio6
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Ingrese la circunferencia: ");
        double circu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Diametro: " + circu / Math.PI);
    }
}