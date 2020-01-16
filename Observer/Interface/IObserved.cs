using Observer.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interface
{
    public interface IObserved
    {
        void AddObservador(IObservador Observador);

        void DelObservador(IObservador Observador);

        void NotifyObservadores();
    }
}
