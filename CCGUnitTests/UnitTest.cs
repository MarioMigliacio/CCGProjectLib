using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCGProjectLib.Containers;
using CCGProjectLib.Coordinates;
using CCGProjectLib.LandAreasTypes;
using CCGProjectLib.UnitTypes;

namespace CCGUnitTests
{
    /// <summary>
    /// UnitTest class which provides a means to run unit tests on various core functionailites of CCGProjectLib.
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// This unit test simply tests the World Container and adds various land types of varying coordinates.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            WorldContainer world = new WorldContainer();
            world.AddTile(new Coordinate(0, 0), new DeepWater());
            world.AddTile(new Coordinate(0, 1), new DeepWater());
            world.AddTile(new Coordinate(1, 0), new DeepWater());

            world.AddTile(new Coordinate(0, 2), new CoastArea());
            world.AddTile(new Coordinate(1, 1), new CoastArea());
            world.AddTile(new Coordinate(1, 2), new CoastArea());
            world.AddTile(new Coordinate(2, 2), new CoastArea());

            world.DisplayMap();
        }

        /// <summary>
        /// This unit test is designed to mess around with basic unit type objects and observe their behavior.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            BaseUnitType anyUnit = new Infantry();
            var unit2 = new Infantry();
            var unit3 = new Infantry();
            var unit4 = new Infantry();                        
            var unit5 = new Infantry();

            unit4.Dispose();
            
            anyUnit.DisplayString();
            unit2.DisplayString();
            unit3.DisplayString();
            unit4.DisplayString();
            unit5.DisplayString();
        }
    }
}
