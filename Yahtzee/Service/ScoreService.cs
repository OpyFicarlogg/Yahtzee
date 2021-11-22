using System;
using System.Collections.Generic;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;
using Yahtzee.Service.Interface;

namespace Yahtzee.Service
{
    public class ScoreService : IScoreService
    {

        public void setScoreBoard(Player player)
        {
            throw new NotImplementedException();
        }
        public List<ScoreLine> GetEmptyLines(Player player)
        {
            throw new NotImplementedException();
        }

        public int GetScore(Player player)
        {
            throw new NotImplementedException();
        }

        public bool IsFull(Player player)
        {
            throw new NotImplementedException();
        }

        public bool IsLineEmpty(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
