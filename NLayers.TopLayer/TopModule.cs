using Ninject;
using Ninject.Modules;

namespace NLayers.TopLayer
{
    public class TopModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ITopClass>().To<TopClass>();
        }
    }
}