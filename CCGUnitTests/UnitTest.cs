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

            var eng1 = new Engineer();
            var eng2 = new Engineer();
            var eng3 = new Engineer();

            var scout1 = new Scout();
            var scout2 = new Scout();
            var scout3 = new Scout();

            var mar1 = new Marine();
            var mar2 = new Marine();
            var mar3 = new Marine();

            var light1 = new Light();
            var light2 = new Light();
            var light3 = new Light();

            var heavy1 = new Heavy();
            var heavy2 = new Heavy();
            var heavy3 = new Heavy();
            
            inf1.Dispose();
            eng2.Dispose();
            scout1.Dispose();
            mar3.Dispose();
            light2.Dispose();
            heavy1.Dispose();

            inf1.DisplayString();
            inf2.DisplayString();
            inf3.DisplayString();
            eng1.DisplayString();
            eng2.DisplayString();
            eng3.DisplayString();
            scout1.DisplayString();
            scout2.DisplayString();
            scout3.DisplayString();
            mar1.DisplayString();
            mar2.DisplayString();
            mar3.DisplayString();
            light1.DisplayString();
            light2.DisplayString();
            light3.DisplayString();
            heavy1.DisplayString();
            heavy2.DisplayString();
            heavy3.DisplayString();
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
