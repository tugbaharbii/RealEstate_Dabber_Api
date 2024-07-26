using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RealEstate__Dabber__UI.Dtos.CategoryDtos;
using RealEstate__Dabber__UI.Dtos.ProductDtos;

namespace RealEstate__Dabber__UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44325/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)
            { 
            var jsonData=await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);
            }

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateProduct() 
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:44325/api/Categories");
             
             var jsaonData=await responsemessage.Content.ReadAsStringAsync();
             var values=JsonConvert.DeserializeObject<List<resultCategoryDto>>(jsaonData);

            List<SelectListItem> categoryValues = (from x in values.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.v=categoryValues;
           
             

        return View();
        }
    }
}
