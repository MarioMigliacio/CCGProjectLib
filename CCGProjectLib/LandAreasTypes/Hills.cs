using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// HillsLand class defines a type of terrain which contains primarily Hilly and light sand / grass area.
    /// </summary>
    public class Hills : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Hilly terrain.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.Hills; } set { TileType = TerrainType.Hills; } }

        /// <summary>
        /// Provides a means to translate the HillsLand object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Hills";
        }
    }
}