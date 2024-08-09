using RealEstateDapperAPI.DTOS.TestimonialDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
    }
}
