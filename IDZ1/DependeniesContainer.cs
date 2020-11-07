using BusinessLogic.Abstractions;
using BusinessLogic.Implementations;
using Ninject.Modules;

namespace IDZ1
{
    public class DependeniesContainer : NinjectModule
    {
        public override void Load()
        {
            Bind<IGoogleSearch>().To<GoogleSearch>().InTransientScope();
            Bind<MainForm>().To<MainForm>().InSingletonScope();
        }
    }
}
