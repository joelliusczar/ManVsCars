using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsJect.HumanArms
{
    public interface ICannon: IHumanTech
    {
        void Shoot(string target);
    }
}
