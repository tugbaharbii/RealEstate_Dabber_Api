
using RealEstate_Dabber_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dabber_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        
    }
}
