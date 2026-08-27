double diame, a;
Console.WriteLine("Ingrese la circunferencia de un circulo");
a = double.Parse(Console.ReadLine());
diame = (a / Math.PI);
Console.WriteLine("La superficie es {0}", diame);
Console.ReadKey();