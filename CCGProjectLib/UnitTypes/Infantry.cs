using System;
using CCGProjectLib.Enums;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace CCGProjectLib.UnitTypes
{
    /// <summary>
    /// Infantry is a Basic land soldier in the army.
    /// </summary>
    public class Infantry : BaseUnitType
    {
        private static int counter = 0;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        /// <summary>
        /// Whether or not this unit has been disposed.
        /// </summary>
        public bool Disposed { get; set; } = false;

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

        public int Id { get; set; }

        /// <summary>
        /// Provides a default Infantry UnitType object.
        /// </summary>
        public Infantry()
        {
            this.Id = System.Threading.Interlocked.Increment(ref counter);
        }

        /// <summary>
        /// ToString override returns this Infantry object with all its property values into string format.
        /// </summary>
        /// <returns>A stringly formatted version of this Infantry object.</returns>
        public override string ToString()
        {
            if (Disposed)
            {
                return null;
            }

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

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (Disposed)
            {
                return;
            }

            if (disposing)
            {
                handle.Dispose();
            }

            Disposed = true;
        }
    }
}
