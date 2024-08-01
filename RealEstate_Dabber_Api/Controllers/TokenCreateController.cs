using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Tools;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenCreateController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateToken(GetCheckAppUserViewModel model)
        {
          var values=JwtTokenGenerator.GenerateToken(model);
            return Ok(values);
        }
    }
}
