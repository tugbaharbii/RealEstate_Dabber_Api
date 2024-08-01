using RealEstate_Dabber_Api.Dtos.BottomGridDtos;
using RealEstate_Dabber_Api.Dtos.PopularLocationDtos;
using RealEstate_Dabber_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dabber_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);
    }
}
