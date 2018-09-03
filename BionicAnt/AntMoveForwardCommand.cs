using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionicAnt
{
    public class AntMoveForwardCommand: Command
    {
        private Ant _ant;

        public AntMoveForwardCommand(Ant ant)
        {
            this._ant = ant;
        }

        public void Execute()
        {
            _ant.MoveForward();
        }
    }
}
