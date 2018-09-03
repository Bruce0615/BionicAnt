using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BionicAnt;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            PostageStamp.UpperRight = new Point(5, 5);

            // command receiver
            Ant ant = new Ant { x = 1, y = 2, h = Orientation.N };   
            // command sender
            Controller controller = new Controller();

            CallCommand(ant, "LMLMLMLMM", controller);
            Console.ReadLine();


        }

        public static void CallCommand(Ant ant, string operation, Controller controller)
        {
            AntLeftRotateCommand antLeftRotateCommand = new AntLeftRotateCommand(ant);
            AntRightRotateCommand antRightRotateCommand = new AntRightRotateCommand(ant);
            AntMoveForwardCommand antMoveForwardCommand = new AntMoveForwardCommand(ant);

            foreach(char c in operation)
            {
                if (c == 'L')
                {
                    controller.SetCommand(antLeftRotateCommand);
                    controller.ExecuteCommand();
                }
                else if (c == 'R')
                {
                    controller.SetCommand(antRightRotateCommand);
                    controller.ExecuteCommand();
                }
                else if (c == 'M')
                {
                    controller.SetCommand(antMoveForwardCommand);
                    controller.ExecuteCommand();
                }
            }

        }
    }
}
