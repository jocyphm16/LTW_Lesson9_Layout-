using Microsoft.AspNetCore.Mvc;

namespace NetCoreLA7.Areas.Admins.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
