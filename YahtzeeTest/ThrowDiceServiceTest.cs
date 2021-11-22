using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee.Dto;
using Yahtzee.Service;

namespace YahtzeeTest
{
    [TestClass]
    public class ThrowDiceServiceTest
    {  
        private readonly ThrowDiceService _throwDiceService = new ThrowDiceService();


        [TestMethod]
        public void Test_Throw5Dices()
        {
            Assert.AreEqual(5, _throwDiceService.ThrowDices().diceList.Count);
        }

        [TestMethod]
        public void Test_Throw4Dices()
        {
            DiceThrow diceThrow = _throwDiceService.ThrowDices();

            diceThrow.diceList[0].saved = true;

            _throwDiceService.SaveDice(diceThrow);

            Assert.AreEqual(diceThrow.diceList[0].value, _throwDiceService.ThrowDices().diceList[0].value);
        }

        [TestMethod]
        public void Test_CanBeThrow()
        {
            //1er lancé 
            _throwDiceService.ThrowDices();
            Assert.AreEqual(true, _throwDiceService.CanThrow());

            //Deuxième lancé 
            _throwDiceService.ThrowDices();
            Assert.AreEqual(true, _throwDiceService.CanThrow());

            //Troisième lancé 
            _throwDiceService.ThrowDices();
            //Plus possible de lancer 
            Assert.AreEqual(false, _throwDiceService.CanThrow());


        }

        [TestMethod]
        public void Test_CanBeThrowAfterStop()
        {
            //1er lancé 
            _throwDiceService.ThrowDices();
            Assert.AreEqual(true, _throwDiceService.CanThrow());

            //2ème lancé 
            _throwDiceService.ThrowDices();
            Assert.AreEqual(true, _throwDiceService.CanThrow());

            //3ème lancé 
            _throwDiceService.ThrowDices();
            Assert.AreEqual(false, _throwDiceService.CanThrow());

            //Deuxième lancé 
            _throwDiceService.EndRound();
            Assert.AreEqual(true, _throwDiceService.CanThrow());


        }


    }
}
