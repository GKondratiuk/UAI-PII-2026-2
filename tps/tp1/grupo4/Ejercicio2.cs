using System;
class Ejercicio2
{
    static void Main()
    {
        int Numero = 0;
        int numero2 = 0;
        int i = 0;
        int Inicio = 0;
        int fin = 0;
        Console.WriteLine("Ingrese un numero por favor: ");
        Numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero por favor: ");
        numero2 = int.Parse(Console.ReadLine());
        Console.WriteLine(numero2 - Numero);
    }
}