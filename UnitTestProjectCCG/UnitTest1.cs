using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCGProjectLib.Containers;
using CCGProjectLib.Coordinates;
using CCGProjectLib.Enums;

namespace UnitTestProjectCCG
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WorldContainer theWorld = new WorldContainer();
            theWorld.AddTile(new Coordinate(0, 0), TerrainType.DeepWater);
            theWorld.DisplayMap();
        }
    }
}
