using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClienteProducto
{
    interface IObserverUser
    {
         void Update(Product p);
    }
}
