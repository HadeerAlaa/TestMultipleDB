using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestMultipleDB.EntityFramework
{
	// 1. DbContext
	public class FirstDB : AbpDbContext
	{
		public virtual DbSet<Person> Persons { get; set; }

		public FirstDB(DbContextOptions<FirstDB> options): base(options)
		{

		}
	}
}
