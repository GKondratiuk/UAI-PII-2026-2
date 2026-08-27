//Ejercicio 3
//Dados los lados de un triangulo calcular el perímetro.
string cadena;
int a, b, c, per;
Console.WriteLine("Ingrese el tamaño de uno de los lados ");
cadena = Console.ReadLine();
a = Convert.ToInt32(cadena);
Console.WriteLine("Ingrese el tamaño del segundo de los lados");
cadena = Console.ReadLine();
b = Convert.ToInt32(cadena);
Console.WriteLine("Ingrese el tamaño del tercero de los lados");
cadena = Console.ReadLine();
c = Convert.ToInt32(cadena);
per = a + b + c;
Console.WriteLine("El permimetro es {0}", per);
Console.ReadKey();