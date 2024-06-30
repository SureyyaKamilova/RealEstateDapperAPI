using RealEstateDapperAPI.DTOS.CatagoryDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto categoryDto);
    }
}
