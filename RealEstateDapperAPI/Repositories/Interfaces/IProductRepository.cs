using RealEstateDapperAPI.DTOS.ProductDtos;

namespace RealEstateDapperAPI.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategory>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeToTrue(int id);
        void ProductDealOfTheDayStatusChangeToFalse(int id);

    }
}
