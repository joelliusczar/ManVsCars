using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsJect.HumanArms
{
    public class Tower: IStructure
    {
        public ICannon MountedCannon { get; set; }
        public IGun MountedGun { get; set; }

        public Tower(ICannon mountedCannon)
        {
            this.MountedCannon = mountedCannon;
        }

        public Tower(IGun mountedGun)
        {
            this.MountedGun = mountedGun;
        }

        public void Defend(string target)
        {
            Console.WriteLine("Defend by...");
            this.MountedGun?.Shoot(target);
            this.MountedCannon?.Shoot(target);
        }
    }
}
