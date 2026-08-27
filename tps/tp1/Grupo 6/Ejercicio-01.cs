int Numero = 0;
int Numero2 = 0;
int Operacion = 0;

Console.WriteLine("Ingrese un numero por favor: ");
Numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero por favor: ");
Numero2 = Convert.ToInt32(Console.ReadLine());
Operacion = Numero2 + Numero;
Console.WriteLine("La suma de {0} mas {1} es: {2}", Numero, Numero2, Operacion);
