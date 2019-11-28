using System;
using System.Collections.Generic;
using System.Text;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestMultipleDB.Localization;

namespace TestMultipleDB
{
	public class CoreModule: AbpModule
	{
		public override void PreInitialize()
		{
			Configuration.Auditing.IsEnabledForAnonymousUsers = true;

			LocalizationConfigurer.Configure(Configuration.Localization);
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(CoreModule).GetAssembly());
		}

	}
}
