using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestMultipleDB.EntityFramework
{
	// 2. DbContext
	public class SecondDB: AbpDbContext
	{
		public virtual DbSet<Course> Courses { get; set; }

		public SecondDB(DbContextOptions<SecondDB> options) : base(options)
		{

		}
	}
}
