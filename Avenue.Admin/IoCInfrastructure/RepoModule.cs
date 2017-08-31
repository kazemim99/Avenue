using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac;

namespace Avenue.Admin.IoCInfrastructure
{
    public class RepoModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.Load("Avenu.Repository"))
               .Where(t => t.Name.EndsWith("Repo"))
               .AsImplementedInterfaces()
               .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}