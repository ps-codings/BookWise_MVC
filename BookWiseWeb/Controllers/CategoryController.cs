using Microsoft.AspNetCore.Mvc;

namespace BookWiseWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
