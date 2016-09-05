using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// HillsLand class defines a type of terrain which contains primarily Valley.
    /// </summary>
    public class Valley : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Valley terrain.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.Valley; } set { TileType = TerrainType.Valley; } }

        /// <summary>
        /// Provides a means to translate the Valley object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Valley";
        }
    }
}