using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmsJect.HumanArms
{
    public class Turret:ICannon
    {

        public IBigProjectile projectileType { get; set; }

        public Turret(IBigProjectile projectileType)
        {
            this.projectileType = projectileType;
        }

        public void Shoot(string target)
        {
            Console.WriteLine(String.Format("Turret shoots {0} at {1}",this.projectileType.ProjectileType,target));
        }
    }
}
