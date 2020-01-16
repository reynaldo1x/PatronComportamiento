using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Business
{
    public class Context
    {
        private IEstadoAlarma _EstadoAlarma;

        public Context(IEstadoAlarma EstadoAlarma)
        {
            _EstadoAlarma = EstadoAlarma;
        }

        public void SetEstado(IEstadoAlarma EstadoAlarma)
        {
            _EstadoAlarma = EstadoAlarma;
        }
            
        public void Abrir()
        {
            _EstadoAlarma.Abrir();
        }

        public void Cerrar()
        {
            _EstadoAlarma.Cerrar();
        }
    }
}
