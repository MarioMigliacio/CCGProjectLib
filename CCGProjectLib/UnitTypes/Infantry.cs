using System;
using CCGProjectLib.Enums;
using CCGProjectLib.StaticClasses;
using System.Text;

namespace CCGProjectLib.UnitTypes
{
    /// <summary>
    /// Infantry is a Basic land soldier in the army.
    /// </summary>
    public class Infantry : BaseUnitType
    {
        private short _id;
        /// <summary>
        /// Attack property returned range: { 0, 255 }.
        /// </summary>
        public override byte Attack { get { return 1; } set { value = 1; } }

        /// <summary>
        /// Defense property returned range: { 0, 255 }.
        /// </summary>
        public override byte Defense { get { return 1; } set { value = 1; } }

        /// <summary>
        /// Health property returned range: { 0, 255 }.
        /// </summary>
        public override byte Health { get { return 1; } set { value = 1; } }

        /// <summary>
        /// Special attribute associated with Infantry : SpecialStrings.Infantry.
        /// </summary>
        public override string Special { get { return UserStrings.SpecialStrings.BasicInfantry; } set { value = UserStrings.SpecialStrings.BasicInfantry; } }
        
        /// <summary>
        /// UnitType enumeration associated with Infantry : UnitType.Infantry.
        /// </summary>
        public override UnitType UnitType { get { return UnitType.Infantry; } set { value = UnitType.Infantry; } }

        public override short Id { get { return _id; } set { _id = value; } }

        /// <summary>
        /// Provides a default Infantry UnitType object.
        /// </summary>
        public Infantry(short id)
        {
            Id = id;
        }

        /// <summary>
        /// ToString override returns this Infantry object with all its property values into string format.
        /// </summary>
        /// <returns>A stringly formatted version of this Infantry object.</returns>
        public override string ToString()
        {
            StringBuilder formattedText = new StringBuilder();

            formattedText.Append($"ID : {Id}\n");
            formattedText.Append($"Attack : {Attack}\n");
            formattedText.Append($"Defense : {Defense}\n");
            formattedText.Append($"Health : {Health}\n");
            formattedText.Append($"Special : {Special}\n");
            formattedText.Append($"UnitType : {UnitType}\n");

            return formattedText.ToString();
        }

        /// <summary>
        /// This DisplayString function is for display purposes only for unit tests.
        /// </summary>
        public override void DisplayString()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
