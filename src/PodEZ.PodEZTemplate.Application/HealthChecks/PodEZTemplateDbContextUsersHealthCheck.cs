using System;
using System.Threading;
using System.Threading.Tasks;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using PodEZ.PodEZTemplate.EntityFrameworkCore;

namespace PodEZ.PodEZTemplate.HealthChecks
{
    public class PodEZTemplateDbContextUsersHealthCheck : IHealthCheck
    {
        private readonly IDbContextProvider<PodEZTemplateDbContext> _dbContextProvider;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public PodEZTemplateDbContextUsersHealthCheck(
            IDbContextProvider<PodEZTemplateDbContext> dbContextProvider,
            IUnitOfWorkManager unitOfWorkManager
            )
        {
            _dbContextProvider = dbContextProvider;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                using (var uow = _unitOfWorkManager.Begin())
                {
                    // Switching to host is necessary for single tenant mode.
                    using (_unitOfWorkManager.Current.SetTenantId(null))
                    {
                        if (!await _dbContextProvider.GetDbContext().Database.CanConnectAsync(cancellationToken))
                        {
                            return HealthCheckResult.Unhealthy(
                                "PodEZTemplateDbContext could not connect to database"
                            );
                        }

                        var user = await _dbContextProvider.GetDbContext().Users.AnyAsync(cancellationToken);
                        uow.Complete();

                        if (user)
                        {
                            return HealthCheckResult.Healthy("PodEZTemplateDbContext connected to database and checked whether user added");
                        }

                        return HealthCheckResult.Unhealthy("PodEZTemplateDbContext connected to database but there is no user.");

                    }
                }
            }
            catch (Exception e)
            {
                return HealthCheckResult.Unhealthy("PodEZTemplateDbContext could not connect to database.", e);
            }
        }
    }
}
