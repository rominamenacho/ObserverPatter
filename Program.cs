using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClienteProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo un producto");
            Product jean = new Product("jean mom", 200);
            Console.WriteLine("Creo 2 suscriptores");
            IObserverUser suscriptor1 = new User("romina", "menacho");
            IObserverUser suscriptor2 = new User("juan", "topo");
            Console.WriteLine("Se agrgan a la lista de suscripcion");
            jean.Add(suscriptor1);
            jean.Add(suscriptor2);
            Console.WriteLine("Cambio el precio");
            jean.ProductPrice = 500;
            Console.WriteLine("Quito de la lista a suscriptor2");
            jean.Remove(suscriptor2);
            Console.WriteLine("Cambio el precio nuevamente");
            jean.ProductPrice = 100;


            Console.ReadLine();
        }
    }
}
