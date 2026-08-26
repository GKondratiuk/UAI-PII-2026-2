using System;
class Ejercicio4
{
    static void Main()
    {
        int Cuadrado1 = 0;
        int Cuadrado2 = 0;
        int Cuadrado3 = 0;
        int Cuadrado4 = 0;
        int TotalCuadrados = 0;
        Console.WriteLine("Ingrese el primer lado del cuadrado; ");
        Cuadrado1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado del cuadrado; ");
        Cuadrado2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer lado del cuadrado; ");
        Cuadrado3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el cuarto lado del cuadrado; ");
        Cuadrado4 = int.Parse(Console.ReadLine());

        TotalCuadrados = Cuadrado1 + Cuadrado2 + Cuadrado3 + Cuadrado4;
        Console.WriteLine("El perimetro del cuadrado es: " + TotalCuadrados);
    }
}