using CCGProjectLib.Enums;

namespace CCGProjectLib.UnitTypes
{
    /// <summary>
    /// BaseUnitType class defines what kind of Unit Type this object represents.
    /// </summary>
    public abstract class BaseUnitType
    {
        /// <summary>
        /// Defined through inhereting classes, which type of Unit Type defines this Object.
        /// </summary>
        public abstract UnitType UnitType { get; set; }

        /// <summary>
        /// Represents the Defense attribute for a basic unit type.
        /// </summary>
        public abstract byte Defense { get; set; }

        /// <summary>
        /// Represents the Health attribute for a basic unit type.
        /// </summary>
        public abstract byte Health { get; set; }

        /// <summary>
        /// Represents the Attack attribute for a basic unit type.
        /// </summary>
        public abstract byte Attack { get; set; }

        /// <summary>
        /// Represents the Special attribute for a basic unit type.
        /// </summary>
        public abstract string Special { get; set; }

        /// <summary>
        /// Represents the units static Id.
        /// </summary>
        public abstract short Id { get; set; }

        /// <summary>
        /// Method utilized for unit testing UnitType Objects.
        /// </summary>
        public abstract void DisplayString();
    }
}
