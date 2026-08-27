using System;
class Ejercicio3
{
    static void Main()
    {
        int Lado1 = 0;
        int Lado2 = 0;
        int Lado3 = 0;
        int TotalLados = 0;
        Console.WriteLine("Ingrese el primer lado del triangulo: ");
        Lado1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado del triangulo: ");
        Lado2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer lado del triangulo: ");
        Lado3 = int.Parse(Console.ReadLine());
        TotalLados = Lado1 + Lado2 + Lado3;
        Console.WriteLine("El perimetro del triangulo es: " + TotalLados);
    }
}