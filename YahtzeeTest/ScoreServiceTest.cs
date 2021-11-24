using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee.Dto;
using Yahtzee.Dto.Score;
using Yahtzee.Service;
using Yahtzee.Enumeration;

namespace YahtzeeTest
{
    [TestClass]
    public class ScoreServiceTest
    {
        readonly ScoreService _scoreService = new ScoreService();
        readonly Player player = new Player("Test");

        [TestMethod]
        public void Test_SetScoreBoard()
        {
            _scoreService.setScoreBoard(player);
            Assert.AreNotEqual(0,player.ScoreBoard.Count);
        }


        [TestMethod]
        public void Test_IsNotFull()
        {
            _scoreService.setScoreBoard(player);
            Assert.AreEqual(false, _scoreService.IsFull(player));
        }

        [TestMethod]
        public void Test_IsFull()
        {
            _scoreService.setScoreBoard(player);
            foreach(ScoreLine line in player.ScoreBoard)
            {
                line.isSet = true;
            }
            Assert.AreEqual(true, _scoreService.IsFull(player));
        }

        [TestMethod]
        public void Test_GetEmptyLine()
        {
            _scoreService.setScoreBoard(player);
            Assert.AreNotEqual(0, _scoreService.GetEmptyLines(player));
        }

        [TestMethod]
        public void Test_GetScoreEmpty()
        {
            _scoreService.setScoreBoard(player);
            
            Assert.AreEqual(0, _scoreService.GetScore(player));
        }

        [TestMethod]
        public void Test_GetScore()
        {
            _scoreService.setScoreBoard(player);

            foreach(ScoreLine line in player.ScoreBoard)
            {
                line.Value = 10;
            }

            Assert.AreEqual(130, _scoreService.GetScore(player));
        }
        [TestMethod]
        public void Test_SetScore()
        {
            _scoreService.setScoreBoard(player);
            ThrowDiceService throwDiceService = new ThrowDiceService();
            
            _scoreService.setScore(player, throwDiceService.ThrowDices(), Yahtzee.Enumeration.ScoreValues.Yahtzee);

            Assert.AreEqual(50, _scoreService.GetScore(player));
        }

        [TestMethod]
        public void Test_LineNotEmpty()
        {
            _scoreService.setScoreBoard(player);
            ThrowDiceService throwDiceService = new ThrowDiceService();

            _scoreService.setScore(player, throwDiceService.ThrowDices(), ScoreValues.Yahtzee);

            Assert.AreEqual(false, _scoreService.IsLineEmpty(player, ScoreValues.Yahtzee));
        }

        [TestMethod]
        public void Test_LineEmpty()
        {
            _scoreService.setScoreBoard(player);

            Assert.AreEqual(true, _scoreService.IsLineEmpty(player, ScoreValues.One));
        }




    }
}
