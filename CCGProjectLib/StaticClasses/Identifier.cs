using System.Runtime.Serialization;

namespace CCGProjectLib.StaticClasses
{
    /// <summary>
    /// TODO: not working!!
    /// </summary>
    public sealed class Identifier
    {
        private static short _id;
        private static bool _check;

        public static short Id { get { return _id; } }
        
        Identifier()
        {
            _id += 1;
        }
    }
}
