using RealEstate_Dabber_Api.Dtos.CategoryDtos;

namespace RealEstate_Dabber_Api.Models.Repositoris.CategoryRepositoris
{
    public interface ICategoryRepository
    {
        Task<List<resultCategoryDto>> GetAllCategory();
        Task CreateCategory(CreateCatogaryDto categoryDto);
        Task DeleteCategory(int id);
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);



    }
}
