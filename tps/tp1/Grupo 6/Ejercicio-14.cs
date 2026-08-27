DateTime fecha1, fecha2;
Console.WriteLine("Ingrese una fecha: Formato de escritura: dd/Mm/AAAA");
fecha1 = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Ingrese una fecha: Formato de escritura: dd/Mm/AAAA");
fecha2 = DateTime.Parse(Console.ReadLine());
TimeSpan dias = fecha2 - fecha1;
Console.WriteLine("El tiempo entre ambas fechas es de " + dias + "dias ");