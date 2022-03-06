using MarsRover.data.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.data.model
{
    public class RoverPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnums Direction { get; set; }
        public RoverPosition(int x, int y, char direction)
        {
            X = x;
            Y = y;
            Direction = (DirectionEnums)direction;
        }
    }
}
