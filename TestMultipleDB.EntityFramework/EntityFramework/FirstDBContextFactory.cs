using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestMultipleDB.Configuration;
using TestMultipleDB.Web;

namespace TestMultipleDB.EntityFramework
{
	public class FirstDBContextFactory : IDesignTimeDbContextFactory<FirstDB>
	{
		public FirstDB CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<FirstDB>();
			var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

			FirstDbContextOptionsConfigurer.Configure(
				builder,
				configuration.GetConnectionString(AppConsts.ConnectionStringName)
			);

			return new FirstDB(builder.Options);
		}
	}

	/* This class is needed to run EF Core PMC commands. Not used anywhere else */
}
