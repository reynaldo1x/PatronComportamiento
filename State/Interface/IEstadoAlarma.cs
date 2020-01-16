using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Interface
{
    public interface IEstadoAlarma
    {
        void Abrir();

        void Cerrar();
    }
}
