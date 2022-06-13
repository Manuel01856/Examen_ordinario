using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_ordinario
{
    class Program
    {
        public class Almacen
        {
            public string producto;
            public int cantidad;
            public float precio;
            

            public Almacen(string producto, int cantidad, float precio)
            {
                this.producto = producto;
                this.cantidad = cantidad;
                this.precio = precio;
            }

            public void Imprimir_pantalla()
            {
                Console.Clear();
                Console.WriteLine("El producto ingresado fue: "+ this.producto);
                Console.WriteLine("\nCon una cantidad vendida de: " + this.cantidad);
                Console.WriteLine("\nA un precio de: " + "{0:C}",this.precio);

                Console.WriteLine("\nPresioné cualquier tecla para registrar la venta.");
                Console.ReadLine();

            }

            public void escribirArchivos()
            {
                StreamWriter sw = new StreamWriter("Venta.txt", true);
                sw.WriteLine("\nNuevo Registro de Venta" + "\nNombre: " + producto + "\nCon un stock de: " + cantidad + "\nCon un precio de:" + "{0:C}", precio);
                sw.Close();


                Console.WriteLine("Registrando .... Presioné cualquier tecla para salir");
                Console.ReadLine();

            }

            ~Almacen()
            {
                Console.WriteLine("Clase Almacen liberada");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Bienvenido al sistema de registro de ventas");

                Console.WriteLine("\nPresione cualquier tecla para registrar una nueva venta");
                Console.ReadKey();

                Console.Clear();
                Console.Write("Escriba el nombre del producto: ");
                string producto = Console.ReadLine();

                Console.Clear();
                Console.Write("Escriba la cantidad vendida del producto: ");
                int cantidad = Int32.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("Escriba el precio del producto: ");
                float precio = float.Parse(Console.ReadLine());


                Almacen newVenta = new Almacen(producto, cantidad, precio);
                newVenta.Imprimir_pantalla();
                newVenta.escribirArchivos();          

            }
            catch (FormatException e)
            {
                Console.WriteLine("\nError : " + e.Message);
                
            }
        }
    }
}
