using System;
using System.Collections.Generic;
using CCGProjectLib.Coordinates;
using CCGProjectLib.LandAreasTypes;

namespace CCGProjectLib.Containers
{
    /// <summary>
    /// WorldContainer class provides a public dictionary which contains the Coordinate (x,y) as its key,
    /// and the value corresponds to the BaseLandType object at that point.
    /// </summary>
    public class WorldContainer
    {
        /// <summary>
        /// Public access to the Dictionary which contain Key: coordinate (x,y), Value: Enum TerrainType.
        /// </summary>
        public Dictionary<Coordinate, BaseLandType> TileType { get; set; }

        /// <summary>
        /// Constructor for the World dude.
        /// </summary>
        public WorldContainer()
        {
            TileType = new Dictionary<Coordinate, BaseLandType>();
        }

        /// <summary>
        /// AddTile accepts a Coordinate and Terrain feature to initialize a land mass and add it to the collection.
        /// </summary>
        /// <param name="coord">The (X,Y) location for this land mass.</param>
        /// <param name="landType">The TerrainType enum associated with this land mass.</param>
        public void AddTile(Coordinate coord, BaseLandType landType)
        {
            if (TileType.ContainsKey(coord))
            {
                return;
            }

            TileType.Add(coord, landType);
        }

        /// <summary>
        /// Removes a coordinate tile key from the TileType dictionary.
        /// </summary>
        /// <param name="coordinate">The (X,Y) point to remove.</param>
        public void RemoveTile(Coordinate coordinate)
        {
            if (TileType.ContainsKey(coordinate))
            {
                TileType.Remove(coordinate);
            }
        }

        /// <summary>
        /// Calls Clear on the TileType dictionary.
        /// </summary>
        public void ClearMap()
        {
            TileType.Clear();
        }

        /// <summary>
        /// For displaying purposes of the map in format: (x, y) : LandType.
        /// </summary>
        public void DisplayMap()
        {
            foreach (var tile in TileType)
            { 
                Console.WriteLine($"{tile.Key.ToString()} : {tile.Value.ToString()}");
            }
        }
    }
}