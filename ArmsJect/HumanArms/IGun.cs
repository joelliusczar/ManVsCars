using System;
using System.Collections.Generic;
using System.Text;

namespace ArmsJect.HumanArms
{
    public interface IGun: IHumanTech
    {
        void Shoot(string target);
    }
}
