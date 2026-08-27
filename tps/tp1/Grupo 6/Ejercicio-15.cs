DateTime fecha1, fecha2;
fecha1 = new DateTime(2020, 12, 25);
Console.WriteLine("Ingrese una fecha: dd/Mm/AAAA");
fecha2 = DateTime.Parse(Console.ReadLine());
TimeSpan dias = fecha2 - fecha1;
Console.WriteLine("El tiempo desde la fecha del 25/12/2020 es de " + dias + " dias ");