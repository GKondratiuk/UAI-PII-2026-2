double tabits, a;
Console.WriteLine("Ingrese un Valor en KB y lo traducimos bits");
a = double.Parse(Console.ReadLine());
tabits = ((a * 8192));
Console.WriteLine("La traduccion a Bits es {0}", tabits);
Console.ReadKey();

//Conclusion como llegue a la solucion
//1Byte son 8 bits
//1KB es 1024 Bytes
//Por eso 1KB es igual a 8192 bits