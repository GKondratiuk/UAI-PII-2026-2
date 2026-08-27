int Numero = 0;
int numero2 = 0;
int Operacion = 0;

Console.WriteLine("Ingrese un numero por favor: ");
Numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero por favor: ");
numero2 = Convert.ToInt32(Console.ReadLine());
Operacion = numero2 - Numero;
Console.WriteLine("Hay: {0} Numeros entre {1} y {2}",Operacion, numero2, Numero);
