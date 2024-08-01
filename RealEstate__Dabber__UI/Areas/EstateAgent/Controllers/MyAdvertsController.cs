﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RealEstate__Dabber__UI.Dtos.CategoryDtos;
using RealEstate__Dabber__UI.Dtos.ProductDtos;
using RealEstate__Dabber__UI.Services;
using System.Text;

namespace RealEstate__Dabber__UI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class MyAdvertsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;
        public MyAdvertsController(IHttpClientFactory httpClientFactory,ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IActionResult> ActiveAdverts()
        {
            var id = _loginService.GetUserId;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44325/api/Products/ProductAdvertsListByEmployeeByTrue?id=" + id );
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductAdvertListWithCategoryByEmployeeDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        public async Task<IActionResult> PassiveAdverts()
        {
            var id = _loginService.GetUserId;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44325/api/Products/ProductAdvertListByEmployeeByFalse?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductAdvertListWithCategoryByEmployeeDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task< IActionResult> CreateAdvert() 
        {
            var client = _httpClientFactory.CreateClient();
            var responsemessage = await client.GetAsync("https://localhost:44325/api/Categories");

            var jsaonData = await responsemessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<resultCategoryDto>>(jsaonData);

            List<SelectListItem> categoryValues = (from x in values.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.v = categoryValues;

            return View();
        }

        [HttpPost]  
        public async Task<IActionResult> CreateAdvert(CreateProductDto createProductDto)
        {
            createProductDto.DealOfTheDay = false;
            createProductDto.AdvertisementDate = DateTime.Now;
            createProductDto.ProductStatus = true;

            var id = _loginService.GetUserId;
            createProductDto.EmployeeID = int.Parse(id);

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44325/api/Products", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
