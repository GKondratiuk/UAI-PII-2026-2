internal class Ejercicio_9
{
    private static void Main(string[] args)
    {
        //9) Concatenar dos frases y mostrar resultado
        Console.WriteLine("Ingrese la primera frase: ");
        string frase_1 = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda frase: ");
        string frase_2 = Console.ReadLine();

        string resultado = frase_1 + " " + frase_2;
        Console.WriteLine("La frase concatenada es: " + resultado);
    }
}
