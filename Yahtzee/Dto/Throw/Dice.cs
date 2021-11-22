using System;

namespace Yahtzee.Dto
{
    public class Dice
    {
        public int value { get; set; }
        public Boolean saved {get; set;}

        public Dice(int value)
        {
            this.value = value;
        }
    }
}
