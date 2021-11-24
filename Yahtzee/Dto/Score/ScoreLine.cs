using System;
using Yahtzee.Enumeration;

namespace Yahtzee.Dto.Score
{
    public class ScoreLine
    {
        public String name { get; set; }
        public int Value { get; set; }
        public Boolean isSet { get; set; }
        public int defaultValue { get; set; }
        public Boolean yahtzee { get; set; }

        public ScoreLine(ScoreValues scoreValue)
        {
            this.name = scoreValue.ToString();
            this.defaultValue = (int)scoreValue;
        }
    }
}
