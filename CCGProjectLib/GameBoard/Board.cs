using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCGProjectLib.GameBoard
{
    public class Board
    {
        public static void InitMap(char[,] map, Random rng)
        {
            int widthOfOcean = 6;

            for (int h = 0; h < 15; h++)
            {
                if (h == 0 || h == 14)
                {
                    for (int w = 0; w < 25; w++)
                    {
                        if (w < 6)
                        {
                            map[w, h] = 'O';
                        }
                        else if (w < 8)
                        {
                            map[w, h] = 'C';
                        }
                        else if (w < 11)
                        {
                            map[w, h] = 'S';
                        }
                        else if (w < 15)
                        {
                            map[w, h] = 'H';
                        }
                        else if (w < 20)
                        {
                            map[w, h] = 'G';
                        }
                        else
                        {
                            map[w, h] = 'F';
                        }
                    }
                }
                else
                {
                    widthOfOcean = getOceanWidth(widthOfOcean, rng, h);

                    for (int w = 0; w < 25; w++)
                    {
                        if (w < widthOfOcean)
                        {
                            map[w, h] = 'O';
                        }
                        else if (w < widthOfOcean + 2)
                        {
                            map[w, h] = 'C';
                        }
                        else if (w < widthOfOcean + 5)
                        {
                            map[w, h] = 'S';
                        }
                        else if (w < widthOfOcean + 9)
                        {
                            map[w, h] = 'H';
                        }
                        else if (w < widthOfOcean + 14)
                        {
                            map[w, h] = 'G';
                        }
                        else if (w < 25)
                        {
                            map[w, h] = 'F';
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

        public static void DispMap(char[,] map)
        {
            Console.Write(" /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\  /\\\n");

            for (int h = 0; h < 15; h++)
            {
                if (h % 2 == 1)
                {
                    String line1 = "";
                    String line2 = "";
                    String line3 = "";

                    for (int w = 0; w < 25; w++)
                    {
                        if (w == 0)
                        {
                            line1 += " \\";
                            line2 += "  ";
                            line3 += " /";
                        }
                        line1 += "/" + (char)(w + 65) + (char)(h + 65) + "\\";
                        if (map[w, h] == 'O')
                        {
                            //line1 += "/OO\\";
                            line2 += "|~~|";
                            line3 += "\\~~/";
                        }
                        else if (map[w, h] == 'C')
                        {
                            //line1 += "/CC\\";
                            line2 += "|--|";
                            line3 += "\\--/";
                        }
                        else if (map[w, h] == 'S')
                        {
                            //line1 += "/SS\\";
                            line2 += "|$$|";
                            line3 += "\\$$/";
                        }
                        else if (map[w, h] == 'H')
                        {
                            if (h != 7)
                            {
                                //line1 += "/HH\\";
                                line2 += "|##|";
                                line3 += "\\##/";
                            }
                            else
                            {
                                //line1 += "/VV\\";
                                line2 += "|>>|";
                                line3 += "\\>>/";
                            }
                        }
                        else if (map[w, h] == 'G')
                        {
                            //line1 += "/GG\\";
                            line2 += "|__|";
                            line3 += "\\__/";
                        }
                        else if (map[w, h] == 'F')
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

                    for (int w = 0; w < 25; w++)
                    {
                        line1 += "/" + (char)(w + 65) + (char)(h + 65) + "\\";

                        if (map[w, h] == 'O')
                        {
                            //line1 += "/CC\\";
                            line2 += "|~~|";
                            line3 += "\\~~/";
                        }
                        else if (map[w, h] == 'C')
                        {
                            //line1 += "/CC\\";
                            line2 += "|--|";
                            line3 += "\\--/";
                        }
                        else if (map[w, h] == 'S')
                        {
                            //line1 += "/SS\\";
                            line2 += "|$$|";
                            line3 += "\\$$/";
                        }
                        else if (map[w, h] == 'H')
                        {
                            //line1 += "/HH\\";
                            line2 += "|##|";
                            line3 += "\\##/";
                        }
                        else if (map[w, h] == 'G')
                        {
                            //line1 += "/GG\\";
                            line2 += "|__|";
                            line3 += "\\__/";
                        }
                        else if (map[w, h] == 'F')
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

    /* 
     /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\  /\
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/HH\/HH\/HH\/HH\/GG\/GG\/GG\/GG\/GG\/FF\/FF\/FF\/FF\/FF\
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||HH||HH||HH||HH||GG||GG||GG||GG||GG||FF||FF||FF||FF||FF|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\HH/\HH/\HH/\HH/\GG/\GG/\GG/\GG/\GG/\FF/\FF/\FF/\FF/\FF/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/HH\/HH\/HH\/HH\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||HH||HH||HH||HH||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\HH/\HH/\HH/\HH/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/HH\/HH\/HH\/HH\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||HH||HH||HH||HH||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\HH/\HH/\HH/\HH/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/HH\/HH\/HH\/HH\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||HH||HH||HH||HH||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\HH/\HH/\HH/\HH/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/HH\/HH\/HH\/HH\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||HH||HH||HH||HH||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\HH/\HH/\HH/\HH/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\
     \/OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\
      |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
     /\OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
    /OO\/OO\/OO\/OO\/OO\/OO\/CC\/CC\/SS\/SS\/SS\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/OO\/
    |OO||OO||OO||OO||OO||OO||CC||CC||SS||SS||SS||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO||OO|
    \OO/\OO/\OO/\OO/\OO/\OO/\CC/\CC/\SS/\SS/\SS/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/\OO/
     \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/

       /O\    /OO\    /OO\    /OO\    /OO\    /OO\    /CC\    /CC\    /SS\    /SS\    /SS\    /HH\    /HH\    /HH\    /HH\    /GG\    /GG\    /GG\    /GG\    /GG\    /FF\    /FF\    /FF\    /FF\    /FF\
      /OOO\  /OOOO\  /OOOO\  /OOOO\  /OOOO\  /OOOO\  /CCCC\  /CCCC\  /SSSS\  /SSSS\  /SSSS\  /HHHH\  /HHHH\  /HHHH\  /HHHH\  /GGGG\  /GGGG\  /GGGG\  /GGGG\  /GGGG\  /FFFF\  /FFFF\  /FFFF\  /FFFF\  /FFFF\
      \OOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \O/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\CCCC/CC\CCCC/CC\SSSS/SS\SSSS/SS\SSSS/SS\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/HH\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\
       \OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\CC/CCCC\CC/CCCC\SS/SSSS\SS/SSSS\SS/SSSS\HH/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\
       /OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/OO\OOOO/CC\CCCC/CC\CCCC/SS\SSSS/SS\SSSS/SS\SSSS/HH\HHHH/HH\HHHH/HH\HHHH/HH\HHHH/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/GG\GGGG/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/FF\FFFF/
      /OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/OOOO\OO/CCCC\CC/CCCC\CC/SSSS\SS/SSSS\SS/SSSS\SS/HHHH\HH/HHHH\HH/HHHH\HH/HHHH\HH/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/GGGG\GG/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/FFFF\FF/
      \OOOO/  \OOOO/  \OOOO/  \OOOO/  \OOOO/  \OOOO/  \CCCC/  \CCCC/  \SSSS/  \SSSS/  \SSSS/  \HHHH/  \HHHH/  \HHHH/  \HHHH/  \GGGG/  \GGGG/  \GGGG/  \GGGG/  \GGGG/  \FFFF/  \FFFF/  \FFFF/  \FFFF/  \FFFF/
       \OO/    \OO/    \OO/    \OO/    \OO/    \OO/    \CC/    \CC/    \SS/    \SS/    \SS/    \HH/    \HH/    \HH/    \HH/    \GG/    \GG/    \GG/    \GG/    \GG/    \FF/    \FF/    \FF/    \FF/    \FF/     */
