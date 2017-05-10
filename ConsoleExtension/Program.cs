using CCGProjectLib.GameBoard;
using CCGUnitTests;
using System;

namespace ConsoleExtension
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        private static bool testing = true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (testing == true)
            {
                UnitTest myUnitTest = new UnitTest();

                //myUnitTest.TestMethod1();
                myUnitTest.TestMethod2();
                myUnitTest.MapTest();
                //}
                //else
                //{
                //    GameLogic engine = new GameLogic();

                //    while (engine.getPlayerMoves())
                //    {

                //    }
                //}
            }

            Random rng = new Random();
            char[,] map = new char[25, 15];
            Board.InitMap(map, rng);

            Console.WriteLine("Press ENTER to make a map");
            while (true)
            {
                ConsoleKey storedKey = Console.ReadKey(true).Key;
                if (storedKey == ConsoleKey.Enter)
                {
                    Board.InitMap(map, rng);
                    Board.DispMap(map);
                    Console.WriteLine("Press ESC to stop...\r\nPress ENTER to make another map");
                }
                else if (storedKey == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
