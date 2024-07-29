using Laboratorio1;
using System;

class program
{
    public static object cantidadDeProductos;

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
                        AcumularProductos();
                        break;
                    case 2:

                        break;
                    case 3:
                        Console.WriteLine("Has salido del programa.");
                        cat = 1;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese una de las opciones dentro del menú.");
                        break;
                }
            }
            catch (FormatException ex) // los siguientes catch atrapan los errores de este bloque try
            {
                Console.Clear();
                Console.WriteLine("Error: no se ha ingresado un número entero.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
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

    static void AcumularProductos()
    {
        int cat2 = 0;
        while (cat2 == 0)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingese el precio");
                    int precio = int.Parse(Console.ReadLine());
                    Console.WriteLine("¡Desea dejar de ingresar productos? si/no");
                    string opcionproduct = (Console.ReadLine());
                    if (opcionproduct == "si")
                    {
                        continue;
                    }
                    else 
                    {
                        cat2 = 1;   
                    }
                }
            }
            catch (FormatException ex) // los siguientes catch atrapan los errores de este bloque try
            {
                Console.Clear();
                Console.WriteLine("Error: no se ha ingresado un número entero.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
                Console.ReadKey();
            }
        }

    }



    private static int IngresarCantidadProductos(object cantidadDeProductos)
    {
        throw new NotImplementedException();
    }

    static int IngresarCantidadProductos(int cantidad)
    {
        Console.WriteLine("Ingrese la cantidad de productos que desea agregar");
        int cantidadDeProductos = int.Parse(Console.ReadLine());
        Console.WriteLine("La cantidad de productos a ingresar es: "+cantidadDeProductos);
        return cantidadDeProductos;
    }
}

