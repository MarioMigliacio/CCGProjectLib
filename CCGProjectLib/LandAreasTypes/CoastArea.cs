using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// CoastArea class defines a type of terrain which contains primarily beaches and low sea levels.
    /// </summary>
    public class CoastArea : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Coastal Area.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.CoastArea; } set { TileType = TerrainType.CoastArea; } }

        /// <summary>
        /// Provides a means to translate the CoastArea object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "CoastArea";
        }
    }
}