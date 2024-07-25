using Microsoft.AspNetCore.Mvc;

namespace RealEstate__Dabber__UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
