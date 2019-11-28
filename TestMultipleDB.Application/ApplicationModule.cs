using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TestMultipleDB;

namespace TestMultipleDB
{
    [DependsOn(
        typeof(CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ApplicationModule).GetAssembly());
        }
    }
}