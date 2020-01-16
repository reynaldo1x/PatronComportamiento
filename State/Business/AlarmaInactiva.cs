using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Business
{
    public class AlarmaInactiva : IEstadoAlarma
    {
        private Context _context;

        public void SetContext(Context Context)
        {
            _context = Context;
        }

        public void Abrir()
        {
            Console.WriteLine("Se activo la alarma");
        }

        public void Cerrar()
        {
            Console.WriteLine("Nota: La alarma ya esta inactiva!");
            AlarmaActiva activar = new AlarmaActiva();
            activar.SetContext(_context);
            _context.SetEstado(activar);
        }
    }
}
