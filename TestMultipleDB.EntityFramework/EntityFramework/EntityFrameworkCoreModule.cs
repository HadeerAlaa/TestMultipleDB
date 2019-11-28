using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Configuration.Startup;
using Abp.EntityFrameworkCore;

namespace TestMultipleDB.EntityFramework
{
	[DependsOn(
	typeof(CoreModule),
	typeof(AbpEntityFrameworkCoreModule))]
	public class EntityFrameworkCoreModule : AbpModule
	{
		public override void PreInitialize()
		{
			Configuration.ReplaceService<IConnectionStringResolver, MyConnectionStringResolver>();

			// Configure first DbContext
			Configuration.Modules.AbpEfCore().AddDbContext<FirstDB>(options =>
			{
				if (options.ExistingConnection != null)
				{
					FirstDbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
				}
				else
				{
					FirstDbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
				}
			});

			// Configure second DbContext
			Configuration.Modules.AbpEfCore().AddDbContext<SecondDB>(options =>
			{
				if (options.ExistingConnection != null)
				{
					SecondDbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
				}
				else
				{
					SecondDbContextOptionsConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
				}
			});
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(EntityFrameworkCoreModule).GetAssembly());
		}
	}
}
