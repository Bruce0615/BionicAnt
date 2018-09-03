using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BionicAnt
{
    /// <summary>
    ///  command receiver
    /// </summary>
    public class Ant
    {
        public int x { get; set; }
        public int y { get; set; }
        public Orientation h { get; set; }

        public void LeftRotate()
        {
            h = h - 3;
            if (h < Orientation.E)
            {
                h = Orientation.N;
            }
        }

        public void RightRotate()
        {
            h = h + 3;
            if (h > Orientation.N)
            {
                h = Orientation.E;
            }
        }

        public void MoveForward()
        {
            switch (h)
            {
                case Orientation.N:
                    y = y + 1;
                    break;
                case Orientation.S:
                    y = y - 1;
                    break;
                case Orientation.E:
                    x = x + 1;
                    break;
                case Orientation.W:
                    x = x - 1;
                    break;
                default:
                    break;
            }

        }
    }
}
