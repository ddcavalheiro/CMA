using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CMA.Configuration;
using CMA.Web;

namespace CMA.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CMADbContextFactory : IDesignTimeDbContextFactory<CMADbContext>
    {
        public CMADbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CMADbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CMADbContextConfigurer.Configure(builder, configuration.GetConnectionString(CMAConsts.ConnectionStringName));

            return new CMADbContext(builder.Options);
        }
    }
}
