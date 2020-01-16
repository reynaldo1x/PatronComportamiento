using ChainResponsability.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability.Abstract
{
    public abstract class Solicitud : ISolicitud
    {
        protected ISolicitud _solicitud;

        public abstract void Procesar(decimal dMonto);

        public abstract bool ValidarMonto(decimal dMonto);

        public ISolicitud SetNext(ISolicitud _solicitante)
        {
            _solicitud = _solicitante;

            return _solicitud;
        }

    }
}
