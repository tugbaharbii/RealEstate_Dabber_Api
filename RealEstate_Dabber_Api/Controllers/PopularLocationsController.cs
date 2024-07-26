﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Repositories.PopularLocationRepositories;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _locationRepository;

        public PopularLocationsController(IPopularLocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        [HttpGet]
        public async
            Task<IActionResult> PopularLocationList() 
        {
           var value= await _locationRepository.GetAllPopularLocationAsync();
            return Ok(value);
        }
    }
}
