using Microsoft.Extensions.DependencyInjection;
using PodEZ.PodEZTemplate.HealthChecks;

namespace PodEZ.PodEZTemplate.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<PodEZTemplateDbContextHealthCheck>("Database Connection");
            builder.AddCheck<PodEZTemplateDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
