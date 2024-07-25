using Microsoft.AspNetCore.Mvc;

namespace RealEstate__Dabber__UI.ViewComponents.Layout
{
    public class _HeadarViewComponentPartial:Microsoft.AspNetCore.Mvc.ViewComponent
    {
     public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
