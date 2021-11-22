using System;
using System.Collections.Generic;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;

namespace Yahtzee.Service.Interface
{
    interface IScoreService
    {
        void setScoreBoard(Player player);

        Boolean IsFull(Player player);

        Boolean IsLineEmpty(Player player);

        List<ScoreLine> GetEmptyLines(Player player);

        int GetScore(Player player);


    }
}
