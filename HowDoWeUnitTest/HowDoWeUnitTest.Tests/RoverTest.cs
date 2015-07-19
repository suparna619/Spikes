using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarseRover.Tests
{
    class RoverTest
    {
        [TestFixture]
        public class RoverTests
        {
            private Rover rover;

            [SetUp]
            public void Init()
            {
                rover = new Rover(new Coordinate(0, 0), Direction.NORTH);
            }

            [Test]
            public void ShouldCreateRover()
            {
                Assert.AreEqual(rover.CurrentPosition, new Coordinate(0, 0));
                Assert.AreEqual(rover.CurrentDirection, Direction.NORTH);
            }

            [Test]
            public void AreTwoCoordinatesWithSameValuesEqual()
            {
                var coord1 = new Coordinate(0, 0);
                var coord2 = new Coordinate(0, 0);

                Assert.AreEqual(coord1, coord2);
            }

            [Test]
            public void AreTwoDirectionsWithSameValuesEqual()
            {
                var direction1 = Direction.NORTH;
                var direction2 = Direction.NORTH;

                Assert.AreEqual(direction1, direction2);
            }

            [Test]
            public void AreTwoCoordinateObjectsEqualTest()
            {
                var cord1 = new Coordinate(9, 20);
                var cord2 = new Tuple<int, int>(9, 20);

                Assert.AreNotEqual(cord1, cord2);
            }
        }
    }
}
