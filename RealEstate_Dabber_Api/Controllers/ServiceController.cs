using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Repositories.ServiceRepository;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        [HttpGet]
        public async Task< IActionResult> GetServiceList()
        {
            var value =  await _serviceRepository.GetAllServiceAsync();
            return Ok(value);
        }
    }
}
