using State.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var initialState = new AlarmaActiva();
            var context = new Context(initialState);
            initialState.SetContext(context);

            //context.SetEstado(new AlarmaInactiva());
            context.Cerrar();

            //context.SetEstado(new AlarmaActiva());
            context.Cerrar();

            Console.ReadLine();
        }
    }
}
