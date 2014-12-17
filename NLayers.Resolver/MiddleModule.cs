using Ninject.Modules;
using NLayers.MiddleLayer;

namespace NLayers.Resolver
{
    public class MiddleModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMiddleClass>().To<MiddleClass>();
        }
    } 
}
