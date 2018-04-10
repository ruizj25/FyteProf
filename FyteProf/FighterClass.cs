using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyteProf
{
    using System.Windows;

    public class FighterClass
    {

        public int Rank { get; set; }
        public string Name { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Knockouts { get; set; }
        public int Submissions { get; set; }
        public double FightScore => FinishRate() + RankWeight() + Experience() + WinPercent();


        private double TotalFights()
        {
            return Win + Loss;
        }
        private double WinPercent()
        {
            double winPerc = Win / TotalFights() * 100;
            return Convert.ToDouble(winPerc.ToString("N"));

        }
        private double Experience()
        {
           var expPoints = TotalFights() * 3.125;
            if (expPoints >= 100)
            {
                var oldMan = TotalFights() - 32;
                return 100 - (oldMan * 5);
            }
           return Convert.ToDouble(expPoints.ToString("N"));

        }

        private double RankWeight()
        {
            int rankWeight;
            switch (Rank)
            {
                case 1:
                    rankWeight = 100;
                    break;
                case 2:
                    rankWeight = 90;
                    break;
                case 3:
                    rankWeight = 70;
                    break;
                case 4:
                    rankWeight = 60;
                    break;
                case 5:
                    rankWeight = 50;
                    break;
                default:
                    rankWeight = 40;
                    break;
            }         
            return rankWeight;
        }

        private double FinishRate()
        {

           var finRate = (Submissions + Knockouts) / TotalFights() * 100;
            return Convert.ToDouble(finRate.ToString("N"));
        }

        public void Score()
        {
          Console.WriteLine(
              $@"total fights = {TotalFights()} Win % = {WinPercent()} exp = {Experience()} 
                rank points = {RankWeight()} and finishrate = {FinishRate()}");
        
        }
    }
}

