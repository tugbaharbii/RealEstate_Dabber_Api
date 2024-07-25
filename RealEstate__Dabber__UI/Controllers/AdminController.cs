using Microsoft.AspNetCore.Mvc;

namespace RealEstate__Dabber__UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
