using State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Business
{
    public class AlarmaActiva : IEstadoAlarma
    {
        private Context _context;

        public void SetContext(Context Context)
        {
            _context = Context;
        }

        public void Abrir()
        {
            Console.WriteLine("Nota: La alarma ya esta activa!");
        }

        public void Cerrar()
        {
            Console.WriteLine("Se inactivo la alarma");
            AlarmaInactiva inactivar = new AlarmaInactiva();
            inactivar.SetContext(_context);
            _context.SetEstado(inactivar);
        }
    }
}
