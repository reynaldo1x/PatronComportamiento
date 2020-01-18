using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business
{
    public class CommandA : ICommand
    {
        protected Receptor receptor;

        public CommandA(Receptor _receptor)
        {
            receptor = _receptor;
        }

        public void EjecutarComando()
        {
            receptor.Operacion("A");
        }
    }
}
