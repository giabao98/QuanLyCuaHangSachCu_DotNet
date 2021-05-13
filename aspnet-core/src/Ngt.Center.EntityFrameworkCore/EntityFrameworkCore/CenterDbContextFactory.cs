using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Ngt.Center.Configuration;
using Ngt.Center.Web;

namespace Ngt.Center.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CenterDbContextFactory : IDesignTimeDbContextFactory<CenterDbContext>
    {
        public CenterDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CenterDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            CenterDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CenterConsts.ConnectionStringName));

            return new CenterDbContext(builder.Options);
        }
    }
}