using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmsJect.HumanArms;
using ArmsJect.HumanArmsImplemtations;
using Ninject;
using Ninject.Extensions.Conventions;

namespace MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IGun>().To<Revolver>();

            IGun g = kernel.Get<IGun>();
            g.Shoot("Ork");

            kernel.Bind<IBigProjectile>().To<Missle>();
            kernel.Bind<ICannon>().To<Turret>();
            //kernel.Bind<IStructure>().To<Tower>();

            //IStructure structure = kernel.Get<IStructure>();

            //structure.Defend("Mech");

            kernel.Bind<IBullet>().To<ExplosiveBullet>();
            kernel.Rebind<IGun>().ToConstructor<SniperRifle>(c => new SniperRifle(c.Inject<IBullet>(), 15));
            kernel.Bind<IStructure>().ToConstructor<Tower>(c => new Tower(c.Inject<IGun>()));

            IStructure structure = kernel.Get<IStructure>();

            structure.Defend("Giant Lizard");

            kernel.Bind<ISword>().ToConstructor<MysterySword>(c => new MysterySword(c.Inject<bool>()));

            kernel.Bind<Dice>().ToSelf().InSingletonScope();

            kernel.Bind(c => c.FromAssemblyContaining<ISpell>().SelectAllClasses().BindDefaultInterfaces());

            var sp = kernel.GetAll<ISpell>();

            Dice d = kernel.Get<Dice>();

            Dice d2 = kernel.Get<Dice>();

            //ISword s = kernel.Get<ISword>(new Ninject.Parameters.ConstructorArgument("isEnergy", true));

            //s.Slash("Pirate");

            Console.ReadKey();
        }
    }
}
