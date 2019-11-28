using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TestMultipleDB.Configuration;
using TestMultipleDB.Web;

namespace TestMultipleDB.EntityFramework
{
	public class SecondDBContextFactory : IDesignTimeDbContextFactory<SecondDB>
	{
		public SecondDB CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<SecondDB>();
			var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

			SecondDbContextOptionsConfigurer.Configure(
				builder,
				configuration.GetConnectionString(AppConsts.SecondDbConnectionStringName)
			);

			return new SecondDB(builder.Options);
		}
	}
}