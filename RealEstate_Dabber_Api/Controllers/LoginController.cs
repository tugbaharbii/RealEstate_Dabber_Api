using Azure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dabber_Api.Dtos.LoginDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using RealEstate_Dabber_Api.Tools;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> SigIn(CreateLoginDto loginDto)
        {
            string query = "Select * From AppUser Where Username=@username and Password=@password";
            string query2 = "Select UserId From AppUser Where UserName=@username and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@username", loginDto.UserName);
            parameters.Add("@password", loginDto.Password);
            using (var conneciton = _context.CreateConnection())
            {
                var values = await conneciton.QueryFirstOrDefaultAsync<CreateLoginDto>(query, parameters);
                var values2 = await conneciton.QueryFirstOrDefaultAsync<GetAppUserIdDto>(query2, parameters);

                if (values != null)
                {
                    GetCheckAppUserViewModel model= new GetCheckAppUserViewModel();
                    model.UserName = values.UserName;
                    model.Id = values2.UserId;
                    var token = JwtTokenGenerator.GenerateToken(model);
                    return Ok(token);
                }
                else
                {
                    return Ok("Başarısız");
                }

            }
        }
    }
}
