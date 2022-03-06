using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.data.model
{
    public class Plateau
    {
        public int xSize { get; }
        public int ySize { get; }
        public Plateau(int xSize, int ySize)
        {
            this.xSize = xSize;
            this.ySize = ySize;
        }
    }
}
