string cadena, concatenado;
Console.WriteLine("Ingrese una fecha: DDMMAAAA");
cadena = Console.ReadLine();
concatenado = cadena.Substring(4, 4) + cadena.Substring(2, 2) + cadena.Substring(0, 2);
Console.WriteLine("La fecha ingresada fue en AAAAMMDD :" + concatenado);
Console.ReadKey();