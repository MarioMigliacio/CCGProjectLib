using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// DeepWater class defines a type of terrain which contains primarily open seas.
    /// </summary>
    public class DeepWater : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Deep Water.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.DeepWater;} set { TileType = TerrainType.DeepWater; } }

        /// <summary>
        /// Provides a means to translate the DeepWater object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "DeepWater";
        }
    }
}
