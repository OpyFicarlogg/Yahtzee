using System;
using System.Collections.Generic;
using System.Linq;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;
using Yahtzee.Enumeration;
using Yahtzee.Service.Interface;

namespace Yahtzee.Service
{
    public class ScoreService : IScoreService
    {

        public void setScoreBoard(Player player)
        {
            player.ScoreBoard = new List<ScoreLine>();
            foreach (ScoreValues scoreValue in (ScoreValues[])Enum.GetValues(typeof(ScoreValues)))
            {
                player.ScoreBoard.Add(new ScoreLine(scoreValue));
            }
        }

        //TODO: ajouter param yahtzee
        public void setScore(Player player,DiceThrow diceThrow,ScoreValues scoreValue)
        {
            foreach(ScoreLine line in player.ScoreBoard)
            {
                if (line.name.Equals(scoreValue.ToString()))
                {
                    line.isSet = true;
                    line.Value = (line.defaultValue.Equals(0) ? diceThrow.diceList.Sum(dice => dice.value) : line.defaultValue);
                }
                //TODO: Passer au prochain user ?
            }
        }
        public List<ScoreLine> GetEmptyLines(Player player)
        {
            return player.ScoreBoard.Where(line => !line.isSet).ToList();
        }

        public int GetScore(Player player)
        {
            return player.ScoreBoard.Sum(line => line.Value);
        }

        public Boolean IsFull(Player player)
        {
            return player.ScoreBoard.Any(line => line.isSet);
        }

        public Boolean IsLineEmpty(Player player, ScoreValues scoreValue)
        {
            return player.ScoreBoard.Any(line => !line.isSet && line.name.Equals(scoreValue.ToString()));
        }
    }
}
