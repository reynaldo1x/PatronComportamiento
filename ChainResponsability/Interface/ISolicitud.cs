using ChainResponsability.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability.Interface
{
    public interface ISolicitud
    {
        void Procesar(decimal dMonto);
    }
}
