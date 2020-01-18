using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business
{
    public class CommandC : ICommand
    {
        protected Receptor receptor;

        public CommandC(Receptor _receptor)
        {
            receptor = _receptor;
        }

        public void EjecutarComando()
        {
            receptor.Operacion("C");
        }
    }
}
