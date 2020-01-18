using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business
{
    public class CommandB : ICommand
    {
        protected Receptor receptor;

        public CommandB(Receptor _receptor)
        {
            receptor = _receptor;
        }

        public void EjecutarComando()
        {
            receptor.Operacion("B");
        }
    }
}
