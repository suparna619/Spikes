using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarseRover
{
    public class Coordinate : IEquatable<Coordinate>
    {
        private readonly int _x;
        private readonly int _y;

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public bool Equals(Coordinate coordinateObj)
        {
            if (coordinateObj == null)
                return false;

            return (this._x == coordinateObj._x && this._y == coordinateObj._y) ? true : false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var coordinateObj = obj as Coordinate;

            return (coordinateObj != null) && (_x.Equals(coordinateObj._x) && _y.Equals(coordinateObj._y));
        }
    }
}
