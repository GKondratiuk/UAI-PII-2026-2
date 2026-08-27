using System;
internal class Ejercicio_8
{
    static void Main(string[] args)
    {
        //8) Calcular el factorial de 6
        int numero = 6;
        int factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }
}
