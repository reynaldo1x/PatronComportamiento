using Command.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business
{
    public class Invoker
    {
        protected List<ICommand> lstcommand = new List<ICommand>();

        public void SetCommand(ICommand _command)
        {
            lstcommand.Add(_command);
        }

        public ICommand Get(int opt)
        {
            return this.lstcommand[opt];
        }
    }
}
