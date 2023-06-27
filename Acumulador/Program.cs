using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumulador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // supongamos que tenemos unos productos con diferentes precios, la aplicacion almacena los datos en memoria  los suma al final
            int i;
            int precio;
            int acumulador  = 0;
            

            for (i = 1; i <= 5; i++)
            {
                Console.Write(" Por favor, ingresa el precio del producto  :");
                precio = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + precio;
            }
            Console.WriteLine(" El precio total es {0}", acumulador);
            

        }
    }
}
