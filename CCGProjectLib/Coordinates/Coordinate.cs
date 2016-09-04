namespace CCGProjectLib.Coordinates
{
    /// <summary>
    /// Coordinate class defines the basic X-axis and Y-axis of a Location.
    /// </summary>
    public class Coordinate
    {
        /// <summary>
        /// Provides public access to the X-axis byte value. (range 0:255)
        /// </summary>
        public byte X { get; set; }

        /// <summary>
        /// Provides public access to the Y-axis byte value. (range 0:255)
        /// </summary>
        public byte Y { get; set; }

        /// <summary>
        /// The Coordinate object consists of an X and Y axis defined through byte argument parameters.
        /// </summary>
        /// <param name="x">The x axis location.</param>
        /// <param name="y">The y axis location.</param>
        public Coordinate(byte x, byte y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Provides a means to translate the Coordinate object into string format: (x, y).
        /// </summary>
        /// <returns>A string which contains: (x, y).</returns>
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
