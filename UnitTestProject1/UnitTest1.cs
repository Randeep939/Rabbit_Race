using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit_Race;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Punter[] myPunter = new Punter[3];
        Rabbit[] myRabbit = new Rabbit[4];
        Property myProperty = new Property();

        [TestMethod]
        public void Punter()
        {
            int id = 2;
            int result = Convert.ToInt16(Factory.GetAPunter(id).PunterID);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void Number()
        {
            int result = Factory.Number();
            Assert.IsTrue(result > 0 && result < 50);
        }
    }
}
