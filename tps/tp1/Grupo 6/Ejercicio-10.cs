string cadena;
string concatenado;
Console.WriteLine("Ingrese una Frase: ");
cadena = Console.ReadLine();
int tcadena = cadena.Length;
concatenado = cadena.Substring(tcadena / 2) + cadena.Substring(0, tcadena / 2);
Console.WriteLine("Las dos fraces concatenadas son " + concatenado);
Console.ReadKey();