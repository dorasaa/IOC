using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
namespace InversionOfControlUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer ioc = new UnityContainer();


            classA a = new classA() { message = "Welcome to ioc" };
            classB b = new classB() { number = 10 };

            //  ioc.RegisterInstance(a);
            //ioc.RegisterInstance(b);
            ioc.RegisterType<IclassA, classA>(new ContainerControlledLifetimeManager());
            ioc.RegisterType<IclassB, classB>();

            classA a1 = ioc.Resolve<classA>();
            a1.message = "Hello world";
            classC test1 = ioc.Resolve<classC>();
            Console.WriteLine("Hi...");
             
        }
    }
}
