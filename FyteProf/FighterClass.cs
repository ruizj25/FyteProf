using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FyteProf
{
    public class FighterClass
    {  
        public int Rank { get; set; }
        public string Name { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Knockouts { get; set; }
        public int Submissions { get; set; }
        public double FightScore => FinishRate() + RankWeight() + Experience() + WinPercent();

        public int TotalFights()
        {
            return Win + Loss;
        }
        public double WinPercent()
        {
         
            return Win / TotalFights() * 100;
        }
        public double Experience()
        {
           var expPoints = TotalFights() * 3.125;
            if (expPoints >= 100)
            {
                var oldMan = TotalFights() - 32;
                return 100 - (oldMan * 5);
            }
           return expPoints;

        }

        public double RankWeight()
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

        public double FinishRate()
        {
            var fin = Submissions + Knockouts;
        
            return TotalFights() / fin * 100;
        }

     
    }
}

