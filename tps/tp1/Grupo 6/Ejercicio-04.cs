string cadena;
int a, b;
double area;
Console.WriteLine("Ingrese tamaño de uno de los lados del cuadrado");
cadena = Console.ReadLine();
a = Convert.ToInt32(cadena);
area = Math.Pow(a, 2);
Console.WriteLine("La superficie es {0}", area);
Console.ReadKey();