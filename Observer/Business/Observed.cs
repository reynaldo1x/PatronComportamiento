using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Business
{
    public class Observed : IObserved
    {
        protected List<IObservador> _Observador = new List<IObservador>();
        public void AddObservador(IObservador Observador)
        {
            this._Observador.Add(Observador);
        }

        public void DelObservador(IObservador Observador)
        {
            this._Observador.Remove(Observador);
        }

        public void NotifyObservadores()
        {
            foreach (var item in _Observador)
            {
                item.Submit();
                item.Compile();
                item.UnitTest();
                item.Install();
                item.SendEmail();
            }
        }

        public void Main()
        {
            this.NotifyObservadores();
        }
    }
}
