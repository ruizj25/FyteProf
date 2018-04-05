using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FightScoreTester
{
    using System.Collections.Generic;
    using FyteProf;

    [TestClass]
    public class FightScoreTester
    {

        public FighterClass fc = new FighterClass()
        {
            Rank = 1,
            Name = "Max Holloway",
            Win = 30,
            Loss = 10,
            Knockouts = 9,
            Submissions = 2
        };

        [TestMethod]
        public void RankWeightTest()
        {
            int a = 100;     
            double b = fc.RankWeight();
            Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void ExpTest()
        {
            var expMaybe = 60;
            var realExp = fc.Experience();
            Assert.AreEqual(expMaybe, realExp);
        }
    }
}
