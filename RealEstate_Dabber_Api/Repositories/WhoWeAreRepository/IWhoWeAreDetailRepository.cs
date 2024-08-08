
using RealEstate_Dabber_Api.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dabber_Api.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreDetailRepository
    {

        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetail();
        Task CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        Task DeleteWhoWeAreDetail(int id);
        Task UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
