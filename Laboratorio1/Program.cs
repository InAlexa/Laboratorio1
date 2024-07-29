using Laboratorio1;
using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Laboratorio 1: Tienda simulada");
        Console.WriteLine("");

        Clientes Cliente1 = new Clientes(123, "Daniela", "4768-0200", "danie0le2@gmail.com");
        Cliente1.MostrarDatos();

        Console.WriteLine(Cliente1);
    }
}


