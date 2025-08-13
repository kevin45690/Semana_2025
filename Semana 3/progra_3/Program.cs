using progra_3;
using System.Drawing;
var echo1 = utileriaGenerica.Echo(34);
var echo2 = utileriaGenerica.Echo("proramacion |||");

int x = 3;
string resultado = x > 0 ? "Positivo" : "negativo";
if (x > 0)
    resultado = "Positivo";
else
    resultado = "negativo";

    Console.WriteLine($"Echo int: {echo1}");
Console.WriteLine($"Echo string: {echo2}");
Console.WriteLine($"5 es igual que 5:{utileriaGenerica.Esigual(5, 5)}");
Console.WriteLine($"A es igual que B:{utileriaGenerica.Esigual("A", "A")}");
Console.WriteLine($"Max entre 7 y 5:{utileriaGenerica.Max(7, 5)}");
var repetirEnteros = utileriaGenerica.Repetir(10, 6);
Console.WriteLine($"repeticion de Enteros: {string.Join(",", repetirEnteros)}");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
void MostrarInformacion<T>(T Valor)
{
    Console.WriteLine($"valor recibido: {Valor}");
}


















// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
