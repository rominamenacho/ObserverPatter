using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClienteProducto
{
    class Product : ISubjectProduct
    {
        private string productName;
        private double productPrice;

        private List<IObserverUser> _usersSuscribes;

        public Product(string _productName, double _productPrice)
        {
            _usersSuscribes = new List<IObserverUser>();
            ProductName = _productName;
            ProductPrice = _productPrice;
           
        }

        public string ProductName { get => productName; set => productName = value; }
        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
                this.Notify();
            }
        }

        public void Add(IObserverUser observer)
        {
            if (_usersSuscribes.Contains(observer))
            {
                throw new Exception($"El usuario {(User)observer} ya se encuentra en la lista");
            }
            else
            {
                _usersSuscribes.Add(observer);
            }
        }

        public void Notify()
        {
            if (_usersSuscribes.Count == 0)
            {
                Console.WriteLine("Nadie a quien notificar");
            }
            else {
                foreach (var u in _usersSuscribes)
                {
                    u.Update(this);
                }
            }
            
           
        }

        public void Remove(IObserverUser observer)
        {
            if (_usersSuscribes.Contains(observer))
            {
                _usersSuscribes.Remove(observer);
            }
            else
            {
                throw new Exception($"El usuario {(User)observer} NO se encuentra en la lista");
               
            }
        }

        public override string ToString()
        {
            return $"{ProductName} (${ProductPrice})";
        }
    }
}
