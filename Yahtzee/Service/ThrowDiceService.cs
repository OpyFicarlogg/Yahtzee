using System;
using System.Collections.Generic;
using Yahtzee.Dto;
using Yahtzee.Service.Interface;

namespace Yahtzee.Service
{
    public class ThrowDiceService : IThrowDiceService
    {
        private readonly Random rnd;
        private DiceThrow diceThrow;
        private const int min = 1;
        private const int max = 6;
        private const int diceNumber = 5;
        private const int round = 3;
        public ThrowDiceService()
        {
            rnd = new Random();
            diceThrow = new DiceThrow();
        }

        private int ThrowDice()
        {
            return rnd.Next(min, max + 1);
        }

        public DiceThrow ThrowDices()
        {
            //Ajouter un contrôle sur le nb de round 
            if (diceThrow.diceList.Count.Equals(0))
            {
                List<Dice> lstDice = new List<Dice>();
                for(int i = 0; i < diceNumber; i++)
                {
                    lstDice.Add(new Dice(this.ThrowDice()));
                }
                diceThrow.diceList = lstDice;
            }
            else
            {
                foreach(Dice dice in diceThrow.diceList)
                {
                    if (!dice.saved)
                    {
                        dice.value = this.ThrowDice();
                    }
                }
            }

            diceThrow.round += 1;
            return diceThrow;
        }

        public void SaveDice(DiceThrow diceThrow)
        {
            this.diceThrow = diceThrow;
        }
        public bool CanThrow()
        {
            return this.diceThrow.round < round;
        }

        public void EndRound()
        {
            this.diceThrow = new DiceThrow();
        }

        

        
    }
}
