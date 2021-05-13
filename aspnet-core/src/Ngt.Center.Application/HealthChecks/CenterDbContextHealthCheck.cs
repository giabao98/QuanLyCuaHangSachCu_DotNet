using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Ngt.Center.EntityFrameworkCore;

namespace Ngt.Center.HealthChecks
{
    public class CenterDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public CenterDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("CenterDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("CenterDbContext could not connect to database"));
        }
    }
}
