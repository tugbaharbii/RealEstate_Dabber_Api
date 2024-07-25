using Microsoft.AspNetCore.Mvc;

namespace RealEstate__Dabber__UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSpinnerComponentPartial:ViewComponent
    {
         public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
