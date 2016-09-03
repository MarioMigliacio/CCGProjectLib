using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// OpenLand class defines a type of terrain which contains primarily open land areas.
    /// </summary>
    public class OpenLand : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Open Land area.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.OpenLand; } set { TileType = TerrainType.OpenLand; } }

        /// <summary>
        /// Provides a means to translate the OpenLand object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "OpenLand";
        }
    }
}