using System;
using System.Collections.Generic;
using System.Text;

namespace ArmsJect.HumanArms
{
    public interface ISpell: IHumanTech
    {
        void Cast(string target);
    }
}
