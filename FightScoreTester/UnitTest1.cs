using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FightScoreTester
{
    using System.Collections.Generic;
    using FyteProf;
    

    [TestClass]
    public class FightScoreTester
    {

        public FighterClass TestFighter = new FighterClass()
        {
            Rank = 1,
            Name = "Max Holloway",
            Win = 19,
            Loss = 4,
            Knockouts = 9,
            Submissions = 2
        };

        public FighterClass TestFighter2 = new FighterClass()
        {
            Rank = 2,
            Name = "Brian Ortega",
            Win = 14,
            Loss = 0,
            Knockouts = 3,
            Submissions = 7
        };

        [TestMethod]
        public void FightScore()
        {
         TestFighter.Score();
         Console.WriteLine(TestFighter.FightScore);
         
            TestFighter2.Score();
            Console.WriteLine(TestFighter2.FightScore);
        }

 
    }
}
