using CCGProjectLib.Containers;
using CCGProjectLib.UnitTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCGProjectLib.StaticClasses
{
    public class GameLogic
    {
        string player1Turn = "";
        string player2Turn = "";

        public Dictionary<string, BaseUnitType> player1Units { get; set; }
        public Dictionary<string, BaseUnitType> player2Units { get; set; }

        WorldContainer map = new WorldContainer();

        public bool getPlayerMoves()
        {


            return true;
        }
    }
}
