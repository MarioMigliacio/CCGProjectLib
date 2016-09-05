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
        Ocean,

        /// <summary>
        /// Selects the Coastal area type.
        /// </summary>
        Coast,

        /// <summary>
        /// Selects the Coastal area type.
        /// </summary>
        Shore,

        /// <summary>
        /// Selects the Hill land type.
        /// </summary>
        Hills,

        /// <summary>
        /// Selects the Hill land type.
        /// </summary>
        Valley,

        /// <summary>
        /// Selects the Open land type.
        /// </summary>
        Grassland,

        /// <summary>
        /// Selects the Forest type.
        /// </summary>
        Forest
    }
}
