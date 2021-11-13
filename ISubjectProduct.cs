using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternClienteProducto
{
    interface ISubjectProduct
    {
        void Add(IObserverUser observer);//suscribe
        void Notify();
        void Remove(IObserverUser observer);//undo suscribe
    }
}
