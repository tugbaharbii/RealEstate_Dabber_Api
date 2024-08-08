using RealEstate_Dabber_Api.Dtos.AppUserDtos;

namespace RealEstate_Dabber_Api.Repositories.AppUserRepositories
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserProductId(int id);
    }
}
