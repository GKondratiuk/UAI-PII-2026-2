int a;
long fact;
Console.WriteLine("Ingrese un Valor para realizar el factorial");
a = int.Parse(Console.ReadLine());
fact = 1;
for (int i = 2; i <= a; i++)
{
    fact *= i;
}
Console.WriteLine("El factorial de {0} es {1}", a, fact);
Console.ReadKey();