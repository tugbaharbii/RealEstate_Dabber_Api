using RealEstate_Dabber_Api.Dtos.PropertyAmetityDtos;

namespace RealEstate_Dabber_Api.Repositories.PropertyAmenityRepositories
{
    public interface IPropertyAmentiyRepository
    {
       Task< List<ResultPropertyAmenityByStatusTrueDto>> ResultPropertyAmenityByStatusTrue(int id);

    }
}
