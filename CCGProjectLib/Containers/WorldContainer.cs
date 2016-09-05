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
        public Dictionary<string, BaseLandType> Map { get; set; }

        /// <summary>
        /// Constructor for the World dude.
        /// </summary>
        public WorldContainer()
        {
            Map = new Dictionary<string, BaseLandType>();
        }

        /// <summary>
        /// AddTile accepts a Coordinate and Terrain feature to initialize a land mass and add it to the collection.
        /// </summary>
        /// <param name="coord">The (X,Y) location for this land mass.</param>
        /// <param name="landType">The TerrainType enum associated with this land mass.</param>
        public void AddTile(string coord, BaseLandType landType)
        {
            if (Map.ContainsKey(coord))
            {
                return;
            }

            Map.Add(coord, landType);
        }

        /// <summary>
        /// Removes a coordinate tile key from the TileType dictionary.
        /// </summary>
        /// <param name="coordinate">The (X,Y) point to remove.</param>
        public void RemoveTile(string coordinate)
        {
            if (Map.ContainsKey(coordinate))
            {
                Map.Remove(coordinate);
            }
        }

        /// <summary>
        /// Calls Clear on the TileType dictionary.
        /// </summary>
        public void ClearMap()
        {
            Map.Clear();
        }

        /// <summary>
        /// For displaying purposes of the map in format: (x, y) : LandType.
        /// </summary>

        public void InitMap(Random rng)
        {
            int widthOfOcean = 6;

            for (byte h = 0; h < 15; h++)
            {
                if (h == 0 || h == 14)
                {
                    for (byte w = 0; w < 25; w++)
                    {

                        if (w < 6)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Ocean());
                        }
                        else if (w < 8)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Coast());
                        }
                        else if (w < 11)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Shore());
                        }
                        else if (w < 15)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Hills());
                        }
                        else if (w < 20)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Grassland());
                        }
                        else
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Forest());
                        }
                    }
                }
                else
                {
                    widthOfOcean = getOceanWidth(widthOfOcean, rng, h);

                    for (byte w = 0; w < 25; w++)
                    {
                        if (w < widthOfOcean)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Ocean());
                        }
                        else if (w < widthOfOcean + 2)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Coast());
                        }
                        else if (w < widthOfOcean + 5)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Shore());
                        }
                        else if (w < widthOfOcean + 9)
                        {
                            if (h != 7)
                            {
                                AddTile($"{(char)w + 65}{(char)h + 65}", new Hills());
                            }
                            else
                            {
                                AddTile($"{(char)w + 65}{(char)h + 65}", new Valley());
                            }
                        }
                        else if (w < widthOfOcean + 14)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Grassland());
                        }
                        else if (w < 25)
                        {
                            AddTile($"{(char)w + 65}{(char)h + 65}", new Forest());
                        }
                    }
                }
            }
        }

        private static int getOceanWidth(int currentWidth, Random rng, int height)
        {
            int rand = 0;

            switch (height)
            {
                case 1:
                    rand = rng.Next(1, 100);
                    if (rand < 34)
                    {
                        return --currentWidth;
                    }
                    else if (rand < 67)
                    {
                        return ++currentWidth;
                    }
                    else return currentWidth;
                case 2:
                    rand = rng.Next(1, 100);
                    if (rand < 34)
                    {
                        return --currentWidth;
                    }
                    else if (rand < 67)
                    {
                        return ++currentWidth;
                    }
                    else return currentWidth;
                case 3:
                    rand = rng.Next(1, 100);
                    if (rand < 34)
                    {
                        return --currentWidth;
                    }
                    else if (rand < 67)
                    {
                        return ++currentWidth;
                    }
                    else return currentWidth;
                case 4:
                    if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 5:
                    if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 1)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 6:
                    if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 1)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 7:
                    if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 1)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 8:
                    if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 1)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 9:
                    if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 1)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 10:
                    if (currentWidth == 1)
                        return 2;
                    else if (currentWidth == 10)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 2)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 11:
                    if (currentWidth == 2)
                        return 3;
                    else if (currentWidth == 10)
                        return 9;
                    else if (currentWidth == 9)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 3)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 12:
                    if (currentWidth == 3)
                        return 4;
                    else if (currentWidth == 9)
                        return 8;
                    else if (currentWidth == 8)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else if (currentWidth == 4)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(1, 100);
                        if (rand < 34)
                        {
                            return --currentWidth;
                        }
                        else if (rand < 67)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                case 13:
                    if (currentWidth == 4)
                        return 5;
                    else if (currentWidth == 8)
                        return 7;
                    else if (currentWidth == 7)
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return --currentWidth;
                        }
                        else return currentWidth;
                    }
                    else
                    {
                        rand = rng.Next(0, 100);
                        if (rand < 50)
                        {
                            return ++currentWidth;
                        }
                        else return currentWidth;
                    }
                default:
                    return currentWidth;
            }
        }

        public void DisplayMap()
        {
            Console.Write(" /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\\n");

            for (byte h = 0; h < 15; h++)
            {
                if (h % 2 == 1)
                {
                    String line1 = "";
                    String line2 = "";
                    String line3 = "";

                    for (byte w = 0; w < 25; w++)
                    {
                        if (w == 0)
                        {
                            line1 += " \\";
                            line2 += "  ";
                            line3 += " /";
                        }
                        line1 += "/" + (char)(w + 65) + (char)(h + 65) + "\\";
                        if (Map[$"{(char)w + 65}{(char)h + 65}"] is Ocean)
                        {
                            //line1 += "/OO\\";
                            line2 += "|~~|";
                            line3 += "\\~~/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Coast)
                        {
                            //line1 += "/CC\\";
                            line2 += "|--|";
                            line3 += "\\--/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Shore)
                        {
                            //line1 += "/SS\\";
                            line2 += "|$$|";
                            line3 += "\\$$/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Hills)
                        {
                            //line1 += "/HH\\";
                            line2 += "|##|";
                            line3 += "\\##/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Valley)
                        {
                            //line1 += "/VV\\";
                            line2 += "|>>|";
                            line3 += "\\>>/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Grassland)
                        {
                            //line1 += "/GG\\";
                            line2 += "|__|";
                            line3 += "\\__/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Forest)
                        {
                            //line1 += "/FF\\";
                            line2 += "|==|";
                            line3 += "\\==/";
                        }
                    }

                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);
                }
                else if (h % 2 == 0)
                {
                    String line1 = "";
                    String line2 = "";
                    String line3 = "";

                    for (byte w = 0; w < 25; w++)
                    {
                        line1 += "/" + (char)(w + 65) + (char)(h + 65) + "\\";

                        if (Map[$"{(char)w + 65}{(char)h + 65}"] is Ocean)
                        {
                            //line1 += "/OO\\";
                            line2 += "|~~|";
                            line3 += "\\~~/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Coast)
                        {
                            //line1 += "/CC\\";
                            line2 += "|--|";
                            line3 += "\\--/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Shore)
                        {
                            //line1 += "/SS\\";
                            line2 += "|$$|";
                            line3 += "\\$$/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Hills)
                        {
                            //line1 += "/HH\\";
                            line2 += "|##|";
                            line3 += "\\##/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Grassland)
                        {
                            //line1 += "/GG\\";
                            line2 += "|__|";
                            line3 += "\\__/";
                        }
                        else if (Map[$"{(char)w + 65}{(char)h + 65}"] is Forest)
                        {
                            //line1 += "/FF\\";
                            line2 += "|==|";
                            line3 += "\\==/";
                        }
                    }

                    Console.WriteLine(line1);
                    Console.WriteLine(line2);
                    Console.WriteLine(line3);
                }
            }

            Console.Write(" \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/  \\/\n");
        }
    }
}