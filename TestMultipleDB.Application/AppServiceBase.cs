using Abp.Application.Services;
using TestMultipleDB;

namespace TestMultipleDB
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AppServiceBase : ApplicationService
    {
        protected AppServiceBase()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }
    }
}