using asp_net_mvc_bootstrap_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp_net_mvc_bootstrap_5.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult DocumentExplorer()
		{
			return View();
		}

		public IActionResult DocumentTree()
		{
			return View();
		}

		public IActionResult Timeline()
		{
			return View();
		}

		public IActionResult TimelineDark()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}