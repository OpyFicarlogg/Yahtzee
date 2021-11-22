
using System.Collections.Generic;

namespace Yahtzee.Dto
{
    public class DiceThrow
    {
        public List<Dice> diceList { get; set; }
        public int round { get; set; }

        public DiceThrow()
        {
            this.diceList = new List<Dice>();
            round = 0;
        }
    }
}
