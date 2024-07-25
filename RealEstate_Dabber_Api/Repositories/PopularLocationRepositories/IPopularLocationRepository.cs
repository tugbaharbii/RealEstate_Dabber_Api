using RealEstate_Dabber_Api.Dtos.BottomGridDtos;
using RealEstate_Dabber_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dabber_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
       
    }
}
