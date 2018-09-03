using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionicAnt
{
    /// <summary>
    /// command invoker, command sender 
    /// interface-oriented progarmming
    /// </summary>
    public class Controller
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }

    }
}
