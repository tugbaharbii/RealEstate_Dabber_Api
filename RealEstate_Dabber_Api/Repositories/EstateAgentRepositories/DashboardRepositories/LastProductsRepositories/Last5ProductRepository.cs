using RealEstate_Dabber_Api.Dtos.ProductDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public class Last5ProductRepository : ILast5ProductsRepository
    {
        private readonly Context _context;

        public Last5ProductRepository(Context context)
        {
            _context = context;
        }
        public async  Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id)
        {

            string query = "Select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,AdvertisementDate From Product Inner Join Category On Product.ProductCategory=Category.CategoryID Where EmployeeID=@employeeId Order By ProductID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query,parameters);
                return values.ToList();

            }
        }
    }
}
