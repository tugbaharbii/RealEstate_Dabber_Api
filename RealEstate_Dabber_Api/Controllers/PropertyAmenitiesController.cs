using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Repositories.PropertyAmenityRepositories;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyAmenitiesController : ControllerBase
    {
        private readonly IPropertyAmentiyRepository _propertyAmentiyRepository;

        public PropertyAmenitiesController(IPropertyAmentiyRepository propertyAmentiyRepository)
        {
            _propertyAmentiyRepository = propertyAmentiyRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ResultPropertyAmenityByStatusTrue(int id)
        {
            var values = await _propertyAmentiyRepository.ResultPropertyAmenityByStatusTrue(id);
            return Ok(values);
        }

    }
}
