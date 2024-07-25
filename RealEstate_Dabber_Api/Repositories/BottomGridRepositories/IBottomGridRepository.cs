using RealEstate_Dabber_Api.Dtos.BottomGridDtos;
using RealEstate_Dabber_Api.Dtos.ServiceDtos;

namespace RealEstate_Dabber_Api.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task <List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createServiceDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);


    }
}
