using System;
using System.Collections.Generic;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;

namespace Yahtzee.Service.Interface
{
    interface IYahtzeeService
    {
        //Commence une partie, et retourne le premier joueur 
        Player initGame();

        //Lancé de dé, et retourne le résultat
        DiceThrow Play();

        //Sauvegarde des élémets du lancé 
        void Save(DiceThrow diceThrow);

        //Arrête le round, et récupère le liste des lignes de score disponibles
        List<ScoreLine> EndRound();

        //Ajoute la ligne dans le score
        Boolean SetScore(ScoreLine scoreline);
    }
}
