using System;
using System.Collections.Generic;
using System.Text;

namespace ArmsJect.HumanArms
{
    public interface ISword:IHumanTech
    {
        void Slash(string target);
        void Guard();
    }
}
