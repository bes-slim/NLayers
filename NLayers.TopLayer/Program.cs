using System;
using Ninject;
using NLayers.Models;

namespace NLayers.TopLayer
{
    class Program
    {
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
