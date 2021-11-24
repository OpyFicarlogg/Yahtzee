using System;
using System.Collections.Generic;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;
using Yahtzee.Enumeration;

namespace Yahtzee.Service.Interface
{
    interface IScoreService
    {
        void setScoreBoard(Player player);

        void setScore(Player player, DiceThrow diceThrow, ScoreValues scoreValue);

        Boolean IsFull(Player player);

        Boolean IsLineEmpty(Player player, ScoreValues scoreValue);

        List<ScoreLine> GetEmptyLines(Player player);

        int GetScore(Player player);


    }
}
