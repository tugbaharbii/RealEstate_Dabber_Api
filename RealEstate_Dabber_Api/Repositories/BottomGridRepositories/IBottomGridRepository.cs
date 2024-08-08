using RealEstate_Dabber_Api.Dtos.BottomGridDtos;
using RealEstate_Dabber_Api.Dtos.ServiceDtos;

namespace RealEstate_Dabber_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task <List<ResultBottomGridDto>> GetAllBottomGrid();
        Task CreateBottomGrid(CreateBottomGridDto createServiceDto);
        Task DeleteBottomGrid(int id);
        Task UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);


    }
}
