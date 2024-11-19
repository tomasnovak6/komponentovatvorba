using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankovniPrikladPatek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovniPrikladPatek.Tests
{
    [TestClass()]
    public class UcetTests
    {
        [TestMethod()]
        public void VkladTest_Vlozeno1000_ZustatekNavysenO1000()
        {
            // arrange
            float zustatek = 1000;
            float vklad = 1000;
            float ocekavane = zustatek + vklad;
            Ucet u = new Ucet("test", zustatek);
            // act
            u.Vklad(vklad);
            // assert
            Assert.AreEqual(ocekavane, u.Zustatek);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidAmountException))]
        public void VkladTest_VkladZaporny_HaziInvalidAmountException()
        {
            // arrange
            float zustatek = 1000;
            float vklad = -1000;
            Ucet u = new Ucet("test", zustatek);
            // act
            u.Vklad(vklad);
        }
    }
}