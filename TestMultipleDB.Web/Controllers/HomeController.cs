using Microsoft.AspNetCore.Mvc;
using TestMultipleDB.Services;
using TestMultipleDB.Web.Models;

namespace TestMultipleDB.Web.Controllers
{
	public class HomeController : BaseController
	{
		private readonly ITestAppService _testAppService;

		public HomeController(ITestAppService testAppService)
		{
			_testAppService = testAppService;
		}
		public ActionResult Index()
		{
			var data = _testAppService.GetPeopleAndCourses();
			var model = new HomeViewModel
			{
				Data = data
			};

			return View(model);
		}

		public ActionResult Privacy()
		{
			return View();
		}
	}
}
