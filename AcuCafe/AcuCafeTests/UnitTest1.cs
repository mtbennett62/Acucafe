using NUnit.Framework;
using System;
using AcuCafe;
using System.Text;
using System.IO;

namespace Tests
{
    public class Tests
    {
        TextWriter m_normalOutput;
        StringWriter m_testingConsole;
        StringBuilder m_testingSB;

        [SetUp]
        public void Setup()
        {
            m_testingSB = new StringBuilder();
            m_testingConsole = new StringWriter(m_testingSB);
            m_normalOutput = System.Console.Out;
            System.Console.SetOut(m_testingConsole);
        }

        [Test]
        public void BaristaIsWarnedWhenAddingMilkToIceTea()
        {
            var drink = AcuCafe.AcuCafe.OrderDrink(new IceTea(), true, false);
            Assert.IsTrue(m_testingSB.ToString().Contains("We are unable to prepare your drink. Reason: You cannot add milk to Ice Tea"));
        }

        [Test]
        public void CanAddChocolateToExpresso()
        {
            var drink = AcuCafe.AcuCafe.OrderDrink(new Expresso(), false, false, true);
            Assert.AreEqual(2.3, drink.GetCost());
            Assert.IsTrue(m_testingSB.ToString().Contains("We are preparing the following drink for you: Expresso, with Chocolate"));

        }
        [Test]
        public void CostIsCorrectForTeaWithMilkAndSugar()
        {
            var drink = AcuCafe.AcuCafe.OrderDrink(new Tea(), true, true);
            Assert.AreEqual(2.0, drink.GetCost());
        }


    }
}