// See https://aka.ms/new-console-template for more information

using NumLetras.Entidades;
using NumLetras.Negocio;

ContarLetras ObjContar = new ContarLetras();
ClsCompararLetras clsObjContar = new ClsCompararLetras();

Console.WriteLine(" ");
Console.WriteLine("Ingrese una palabra o frase:");
ObjContar.Letras = Console.ReadLine();

Console.WriteLine($"La palabra/frase ({ObjContar.Letras}) contiene: ");
Console.WriteLine($"{clsObjContar.ContarNumLetras(ObjContar)} caracteres");
Console.WriteLine(" ");
