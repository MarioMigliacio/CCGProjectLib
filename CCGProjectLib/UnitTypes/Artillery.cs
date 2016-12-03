using System;
using CCGProjectLib.Enums;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using NLog;

namespace CCGProjectLib.UnitTypes
{
    /// <summary>
    /// Artillery is an infantry unit with the ability to bombard units from very long range but requires vision.
    /// </summary>
    public class Artillery : BaseUnitType
    {
        /// <summary>
        ///  _counter is in place to hold the unique ID for the Artillery object.
        ///  _handle is needed to utilize Dispose();
        ///  _logger is the instance of the logger for this class.
        /// </summary>
        private static int _counter = 0;
        private SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Attack property returned range: { 0, 255 }.
        /// </summary>
        public override byte Attack { get { return 2; } set { Attack = 2; } }

        /// <summary>
        /// AttackRange property returned range: {0, 255}.
        /// </summary>
        public override byte AttackRange { get { return 6; } set { AttackRange = 6; } }

        /// <summary>
        /// Concealment property returned range: {0, 255}.
        /// </summary>
        public override bool Concealed { get { return true; } set { Concealed = true; } }

        /// <summary>
        /// Cover property returned range: {0, 255}.
        /// </summary>
        public override byte Cover { get { return 1; } set { Cover = 1; } }

        /// <summary>
        /// Defense property returned range: { 0, 255 }.
        /// </summary>
        public override byte Defense { get { return 1; } set { Defense = 1; } }

        /// <summary>
        /// Whether or not this unit has been disposed.
        /// </summary>
        public bool Disposed { get; set; } = false;

        /// <summary>
        /// Health property returned range: { 0, 255 }.
        /// </summary>
        public override byte Health { get { return 1; } set { Health = 1; } }

        /// <summary>
        /// Corresponds to the unique counter value for a particular Artillery Unit.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// MoveRange property returned range: {0, 255}.
        /// </summary>
        public override byte MoveRange { get { return 1; } set { MoveRange = 1; } }

        /// <summary>
        /// Special property associated with Artillery : SpecialStrings.Artillery.
        /// </summary>
        public override string Special { get { return UserStrings.SpecialStrings.Artillery; } set { Special = UserStrings.SpecialStrings.Artillery; } }

        /// <summary>
        /// UnitType enumeration associated with Artillery : UnitType.Artillery.
        /// </summary>
        public override UnitType UnitType { get { return UnitType.Artillery; } set { UnitType = UnitType.Artillery; } }

        /// <summary>
        /// Vision property returned range: {0, 255}.
        /// </summary>
        public override byte Vision { get { return 2; } set { Vision = 2; } }

        /// <summary>
        /// Provides a default Artillery UnitType object.
        /// </summary>
        public Artillery()
        {
            this.Id = System.Threading.Interlocked.Increment(ref _counter);
            _logger.Trace(string.Format(UserStrings.SpecialStrings.LogInstanceCreated, this.UnitType, this.Id));
        }

        /// <summary>
        /// ToString override returns this Artillery object with all its property values into string format.
        /// </summary>
        /// <returns>A stringly formatted version of this Artillery object.</returns>
        public override string ToString()
        {
            if (Disposed)
            {
                return null;
            }

            StringBuilder formattedText = new StringBuilder();

            formattedText.Append($"ID : {Id}\n");
            formattedText.Append($"Attack : {Attack}\n");
            formattedText.Append($"AttackRange : {AttackRange}\n");
            formattedText.Append($"Concealed : {Concealed}\n");
            formattedText.Append($"Covered : {Cover}\n");
            formattedText.Append($"Defense : {Defense}\n");
            formattedText.Append($"Health : {Health}\n");
            formattedText.Append($"MoveRange : {MoveRange}\n");
            formattedText.Append($"Special : {Special}\n");
            formattedText.Append($"UnitType : {UnitType}\n");
            formattedText.Append($"Vision : {Vision}\n");

            return formattedText.ToString();
        }

        /// <summary>
        /// This DisplayString function is for display purposes only for unit tests.
        /// </summary>
        public override void DisplayString()
        {
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// Allows the world to dispose of this Artillery instance object.
        /// </summary>
        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Manages the state of this Artillery object. Sets the Disposed property when the garbage collector finishes its job.
        /// </summary>
        /// <param name="disposing">Logic to perform the disposal process.</param>
        public void Dispose(bool disposing)
        {
            if (Disposed)
            {
                return;
            }

            if (disposing)
            {
                _logger.Trace(string.Format(UserStrings.SpecialStrings.LogInstanceDisposed, this.UnitType, this.Id));
                _handle.Dispose();
            }

            Disposed = true;
        }
    }
}
