using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TestMultipleDB.EntityFramework
{
	public static class SecondDbContextOptionsConfigurer
	{
		public static void Configure(DbContextOptionsBuilder<SecondDB> dbContextOptions, string connectionString)
		{
			/* This is the single point to configure DbContextOptions for MultipleDbContextEfCoreDemoDbContext */
			dbContextOptions.UseSqlServer(connectionString);
		}

		public static void Configure(DbContextOptionsBuilder<SecondDB> dbContextOptions, DbConnection connection)
		{
			/* This is the single point to configure DbContextOptions for MultipleDbContextEfCoreDemoDbContext */
			dbContextOptions.UseSqlServer(connection);
		}
	}
}
