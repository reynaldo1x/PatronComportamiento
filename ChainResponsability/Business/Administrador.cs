using ChainResponsability.Abstract;
using ChainResponsability.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability.Business
{
    public class Administrador : Solicitud
    {
        public override void Procesar(decimal dMonto)
        {
            if (ValidarMonto(dMonto))
            {
                Console.WriteLine("El Administrador aceptó la solicitud.");
            }
            else
            {
                Console.WriteLine("El Administrador no pudo procesar la solicitud. Reenviando la solicitud...");
                base._solicitud.Procesar(dMonto);
            }
        }

        public override bool ValidarMonto(decimal dMonto)
        {
            return dMonto <= 10000 ? true : false;
        }
    }
}
