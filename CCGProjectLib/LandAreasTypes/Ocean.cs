using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// Ocean class defines a type of terrain which contains primarily open seas.
    /// </summary>
    public class Ocean : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Ocean.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.Ocean;} set { TileType = TerrainType.Ocean; } }

        /// <summary>
        /// Provides a means to translate the Ocean object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Ocean";
        }
    }
}
