using Microsoft.AspNetCore.Mvc;

namespace RealEstate__Dabber__UI.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
         return View();
        }
    }
}
