using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCGProjectLib.Containers;
using CCGProjectLib.LandAreasTypes;
using CCGProjectLib.UnitTypes;
using System;

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
            world.AddTile("AA", new Ocean());
            world.AddTile("AB", new Ocean());
            world.AddTile("BA", new Ocean());

            world.AddTile("AC", new Coast());
            world.AddTile("BB", new Coast());
            world.AddTile("BC", new Coast());
            world.AddTile("CC", new Coast());

            world.DisplayMap();
        }

        /// <summary>
        /// This unit test is designed to mess around with basic unit type objects and observe their behavior.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            var inf1 = new Infantry();
            var inf2 = new Infantry();
            var inf3 = new Infantry();
            var inf4 = new Infantry();                        
            var inf5 = new Infantry();

            var eng1 = new Engineer();
            var eng2 = new Engineer();
            var eng3 = new Engineer();

            inf4.Dispose();
            eng2.Dispose();

            inf1.DisplayString();
            inf2.DisplayString();
            inf3.DisplayString();
            inf4.DisplayString();
            inf5.DisplayString();
            eng1.DisplayString();
            eng2.DisplayString();
            eng3.DisplayString();
        }

        /// <summary>
        /// This unit test is designed to mess around with basic unit type objects and observe their behavior.
        /// </summary>
        [TestMethod]
        public void MapTest()
        {
            WorldContainer map = new WorldContainer();
            Random rng = new Random();

            map.InitMap(rng);
            map.DisplayMap();
        }
    }
}
