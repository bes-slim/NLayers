using Ninject.Modules;
using NLayers.BottomLayer;

namespace NLayers.Resolver
{

    public class BottomModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBottomClass>().To<BottomClass>();
        }
    }

}