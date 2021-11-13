using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClienteProducto
{
    class User:IObserverUser
    {

        private string name;
        private string lastName;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }


        public User(string _name, string _lastName)
        {
            Name = _name;
            LastName = _lastName;
        }

        public void Update(Product p)
        {
            Console.WriteLine($"El usuario {this} recibio la notificacion del producto {p}");
        }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
