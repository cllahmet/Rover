using MarsRover.data.enums;
using MarsRover.data.model;
using MarsRover.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IRover
    {
        void ExecuteCommands(string commands);
        string GetCurrentPosition();
    }
    public class Rover: Commands, IRover
    {
        public Rover(RoverPosition position, Plateau plateau) : base(position, plateau)
        {
        }

        public void ExecuteCommands(string commands)
        {
            foreach(char c in commands)
            {
                CommandEnums cmd = Helpers.GetCommandEnum(c);
                ExecuteCommand(cmd);
            }
        }
        public string GetCurrentPosition()
        {
            return position.X + " " + position.Y + " " + position.Direction;
        }
        
    }
}
