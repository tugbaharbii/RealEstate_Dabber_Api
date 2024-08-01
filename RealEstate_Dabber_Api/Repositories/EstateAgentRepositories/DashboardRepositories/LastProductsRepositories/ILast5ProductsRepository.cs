using RealEstate_Dabber_Api.Dtos.ProductDtos;

namespace RealEstate_Dabber_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public interface ILast5ProductsRepository
    {
        Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id);

    }
}
