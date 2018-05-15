using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using InnovationSoft.Olh.Configuration;
using InnovationSoft.Olh.Web;

namespace InnovationSoft.Olh.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OlhDbContextFactory : IDesignTimeDbContextFactory<OlhDbContext>
    {
        public OlhDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OlhDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OlhDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OlhConsts.ConnectionStringName));

            return new OlhDbContext(builder.Options);
        }
    }
}
