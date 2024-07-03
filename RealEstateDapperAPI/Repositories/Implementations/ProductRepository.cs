using Dapper;
using RealEstateDapperAPI.DTOS.CatagoryDtos;
using RealEstateDapperAPI.DTOS.ProductDtos;
using RealEstateDapperAPI.Models.DapperContext;
using RealEstateDapperAPI.Repositories.Interfaces;

namespace RealEstateDapperAPI.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * From Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);

                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategory>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductId,Title,Price,City,District,CategoryName From Product Inner Join Category on Product.ProductCategory=Category.CategoryId";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategory>(query);

                return values.ToList();
            }
        }
    }
}
