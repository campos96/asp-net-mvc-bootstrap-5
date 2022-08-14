using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc_bootstrap_5.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index() => RedirectToAction(nameof(Login));

		public IActionResult Login()
		{
			return View();
		}

	}
}
