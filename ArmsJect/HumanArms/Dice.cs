using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsJect.HumanArms
{
    public class Dice: IMagicItem
    {
        public int DP { get; set; }

        public Dice()
        {
            this.DP = new System.Random().Next() % 1000;
        }
    }
}
