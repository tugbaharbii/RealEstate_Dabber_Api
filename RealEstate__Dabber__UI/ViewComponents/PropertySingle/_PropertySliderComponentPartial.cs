﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate__Dabber__UI.Dtos.PropertyImageDto;

namespace RealEstate__Dabber__UI.ViewComponents.PropertySingle
{
    public class _PropertySliderComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _PropertySliderComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44325/api/ProductImages?id="+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<PropertyImageDtos>>(jsonData);
                return View(values);
            }

            return View();

        }
    }
}
