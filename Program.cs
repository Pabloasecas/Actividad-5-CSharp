Console.WriteLine("Hola, introduzca su nombre");
var nombre = Console.ReadLine();
Console.Write("Adiós ");
for (int i = (nombre.Length-1); i >= 0; i--)
{
    Console.Write(nombre[i]);
}