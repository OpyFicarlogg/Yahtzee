using System;
using System.Collections.Generic;
using Yahtzee.Dto;

namespace Yahtzee.Service.Interface
{
    interface IThrowDiceService
    {
        DiceThrow ThrowDices();

        void SaveDice(DiceThrow diceThrow);

        Boolean CanThrow();

        void EndRound();
    }
}
