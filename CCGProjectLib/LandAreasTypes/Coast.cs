using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// Coast class defines a type of terrain which contains primarily beaches and low sea levels.
    /// </summary>
    public class Coast : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Coastal.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.Coast; } set { TileType = TerrainType.Coast; } }

        /// <summary>
        /// Provides a means to translate the Coast object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Coast";
        }
    }
}