using System;
using System.Collections.Generic;
using Yahtzee.Dto;

namespace Yahtzee.Service.Interface
{
    interface IThrowDiceService
    {
        DiceThrow ThrowDice();

        void SaveDice(DiceThrow diceThrow);

        Boolean CanThrow();

        void EndRound();
    }
}
