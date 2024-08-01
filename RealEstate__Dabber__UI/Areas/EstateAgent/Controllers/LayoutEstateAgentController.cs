using Microsoft.AspNetCore.Mvc;

namespace RealEstate__Dabber__UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class LayoutEstateAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
