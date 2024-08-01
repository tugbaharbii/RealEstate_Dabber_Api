using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate__Dabber__UI.Dtos.ToDoListDtos;
using System.Net.Http;

namespace RealEstate__Dabber__UI.ViewComponents.Dashboard
{
    public class _DashboardToDoListComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardToDoListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult>InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44325/api/ToDoLists");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultToDoListDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
