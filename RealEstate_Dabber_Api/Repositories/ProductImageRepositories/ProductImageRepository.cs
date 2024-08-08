using RealEstate_Dabber_Api.Dtos.ProductImageDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.ProductImageRepositories
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly Context _context;

        public ProductImageRepository(Context context)
        {
            _context = context;
        }

        public  async Task<List<GetProductImageByProductDto>>GetProductImageByProductId(int id)
        {
            string query = "Select * From ProductImage Where ProductID=@ProductID";
            var parameters = new DynamicParameters();
            parameters.Add("@ProductID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<GetProductImageByProductDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
