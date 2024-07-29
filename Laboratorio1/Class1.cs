using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio1
{
    public class Productos()
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public int Precio { get; set; }

        public Productos(int iD, string nombre, int precio)
        {
            ID = iD;
            Nombre = nombre;
            Precio = precio;
        }
        public void MostrarDatos()
        {
            Console.WriteLine($"ID: {ID}, Nombre: {Nombre}, Precio: {Precio}");
        }
    }

    
    public class AcumularPrecios()
    {

    }

    public class CalcularTotal()
    {

    }

    public void MenuPrincipal()
    {

    }
    


}
