using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionicAnt
{
    public class AntLeftRotateCommand: Command
    {
        private Ant _ant;

        public AntLeftRotateCommand(Ant ant)
        {
            this._ant = ant;
        }

        public void Execute()
        {
            _ant.LeftRotate();
        }

    }
}
