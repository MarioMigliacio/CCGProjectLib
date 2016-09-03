namespace CCGProjectLib.Enums
{
    /// <summary>
    /// Enumeration field exposed to public access.
    /// Describes the terrain type of any given land area.
    /// </summary>
    public enum TerrainType
    {
        /// <summary>
        /// Defaults to no type.
        /// </summary>
        None, 

        /// <summary>
        /// Selects the Deep water type.
        /// </summary>
        DeepWater,

        /// <summary>
        /// Selects the Coastal area type.
        /// </summary>
        CoastArea,

        /// <summary>
        /// Selects the Hill land type.
        /// </summary>
        HillsLand,

        /// <summary>
        /// Selects the Open land type.
        /// </summary>
        OpenLand,

        /// <summary>
        /// Selects the Forest type.
        /// </summary>
        Forest
    }
}
