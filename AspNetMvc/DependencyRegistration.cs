using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMvcData.Leads;
using Ninject.Modules;

namespace AspNetMvc
{
    public class DependencyRegistration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<ILeadHandler>().To<MockLeadHandler>();
        }
    }
}