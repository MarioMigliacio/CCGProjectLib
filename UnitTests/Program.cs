using CCGProjectLib.Containers;
using CCGProjectLib.Coordinates;
using CCGProjectLib.LandAreasTypes;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWorldContainer();
        }

        /// <summary>
        /// The setup structure to perform unit tests. something is weird with the UnitTest() C# built in.
        /// </summary>
        public static void TestWorldContainer()
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
