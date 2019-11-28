using Abp.AspNetCore.Mvc.Controllers;

namespace TestMultipleDB.Web.Controllers
{
    public abstract class BaseController: AbpController
    {
        protected BaseController()
        {
            LocalizationSourceName = AppConsts.LocalizationSourceName;
        }
    }
}