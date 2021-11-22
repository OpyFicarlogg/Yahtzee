using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee.Dto;
using Yahtzee.Service;

namespace YahtzeeTest
{
    [TestClass]
    class ScoreServiceTest
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
        public void Test_IsFull()
        {
            _scoreService.setScoreBoard(player);
            Assert.AreEqual(false, _scoreService.IsFull(player));
        }

        [TestMethod]
        public void Test_GetEmptyLine()
        {
            _scoreService.setScoreBoard(player);
            Assert.AreNotEqual(0, _scoreService.GetEmptyLines(player));
        }




    }
}
