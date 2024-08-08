using RealEstate_Dabber_Api.Dtos.ProductDetailDtos;
using RealEstate_Dabber_Api.Dtos.ProductImageDtos;

namespace RealEstate_Dabber_Api.Repositories.ProductImageRepositories
{
    public interface IProductImageRepository
    {
        Task<List<GetProductImageByProductDto>> GetProductImageByProductId(int id);

    }
}
