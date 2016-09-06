using CCGProjectLib.Enums;
using System;

namespace CCGProjectLib.UnitTypes
{
    /// <summary>
    /// BaseUnitType class defines what kind of Unit Type this object represents.
    /// </summary>
    public abstract class BaseUnitType : IDisposable
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
        /// Represents the MoveRange attribute for a basic unit type.
        /// </summary>
        public abstract byte MoveRange { get; set; }

        /// <summary>
        /// Represents the AttackRange attribute for a basic unit type.
        /// </summary>
        public abstract byte AttackRange { get; set; }

        /// <summary>
        /// Represents the Concealment attribute for a basic unit type.
        /// </summary>
        public abstract byte Concealment { get; set; }

        /// <summary>
        /// Method utilized for unit testing UnitType Objects.
        /// </summary>
        public abstract void DisplayString();

        /// <summary>
        /// Allows the outside world to dispose of this object.
        /// </summary>
        public abstract void Dispose();
    }
}
