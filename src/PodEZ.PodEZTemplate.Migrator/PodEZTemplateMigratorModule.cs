using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using PodEZ.PodEZTemplate.Configuration;
using PodEZ.PodEZTemplate.EntityFrameworkCore;
using PodEZ.PodEZTemplate.Migrator.DependencyInjection;

namespace PodEZ.PodEZTemplate.Migrator
{
    [DependsOn(typeof(PodEZTemplateEntityFrameworkCoreModule))]
    public class PodEZTemplateMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PodEZTemplateMigratorModule(PodEZTemplateEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PodEZTemplateMigratorModule).GetAssembly().GetDirectoryPathOrNull(), addUserSecrets: true
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PodEZTemplateConsts.ConnectionStringName
                );
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PodEZTemplateMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}