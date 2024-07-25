using RealEstate_Dabber_Api.Dtos.CategoryDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using Dapper;

namespace RealEstate_Dabber_Api.Models.Repositoris.CategoryRepositoris
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCatogaryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public  async void DeleteCategory(int id)
        {
            string query = "Delete From Category Where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID",id);
            using (var connection= _context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async Task<List<resultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * From Category";
            using (var connection = _context.CreateConnection())
            {
              var values=await connection.QueryAsync<resultCategoryDto>(query);
                return values.ToList();
            
            }
        }

        public async Task<GetByIDCategoryDto> GetCategory(int id)
        {
            string query = "Select * From Category Where CategoryID=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryID", id);
            using (var connection = _context.CreateConnection()) 
            {
             var values = await connection.QueryFirstOrDefaultAsync<GetByIDCategoryDto>(query,parameters);
                return values;
            }


        }

        public async void UpdateCategory(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category Set CategoryName=@categoryName,CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", categoryDto.CategoryName);
            parameters.Add("@categoryStatus", categoryDto.CategoryStatus);
            parameters.Add("@categoryID", categoryDto.CategoryID);
            using (var connection = _context.CreateConnection()) 
            {
               await connection.ExecuteAsync(query, parameters);

            }
        }
    }
}
