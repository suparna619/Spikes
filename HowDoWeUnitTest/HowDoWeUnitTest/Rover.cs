using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MarseRover
{
    public class Rover
    {
        private Coordinate position;
        private Direction direction;

        public Rover(Coordinate position, Direction direction)
        {
           this.position = position;
           this.direction = direction;
        }

        public Coordinate CurrentPosition
        {
            get { return position; }
        }

        public Direction CurrentDirection
        {
            get { return direction; }
        }
    }
}
