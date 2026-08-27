using System;

class Ejercicio7
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Ingrese la cantidad de KBytes a convertir: ");
        double kb = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Bits: " + kb * 8000);

        /* 
        1 byte es equivalente a 8 bits.
        1 kilobyte son 1000 bytes.
        Por lo tanto, 1 kilobyte son 8000 bits.

        Para obtener los bits:
        Cantidad de KB * 8000 = cantidad de bits.
        */
    }
}