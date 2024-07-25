using RealEstate_Dabber_Api.Dtos.CategoryDtos;

namespace RealEstate_Dabber_Api.Models.Repositoris.CategoryRepositoris
{
    public interface ICategoryRepository
    {
        Task<List<resultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCatogaryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
        Task<GetByIDCategoryDto> GetCategory(int id);



    }
}
