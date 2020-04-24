using System;
using Abp.IdentityServer4;
using IdentityServer4.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PodEZ.PodEZTemplate.Authorization.Users;
using PodEZ.PodEZTemplate.EntityFrameworkCore;

namespace PodEZ.PodEZTemplate.Web.IdentityServer
{
    public static class IdentityServerRegistrar
    {
        public static void Register(IServiceCollection services, IConfigurationRoot configuration, Action<IdentityServerOptions> setupOptions)
        {
            services.AddIdentityServer(setupOptions)
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(IdentityServerConfig.GetIdentityResources())
                .AddInMemoryApiResources(IdentityServerConfig.GetApiResources())
                .AddInMemoryClients(IdentityServerConfig.GetClients(configuration))
                .AddAbpPersistedGrants<PodEZTemplateDbContext>()
                .AddAbpIdentityServer<User>();
        }

        public static void Register(IServiceCollection services, IConfigurationRoot configuration)
        {
            Register(services, configuration, options => { });
        }
    }
}
