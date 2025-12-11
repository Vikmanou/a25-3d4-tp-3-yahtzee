using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_3;

namespace TP_3_testsUnitaires
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestFourOfAKind1()
        {
            List<int> des = new List<int> { 4, 4, 4, 4, 2 };
            int score = CalculateurScore.FourOfAKind(des);
            Assert.AreEqual(18, score);
        }

        [TestMethod]
        public void TestSmallStraight1()
        {
            List<int> des = new List<int> { 1, 2, 3, 4, 6 };
            int score = CalculateurScore.SmallStraight(des);
            Assert.AreEqual(30, score);
        }

        [TestMethod]
        public void TestFullHouse1()
        {
            List<int> des = new List<int> { 2, 2, 3, 3, 3 };
            int score = CalculateurScore.FullHouse(des);
            Assert.AreEqual(25, score);
        }

        [TestMethod]
        public void TestYahtzee1()
        {
            List<int> des = new List<int> { 5, 5, 5, 5, 5 };
            int score = CalculateurScore.Yahtzee(des);
            Assert.AreEqual(50, score);
        }

        [TestMethod]
        public void TestYahtzee2()
        {
            List<int> des = new List<int> { 5, 1, 5, 5, 5 };
            int score = CalculateurScore.Yahtzee(des);
            Assert.AreEqual(0, score);
        }
    }
}
