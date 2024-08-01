﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepositori;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
     private readonly IProductRepository _productRepository;

        public ProductDetailsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("GetProductDetailByProductId")]
        public async Task<IActionResult> GetProductDetailByProductId(int id)
        {
            var values = await _productRepository.GetProductDetailByProductId(id);
            return Ok(values);
        }

    }
}
