using CCGProjectLib.Enums;

namespace CCGProjectLib.LandAreasTypes
{
    /// <summary>
    /// Forest class defines a type of terrain which contains primarily trees and shrubbery! (NI).
    /// </summary>
    public class Forest : BaseLandType
    {
        /// <summary>
        /// Defines this Land type as Forest area.
        /// </summary>
        public override TerrainType TileType { get { return TerrainType.Forest; } set { TileType = TerrainType.Forest; } }

        /// <summary>
        /// Provides a means to translate the Forest object into string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Forest";
        }
    }
}