using System;
using System.Collections.Generic;
using System.Text;

namespace ArmsJect.HumanArms
{
    public interface IBomb : IHumanTech
    {
        void Plant(string target);
        void Lob(string target);
    }
}
