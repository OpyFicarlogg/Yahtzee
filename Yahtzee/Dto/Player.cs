using System;
using System.Collections.Generic;
using Yahtzee.Dto.Score;

namespace Yahtzee.Dto
{
    public class Player
    {
        public Player(String name)
        {
            this.name = name;
            ScoreBoard = new List<ScoreLine>();
        }
        public String name { get; set; }
        public List<ScoreLine> ScoreBoard { get; set; }
    }
}
