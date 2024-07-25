using RealEstate_Dabber_Api.Dtos.BottomGridDtos;
using RealEstate_Dabber_Api.Dtos.ProductDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using RealEstate_Dabber_Api.Models.Repositoris.ProductRepositori;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
  
            private readonly Context _context;

            public BottomGridRepository(Context context)
            {
                _context = context;
            }
           

            public void CreateBottomGrid(CreateBottomGridDto createServiceDto)
        {
            

        }

        public void DeleteBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<List<ResultBottomGridDto>> GetAllBottomGridAsync()
        {

            string query = "Select * From BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();

            }
        }

        public Task<GetBottomGridDto> GetBottomGrid(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
