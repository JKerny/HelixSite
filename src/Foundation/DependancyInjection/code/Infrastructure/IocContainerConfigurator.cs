using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Glass.Mapper.Sc;

namespace HelixSite.Foundation.DependencyInjection.Infrastructure
{
    public class IocContainerConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(ISitecoreContext), typeof(SitecoreContext));
            serviceCollection.AddMvcControllers("*.Feature.*");
        }
    }
}