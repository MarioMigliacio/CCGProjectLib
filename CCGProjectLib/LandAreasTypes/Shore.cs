using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// Shore class defines a type of terrain which contains primarily beaches.
    /// </summary>
    public class Shore : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Shore.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.Shore; } set { TileType = TerrainType.Shore; } }

        /// <summary>
        /// Provides a means to translate the Shore object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Shore";
        }
    }
}