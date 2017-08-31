using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;
using Avenue.InfraStructure;

namespace Avenue.Admin.IoCInfrastructure
{
    public class EfModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(AvenueDbContext))
                   .As(typeof(IContext)).InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(Assembly.Load("Avenue.Service"))
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}