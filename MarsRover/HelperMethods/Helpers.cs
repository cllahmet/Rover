using MarsRover.data.enums;
using MarsRover.data.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.HelperMethods
{
    public static class Helpers
    {
        public static CommandEnums GetCommandEnum(char c)
        {
            if(Enum.TryParse(c.ToString(), out CommandEnums e))
            {
                return e;
            }
            return CommandEnums.error;
        }
        public static DirectionEnums GetDirectionEnum(char c)
        {
            if (Enum.TryParse(c.ToString(), out DirectionEnums e))
            {
                return e;
            }
            return DirectionEnums.error;
        }
        public static Plateau GetPlateau(List<string> plateauCoordinates)
        {
            if(plateauCoordinates != null && plateauCoordinates.Count > 1)
            {
                if (int.TryParse(plateauCoordinates[0], out int x) && int.TryParse(plateauCoordinates[1], out int y))
                {
                    return new Plateau(x, y);
                }
            }
            return null;
        }
        public static RoverPosition GetRoverPosition(List<string> position)
        {
            if (position != null && position.Count > 2)
            {
                if (int.TryParse(position[0], out int x) && int.TryParse(position[1], out int y) && char.TryParse(position[2], out char d))
                {
                    return new RoverPosition(x, y, d);
                }
            }
            return null;
        }
    }
}
