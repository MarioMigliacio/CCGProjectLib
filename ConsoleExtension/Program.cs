using CCGProjectLib.StaticClasses;
using CCGUnitTests;

namespace ConsoleExtension
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        private static bool testing = false;

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
            }
            else
            {
                GameLogic engine = new GameLogic();

                while (engine.getPlayerMoves())
                {

                }
            }
        }
            //myUnitTest.TestMethod1();
            myUnitTest.TestMethod2();
            //myUnitTest.MapTest();
        }
    }
}
