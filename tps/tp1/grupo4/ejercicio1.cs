internal class Ejercicio_1
{
    private static void Main(string[] args)
    {
        //1) Ingresar dos valores y sumarlos
        Console.Write("Ingrese el primer valor: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo valor: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        int suma = valor1 + valor2;
        Console.WriteLine("La suma de los valores ingresados es: " + suma);
    }
}
