using RealEstate_Dabber_Api.Dtos.ProductDtos;

namespace RealEstate_Dabber_Api.Models.Repositoris.ProductRepositori
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
    }
}   
