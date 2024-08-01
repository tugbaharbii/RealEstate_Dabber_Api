using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductsRepository _last5ProductsRepository;
public EstateAgentLastProductsController(ILast5ProductsRepository last5ProductsRepository)
        {
            _last5ProductsRepository = last5ProductsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetLastProductAsync(int id)
        {
            var values = await _last5ProductsRepository.GetLast5ProductAsync(id);
            return Ok(values);
        }
    }
}
    