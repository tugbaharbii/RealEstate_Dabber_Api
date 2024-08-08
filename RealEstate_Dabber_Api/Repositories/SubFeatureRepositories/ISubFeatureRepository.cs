using RealEstate_Dabber_Api.Dtos.SubFeatureDtos;

namespace RealEstate_Dabber_Api.Repositories.SubFeatureRepositories
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>>GetAllSubFeatureAsync();
    }
}
