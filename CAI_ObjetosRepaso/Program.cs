using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Productos> lstproductos = new List<Productos>();

            Productos P1 = new Productos("Pepsi", "Gaseosa", 50, 100.35f);
            Productos P2 = new Productos();
            P2.Nombre = "Oreos";
            P2.TipoProducto = "Galletita";
            Productos P3 = new Productos("Fanta", "Gaseosa", 40, 80.55f);

            lstproductos.Add(P1);
            lstproductos.Add(P1);
            lstproductos.Add(P3);
            Console.WriteLine(P1.ToString());
            Console.WriteLine(P2.ToString());
            Console.WriteLine(P1.Vender(60));
            P2.Comprar(10);
            Console.WriteLine(P1.Vender(50));

            foreach(Productos P in lstproductos)
            {
                P.Disponible();
            }

            Console.WriteLine(P1.ToString());
            Console.WriteLine(P2.ToString());
            Console.WriteLine(P3.ToString());

            Console.ReadKey();
        }
    }
}
