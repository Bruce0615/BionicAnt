using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionicAnt
{
    public class AntRightRotateCommand: Command
    {
        private Ant _ant;

        public AntRightRotateCommand(Ant ant)
        {
            this._ant = ant;
        }

        public void Execute()
        {
            _ant.RightRotate();
        }
    }
}
