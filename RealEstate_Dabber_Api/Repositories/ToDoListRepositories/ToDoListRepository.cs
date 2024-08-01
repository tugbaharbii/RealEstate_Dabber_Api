using RealEstate_Dabber_Api.Dtos.ToDoListDtos;
using RealEstate_Dabber_Api.Models.DapperContex;
using System.Data.Dabber;

namespace RealEstate_Dabber_Api.Repositories.ToDoListRepositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;

        public ToDoListRepository(Context context)
        {
            _context = context;
        }
        public void CreateToDoList(CreateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<List<ResultToDoListDto>> GetAllToDoListAsync()
        {
            string query = "Select * From ToDoList";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();

            }
        }

        public Task<GetByIDToDoListDto> GetToDoList(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateToDoList(UpdateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
