using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PodEZ.PodEZTemplate.Configuration;
using PodEZ.PodEZTemplate.Web;

namespace PodEZ.PodEZTemplate.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PodEZTemplateDbContextFactory : IDesignTimeDbContextFactory<PodEZTemplateDbContext>
    {
        public PodEZTemplateDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PodEZTemplateDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            PodEZTemplateDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PodEZTemplateConsts.ConnectionStringName));

            return new PodEZTemplateDbContext(builder.Options);
        }
    }
}