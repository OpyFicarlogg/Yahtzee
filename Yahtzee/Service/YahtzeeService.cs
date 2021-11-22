using System;
using System.Collections.Generic;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;
using Yahtzee.Service.Interface;

namespace Yahtzee.Service 
{
    public class YahtzeeService : IYahtzeeService
    {
        public List<ScoreLine> EndRound()
        {
            throw new NotImplementedException();
        }

        public Player initGame()
        {
            throw new NotImplementedException();
        }

        public DiceThrow Play()
        {
            throw new NotImplementedException();
        }

        public void Save(DiceThrow diceThrow)
        {
            throw new NotImplementedException();
        }

        public bool SetScore(ScoreLine scoreline)
        {
            throw new NotImplementedException();
        }
    }
}
