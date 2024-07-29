using Laboratorio1;
using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Laboratorio 1: Tienda simulada");
        int cat = 0;
        while (cat == 0)
        {
            try
            {
                MenuPrincipal();
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una de las opciones dentro del menú.");
                        break;
                }
            }
            catch (FormatException ex) // los siguientes catch atrapan los errores de este bloque try
            {
                Console.WriteLine("Error: no se ha ingresado un número entero.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
                Console.ReadKey();
            }

        }


        static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("1. Ingresar productos");
            Console.WriteLine("2. Calcular total");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Ingrese una de las opciones: ");
        }

        Main();
    }
}