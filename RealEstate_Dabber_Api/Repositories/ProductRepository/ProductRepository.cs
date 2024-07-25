using RealEstate_Dabber_Api.Dtos.CategoryDtos;
using RealEstate_Dabber_Api.Dtos.ProductDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepositori;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Models.Repositoris.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {

            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();

            }

        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {

            string query = "Select ProductID,Title,Price,City,District,CategoryName,CoverImage,Type,Address From Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();

            }
        }
    }
}
