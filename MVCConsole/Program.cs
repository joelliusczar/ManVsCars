using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArmsJect.HumanArms;
using ArmsJect.HumanArmsImplemtations;
using Ninject;

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

            kernel.Bind<ISword>().ToConstructor<MysterySword>(c => new MysterySword(c.Inject<bool>()));

            kernel.Bind<Dice>().ToSelf().InSingletonScope();

            Dice d = kernel.Get<Dice>();

            Dice d2 = kernel.Get<Dice>();

            ISword s = kernel.Get<ISword>(new Ninject.Parameters.ConstructorArgument("isEnergy", true));

            s.Slash("Pirate");

            Console.ReadKey();
        }
    }
}
