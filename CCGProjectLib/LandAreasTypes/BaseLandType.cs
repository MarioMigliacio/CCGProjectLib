using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// BaseLandtype class defines what kind of field of terrain can exist on a given Land Unit.
    /// </summary>
    public abstract class BaseLandType
    {
        /// <summary>
        /// Defined through inhereting classes, which type of terrain defines this LandUnit Object.
        /// </summary>
        public abstract TerrainType TileType { get; set; }
    }
}