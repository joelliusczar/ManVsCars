using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsJect.HumanArms
{
    public class MysterySword:ISword
    {
        public MysterySword(bool isEnergy)
        {

        }

        public void Slash(string target)
        {
            Console.WriteLine("Slash at {0} with the mystery sword",target);
        }

        public void Guard()
        {
            Console.WriteLine("Guarded with Mystery Sword");
        }
    }
}
