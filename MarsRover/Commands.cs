using MarsRover.data.enums;
using MarsRover.data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface ICommands
    {
        void ExecuteCommand(CommandEnums command);
    }
    public class Commands : ICommands
    {
        protected RoverPosition position;
        protected Plateau plateau;
        public Commands(RoverPosition position, Plateau plateau)
        {
            this.position = position;
            this.plateau = plateau;
        }
        public void ExecuteCommand(CommandEnums command)
        {
            switch (command)
            {
                case CommandEnums.L:
                    commandLeft();
                    break;
                case CommandEnums.R:
                    commandRight();
                    break;
                case CommandEnums.M:
                    commandMove();
                    break;
                default:
                    throw new ArgumentException(string.Format("Invalid value: {0}", command));
            }
        }
        private void commandLeft()
        {
            switch (position.Direction)
            {
                case DirectionEnums.N:
                    position.Direction = DirectionEnums.W;
                    break;
                case DirectionEnums.E:
                    position.Direction = DirectionEnums.N;
                    break;
                case DirectionEnums.S:
                    position.Direction = DirectionEnums.E;
                    break;
                case DirectionEnums.W:
                    position.Direction = DirectionEnums.S;
                    break;
                default:
                    Console.WriteLine("Not Implemented Direction In CommandLeft");
                    break;
            }
        }
        private void commandRight()
        {
            switch (position.Direction)
            {
                case DirectionEnums.N:
                    position.Direction = DirectionEnums.E;
                    break;
                case DirectionEnums.E:
                    position.Direction = DirectionEnums.S;
                    break;
                case DirectionEnums.S:
                    position.Direction = DirectionEnums.W;
                    break;
                case DirectionEnums.W:
                    position.Direction = DirectionEnums.N;
                    break;
                default:
                    Console.WriteLine("Direction Not Implemented In CommandRight");
                    break;
            }
        }
        private void commandMove()
        {
            switch (position.Direction)
            {
                case DirectionEnums.N:
                    if(plateau.ySize > position.Y)
                    {
                        position.Y++;
                    }
                    else
                    {
                        Console.WriteLine("End Of The Plateau !!! Could Not Move");
                    }
                    break;
                case DirectionEnums.E:
                    if (plateau.xSize > position.X)
                    {
                        position.X++;
                    }
                    else
                    {
                        Console.WriteLine("End Of The Plateau !!! Could Not Move");
                    }
                    break;
                case DirectionEnums.S:
                    if (position.Y > 0)
                    {
                        position.Y--;
                    }
                    else
                    {
                        Console.WriteLine("End Of The Plateau !!! Could Not Move");
                    }
                    break;
                case DirectionEnums.W:
                    if (position.X > 0)
                    {
                        position.X--;
                    }
                    else
                    {
                        Console.WriteLine("End Of The Plateau !!! Could Not Move");
                    }
                    break;
                default:
                    Console.WriteLine("Direction Not Implemented In CommandRight");
                    break;
            }
        }
    }
}
