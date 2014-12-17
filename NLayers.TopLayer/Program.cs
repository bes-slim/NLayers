using System;
using Ninject;
using NLayers.Models;

namespace NLayers.TopLayer
{
    class Program
    {
        // have a look at  : http://stackoverflow.com/questions/7903595/loading-modules-in-all-assemblies-in-ninject

        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new TopModule());

            //var modules = new List<INinjectModule>
            //{
            //    new MiddleModule(),
            //    new BottomModule()
            //};
            //kernel.Load(modules);
         

            kernel.Load("*.dll"); // or : kernel.Load(AppDomain.CurrentDomain.GetAssemblies());

            var topClass = kernel.Get<ITopClass>();
            
            var myValue = new MyValue() {Value = 5};
            var message = topClass.GetResult(myValue);
            Console.WriteLine(message);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
