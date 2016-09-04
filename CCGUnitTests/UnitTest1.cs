using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCGProjectLib.Containers;
using CCGProjectLib.Coordinates;
using CCGProjectLib.LandAreasTypes;

namespace CCGUnitTests
{
    /// <summary>
    /// UnitTest class which provides a means to run unit tests on various core functionailites of CCGProjectLib.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This unit test simply tests the World Container and adds various land types of varying coordinates.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var world = new WorldContainer();
            world.AddTile(new Coordinate(0, 0), new DeepWater());
            world.AddTile(new Coordinate(0, 1), new DeepWater());
            world.AddTile(new Coordinate(1, 0), new DeepWater());

            world.AddTile(new Coordinate(0, 2), new CoastArea());
            world.AddTile(new Coordinate(1, 1), new CoastArea());
            world.AddTile(new Coordinate(1, 2), new CoastArea());
            world.AddTile(new Coordinate(2, 2), new CoastArea());

            world.DisplayMap();
        }
    }
}
