using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;

namespace TestAutofac
{
    class TestExpressionRegistrations
    {
        public static void Start()
        {
            //Test1();
            Test2();
        }
        public static void Test2()
        {
            var builder = new ContainerBuilder();
            builder.Register((c, p) => { return new Cat(p.TypedAs<String>()); }).As<Animal>();
            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var animal = scope.Resolve<Animal>(new TypedParameter(typeof(String), "kitty"));
                animal.ShowName();
            }
        }

        public static void Test1()
        {
            var builder = new ContainerBuilder();
            builder.Register((c, p) => { return new Cat(p.Named<String>("name")); }).As<Animal>();
            var container = builder.Build();
            using (var scope = container.BeginLifetimeScope())
            {
                var animal = scope.Resolve<Animal>(new NamedParameter("name", "kitty"));
                animal.ShowName();
            }
        }
    }
}
