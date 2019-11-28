using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TestMultipleDB.EntityFramework
{
	public static class FirstDbContextOptionsConfigurer
	{
		public static void Configure(DbContextOptionsBuilder<FirstDB> dbContextOptions, string connectionString)
		{
			/* This is the single point to configure DbContextOptions for MultipleDbContextEfCoreDemoDbContext */
			dbContextOptions.UseSqlServer(connectionString);
		}

		public static void Configure(DbContextOptionsBuilder<FirstDB> dbContextOptions, DbConnection connection)
		{
			/* This is the single point to configure DbContextOptions for MultipleDbContextEfCoreDemoDbContext */
			dbContextOptions.UseSqlServer(connection);
		}
	}
}
