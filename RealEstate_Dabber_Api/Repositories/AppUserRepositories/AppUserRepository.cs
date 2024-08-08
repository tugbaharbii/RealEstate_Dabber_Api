using RealEstate_Dabber_Api.Dtos.AppUserDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async  Task<GetAppUserByProductIdDto> GetAppUserProductId(int id)
        {

            string query = "Select * From AppUser Where UserID=@UserID";
            var parameters = new DynamicParameters();
            parameters.Add("@UserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return values;
            }

        }
    }
}
