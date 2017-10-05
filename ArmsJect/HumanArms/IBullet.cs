using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsJect.HumanArms
{
    public interface IBullet: IHumanTech
    {
        string BulletType { get; set; }
    }
}
